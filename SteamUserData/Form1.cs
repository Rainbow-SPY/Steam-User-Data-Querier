using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Toolkit.Uwp.Notifications;
using UAPI;
using Rox.Runtimes;
using static Rox.Runtimes.LocalizedString;
using static Rox.Runtimes.LogLibraries;

namespace SteamUserData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 切换控制台显示状态
        // 按钮点击事件
        private void button5_Click(object sender, EventArgs e) =>
            Process.Start($"https://steamcommunity.com/gid/{TmainGroup.Text}");

        private static void Avatar_Link(string link) => Process.Start(link);
        private void TcommunityGroup_Click(object sender, EventArgs e) => button5_Click(sender, e);

        internal static async Task<string> GetGroupTitle(string gid)
        {
            try
            {
                if (Network_I.GetPingDelay("steamcommunity.com", 1000) > 400)
                {
                    WriteLog.Error(LogKind.Network, "无法连接到 steamcommunity.com, 因为 DelayMs 大于 400ms");
                    return null;
                }
                else
                    WriteLog.Info(LogKind.Network, "Steam Community 连接成功!");
            }
            catch (Exception ex)
            {
                WriteLog.Error(LogKind.Network, _Exception_With_xKind("测试网络时", ex));
                return null;
            }

            try
            {
                var httpClient = new HttpClient(new HttpClientHandler
                {
                    AllowAutoRedirect = true,
                    UseProxy = true,
                    Proxy = WebRequest.GetSystemWebProxy()
                });
                httpClient.DefaultRequestHeaders.Add("User-Agent",
                    "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.3");

                var response = await httpClient.GetAsync($"https://steamcommunity.com/gid/{gid}");
                WriteLog.Info(LogKind.Network, $"请求 URL: https://steamcommunity.com/gid/{gid}");
                if (!response.IsSuccessStatusCode)
                {
                    WriteLog.Error(LogKind.Network, $"请求失败: {response.StatusCode}, {_HttpClient_Request_Failed}");
                    return null;
                }

                var responseData = await response.Content.ReadAsStringAsync();
                // 检查最终 URL 是否符合预期（例如是否仍包含 gid）
                var finalUrl = response.RequestMessage.RequestUri.ToString();
                WriteLog.Info(LogKind.Network, $"最终请求的 URL: {finalUrl}");
                // 使用正则表达式提取<title>标签内容
                var match = Regex.Match(responseData, @"<title>(.*?)</title>", RegexOptions.IgnoreCase);
                if (match.Success)
                {
                    var groupName = match.Groups[1].Value.Trim()
                        .Split(new[] { "::" }, StringSplitOptions.RemoveEmptyEntries).LastOrDefault()
                        ?.Trim();
                    // "bilibili"
                    if (groupName == "Error")
                        return "未匹配到结果";
                    WriteLog.Info(LogKind.Regex, $"获取到的群组名称: {groupName}");
#if DEBUG
                    MessageBox_I.Info($"获取到的群组名称: {groupName}", _TIPS);
#endif

                    return groupName;
                }

                return "未匹配到结果";
            }
            catch (Exception ex)
            {
                WriteLog.Error(_Exception_With_xKind("获取群组标题", ex));
                return null;
            }
        }

        // 窗口关闭时确保控制台也可被……关闭
        private void Form1_Load(object sender, EventArgs e)
        {
            Tusername.Leave += TextBox_Leave;
            TprofileVisable.Leave += TextBox_Leave;
            TsteamID3.Leave += TextBox_Leave;
            TsteamID64.Leave += TextBox_Leave;
            TcommunityLook.Leave += TextBox_Leave;
            TrealName.Leave += TextBox_Leave;
            Turl.Leave += TextBox_Leave;
            Tavator.Leave += TextBox_Leave;
            TacCreateTime.Leave += TextBox_Leave;
            TRegistryRegoin.Leave += TextBox_Leave;
            Tnow.Leave += TextBox_Leave;
            TmainGroup.Leave += TextBox_Leave;
            TsteamID.Leave += TextBox_Leave;
            TfriendCode.Leave += TextBox_Leave;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            BcommunityGroup.Enabled = false;
        }

        private async void Button1_Click(object sender, EventArgs e)
        {
            // 将所有 TextBox 控件放入一个数组
            TextBox[] textBoxes =
            {
                Tinput, Tusername, TprofileVisable, TsteamID, TsteamID3, TsteamID64, TcommunityLook, ThookGroup,
                TrealName, Turl, Tavator, TacCreateTime, TRegistryRegoin, Tnow, TfriendCode, TmainGroup
            };

            label18.Visible = true; // 显示加载提示
            // 遍历数组并设置 ReadOnly 属性
            foreach (var textBox in textBoxes)
            {
                if (textBox == Tinput)
                    continue;
                textBox.Clear();
                textBox.Enabled = false;
            }

            label21.Enabled = false; // 禁用社区群组按钮


            var SteamID = Tinput.Text;
            var steamType = await Steam.GetUserData(SteamID, null, "");
            if (steamType != null)
            {
                Tusername.Text = steamType.Name;
                TsteamID3.Text = steamType.SteamID3;
                TcommunityLook.Text = steamType.IsCommunityVisibility ? "可见" : "私密";

                if (steamType.RealName == "N\\/A" || steamType.RealName == null || steamType.RealName == string.Empty)
                    TrealName.Text = "未知";
                else
                    TrealName.Text = steamType.RealName;

                Turl.Text = steamType.ProfileUrl;
                Tavator.Text = steamType.Avatar_184x184;

                if (steamType.RegisterTime == "1970-01-01 08:00:00" || steamType.RegisterTime == "N\\/A" ||
                    steamType.RegisterTime == null || steamType.RegisterTime == string.Empty)
                    TacCreateTime.Text = "未知";
                else
                    TacCreateTime.Text = steamType.RegisterTime;

                if (steamType.BindLocationRegionCode == "N\\/A" || steamType.BindLocationRegionCode == "N\\/A" ||
                    steamType.BindLocationRegionCode == null || steamType.BindLocationRegionCode == string.Empty)
                    TRegistryRegoin.Text = "未知";
                else
                    TRegistryRegoin.Text = steamType.BindLocationRegionCode;

                Tnow.Text = steamType.PersonaState;
                TprofileVisable.Text = steamType.PersonaState;
                TfriendCode.Text = steamType.FriendCode;
                TmainGroup.Text = steamType.PrimaryClanID;
                
                var groupTitle = await GetGroupTitle(TmainGroup.Text);
                if (groupTitle == null)
                {
                    WriteLog.Error(LogKind.Network, "无法连接到 Steam 社区");
                    ThookGroup.ForeColor = System.Drawing.Color.Red;
                    ThookGroup.Text = "无法连接到 Steam 社区";
                }
                else
                {
                    ThookGroup.ForeColor = System.Drawing.Color.RoyalBlue;
                    ThookGroup.Text = groupTitle;
                }

                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                BcommunityGroup.Enabled = true;

                // 遍历数组并设置 ReadOnly 属性
                foreach (var textBox in textBoxes) 
                    textBox.Enabled = true;

                label18.Visible = false; // 隐藏加载提示
                label21.Enabled = true;
            }
            else
            {
                // 将所有 TextBox 控件放入一个数组
                WriteLog.Warning("steamType 为 null");
                MessageBox_I.Warning("steamType 为 null", _ERROR);
                // 遍历数组并设置 ReadOnly 属性
                foreach (var textBox in textBoxes)
                {
                    textBox.Clear();
                    if (textBox == Tinput)
                        continue;
                    textBox.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    BcommunityGroup.Enabled = false;
                }

                label18.Visible = false; // 隐藏加载提示
                label21.Enabled = false;
            }
        }

        private static void TextBox_Leave(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
                // 取消文本选择
                textBox.SelectionLength = 0;
        }

        private void TDC_username(object sender, EventArgs e)
        {
            new ToastContentBuilder().AddText($"已复制用户名: {Tusername.Text}").Show();
            Clipboard.SetText(Tusername.Text);
        }

        private void TDC_mailGroup(object sender, EventArgs e)
        {
            new ToastContentBuilder().AddText($"已复制主群组ID: {TmainGroup.Text}").Show();
            Clipboard.SetText(TmainGroup.Text);
        }

        private void TDC_steamID(object sender, EventArgs e)
        {
            new ToastContentBuilder().AddText($"已复制SteamID: {TsteamID.Text}").Show();
            Clipboard.SetText(TsteamID.Text);
        }

        private void TDC_steamID3(object sender, EventArgs e)
        {
            new ToastContentBuilder().AddText($"已复制SteamID3: {TsteamID3.Text}").Show();
            Clipboard.SetText(TsteamID3.Text);
        }

        private void TDC_steamID64(object sender, EventArgs e)
        {
            new ToastContentBuilder().AddText($"已复制SteamID64: {TsteamID64.Text}").Show();
            Clipboard.SetText(TsteamID64.Text);
        }

        private void TDC_realName(object sender, EventArgs e)
        {
            new ToastContentBuilder().AddText($"已复制真实姓名: {TrealName.Text}").Show();
            Clipboard.SetText(TrealName.Text);
        }

        private void TDC_acCreateTime(object sender, EventArgs e)
        {
            new ToastContentBuilder().AddText($"已复制账号创建日期: {TacCreateTime.Text}").Show();
            Clipboard.SetText(TacCreateTime.Text);
        }

        private void TDC_RegistryRegion(object sender, EventArgs e)
        {
            new ToastContentBuilder().AddText($"已复制账号绑定区域: {TRegistryRegoin.Text}").Show();
            Clipboard.SetText(TRegistryRegoin.Text);
        }

        private void TDC_now(object sender, EventArgs e)
        {
            new ToastContentBuilder().AddText($"已复制当前状态: {Tnow.Text}").Show();
            Clipboard.SetText(Tnow.Text);
        }

        private void TDC_friendCode(object sender, EventArgs e)
        {
            new ToastContentBuilder().AddText($"已复制好友代码: {TfriendCode.Text}").Show();
            Clipboard.SetText(TfriendCode.Text);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (Tinput.Text == "" || Tavator.Text == "")
            {
                MessageBox.Show("请输入SteamID64请求数据后,再进行保存", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var text = $"个人资料可见性: {TprofileVisable.Text}\n" +
                       $"SteamID: {TsteamID.Text}\n" +
                       $"SteamID3: {TsteamID3.Text}\n" +
                       $"SteamID64: {TsteamID64.Text}\n" +
                       $"用户名: {Tusername.Text}\n" +
                       $"真实姓名: {TrealName.Text}\n" +
                       $"个人主页: {Turl.Text}\n" +
                       $"头像地址: {Tavator.Text}\n" +
                       $"账号创建日期: {TacCreateTime.Text}\n" +
                       $"账号绑定区域: {TRegistryRegoin.Text}\n" +
                       $"社区查看权限: {TcommunityLook.Text}\n" +
                       $"主群组ID: {TmainGroup.Text}\n" +
                       $"当前状态: {Tnow.Text}\n" +
                       $"好友代码: {TfriendCode.Text}\n";
            
            var file = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory),
                $"Steam User {TsteamID64.Text}`s Data.txt");
            
            if (!File.Exists(file) || File.Exists(file))
                File.Create(file).Close();

            using (var sw = new StreamWriter(file))
            {
                sw.Write(text);
                sw.Close();
            }

            MessageBox.Show($"Steam 用户 {Tusername.Text} 的数据已保存到桌面", "保存成功", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (Tinput.Text == "" || Tavator.Text == "")
            {
                WriteLog.Error(_value_Not_Is_NullOrEmpty($"{Tinput.Text} 或 {Tavator.Text}"));
                MessageBox.Show("请输入SteamID请求数据后,再进行查看头像", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var detailForm = new Form())
            {
                Text = "Steam 头像查看器";
                Width = 500;
                Height = 500;
                StartPosition = FormStartPosition.CenterScreen;
                Icon = Icon;
                BackgroundImage = BackgroundImage;
                BackgroundImageLayout = BackgroundImageLayout;
                // TopMost = true;
                var webBrowser2 = new WebBrowser();
                detailForm.Controls.Add(webBrowser2);
                webBrowser2.Navigate(Tavator.Text);
                webBrowser2.Dock = DockStyle.Fill;
                detailForm.ShowDialog();
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Process.Start(Turl.Text);
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter)
                return;
            // 阻止默认行为（换行和提示音）
            e.Handled = true;

            // 触发 Button1 的点击事件
            button1.PerformClick();
        }

        private void Turl_Click(object sender, EventArgs e) => Avatar_Link(Turl.Text);

        private void Tavator_Click(object sender, EventArgs e) => Avatar_Link(Tavator.Text);

        private void label21_Click(object sender, EventArgs e) => TcommunityGroup_Click(sender, e);
    }
}