using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Rox.API;
using static Rox.Runtimes.LocalizedString;
using static Rox.Runtimes.LogLibraries;
namespace SteamUserData
{
    public partial class Form1 : Form
    {
        // 导入 Windows API
        [DllImport("kernel32.dll")]
        internal static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        internal static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        internal const int SW_HIDE = 0;     // 隐藏窗口
        internal const int SW_SHOW = 5;     // 显示窗口

        internal bool _consoleVisible = false;

        public Form1()
        {
            InitializeComponent();
            // 初始启动时隐藏控制台
            ToggleConsole(false);
        }
        // 切换控制台显示状态
        internal void ToggleConsole(bool show)
        {
            IntPtr consoleHandle = GetConsoleWindow();
            if (consoleHandle != IntPtr.Zero)
            {
                ShowWindow(consoleHandle, show ? SW_SHOW : SW_HIDE);
                _consoleVisible = show;
            }
        }
        // 按钮点击事件
        internal void BtnToggleConsole_Click(object sender, EventArgs e)
        {
            ToggleConsole(!_consoleVisible);
            btnToggleConsole.Text = _consoleVisible ? "隐藏控制台" : "显示控制台";
        }
        private void button5_Click(object sender, EventArgs e) => Process.Start($"https://steamcommunity.com/gid/{TmainGroup.Text}");
        void Avator_Link(string link) => Process.Start(link);
        private void TcommunityGroup_Click(object sender, EventArgs e) => button5_Click(sender, e);

        internal async Task<string> GetGroupTitle(string gid)
        {
            HttpClient httpClient = new HttpClient(new HttpClientHandler { AllowAutoRedirect = true });
            httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.3");
            var response = await httpClient.GetAsync($"https://steamcommunity.com/gid/{gid}");
            WriteLog.Info($"请求 URL: https://steamcommunity.com/gid/{gid}");
            if (!response.IsSuccessStatusCode)
            {
                WriteLog.Error($"请求失败: {response.StatusCode}, {_HttpClient_Request_Failed}");
                return null;
            }
            var responseData = await response.Content.ReadAsStringAsync();
            // 检查最终 URL 是否符合预期（例如是否仍包含 gid）
            string finalUrl = response.RequestMessage.RequestUri.ToString();
            WriteLog.Info($"最终请求的 URL: {finalUrl}");
            // 使用正则表达式提取<title>标签内容
            Match match = Regex.Match(responseData, @"<title>(.*?)</title>", RegexOptions.IgnoreCase);
            if (match.Success)
            {
                string[] parts = match.Groups[1].Value.Trim().Split(new[] { "::" }, StringSplitOptions.RemoveEmptyEntries);
                string groupName = parts.LastOrDefault()?.Trim(); // "bilibili"
                if (groupName == "Error")
                    return "未匹配到结果";
                WriteLog.Info($"获取到的群组名称: {groupName}");
#if DEBUG
                MessageBox_I.Info($"获取到的群组名称: {groupName}", _TIPS);
#endif

                return groupName;
            }
            else
            {
                return "未匹配到结果";
            }
        }
        // 窗口关闭时确保控制台也被关闭（可选）
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            ToggleConsole(false);
            base.OnFormClosing(e);
        }
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
            TextBox[] textBoxes = { Tinput, Tusername, TprofileVisable, TsteamID, TsteamID3, TsteamID64, TcommunityLook, TrealName, Turl, Tavator, TacCreateTime, TRegistryRegoin, Tnow, TfriendCode, TmainGroup };

            label18.Visible = true; // 显示加载提示
            // 遍历数组并设置 ReadOnly 属性
            foreach (var textBox in textBoxes)
            {
                if (textBox == Tinput)
                    continue;
                textBox.Clear();
                textBox.Enabled = false;
            }

            string SteamID = Tinput.Text;
            var steamType = await SteamUserData_v1.GetDataJson_v1(SteamID, true);
            if (steamType != null)
            {
                Tusername.Text = steamType.personaname;
                TsteamID64.Text = steamType.steamid;
                TsteamID.Text = Rox.GameExpansionFeatures.Steam.Converter.SteamID.ToSteamID(steamType.steamid);
                TsteamID3.Text = steamType.steamID3;
                TcommunityLook.Text = steamType.communityvisibilitystate == 1 ? "私密" : (steamType.communityvisibilitystate == 3 ? "公开" : "未知");
                if (steamType.realname == "N\\/A" || steamType.realname == null || steamType.realname == string.Empty)
                    TrealName.Text = "未知";
                else
                    TrealName.Text = steamType.realname;
                Turl.Text = steamType.profileurl/*.Replace("\\/", "/")*/;
                Tavator.Text = steamType.avatarfull/*.Replace("\\/", "/")*/;
                if (steamType.timecreated_str == "1970-01-01 08:00:00" || steamType.timecreated_str == "N\\/A" || steamType.timecreated_str == null || steamType.timecreated_str == string.Empty)
                    TacCreateTime.Text = "未知";
                else
                    TacCreateTime.Text = steamType.timecreated_str;
                if (steamType.loccountrycode == "N\\/A" || steamType.loccountrycode == "N\\/A" || steamType.loccountrycode == null || steamType.loccountrycode == string.Empty)
                    TRegistryRegoin.Text = "未知";
                else
                    TRegistryRegoin.Text = steamType.loccountrycode;
                switch (steamType.personastate)
                {
                    case 0:
                        Tnow.Text = "离线或私密";
                        break;
                    case 1:
                        Tnow.Text = "在线";
                        break;
                    case 2:
                        Tnow.Text = "忙碌";
                        break;
                    case 3:
                        Tnow.Text = "离开";
                        break;
                    case 4:
                        Tnow.Text = "打盹";
                        break;
                    case 5:
                        Tnow.Text = "想交易";
                        break;
                    case 6:
                        Tnow.Text = "想玩";
                        break;
                }
                TmainGroup.Text = steamType.primaryclanid;
                ThookGroup.Text = await GetGroupTitle(TmainGroup.Text);
                TprofileVisable.Text = steamType.profilestate == 1 ? "已填写个人资料" : "未填写个人资料";
                TfriendCode.Text = steamType.friendcode;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                BcommunityGroup.Enabled = true;

                // 遍历数组并设置 ReadOnly 属性
                foreach (var textBox in textBoxes)
                {
                    textBox.Enabled = true;
                }
                label18.Visible = false; // 隐藏加载提示
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
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                // 取消文本选择
                textBox.SelectionLength = 0;
            }
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

        private void TDC_RegistryRegoin(object sender, EventArgs e)
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
            string Text = $"个人资料可见性: {TprofileVisable.Text}\n" +
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
            var file = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), $"Steam User {TsteamID64.Text}`s Data.txt");
            if (!File.Exists(file) || File.Exists(file))
                File.Create(file).Close();
            StreamWriter sw = new StreamWriter(file);
            sw.Write(Text);
            sw.Close();
            sw.Dispose();
            MessageBox.Show($"Steam 用户 {Tusername.Text} 的数据已保存到桌面", "保存成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                WebBrowser webBrowser2 = new WebBrowser();
                detailForm.Controls.Add(webBrowser2);
                webBrowser2.Navigate(Tavator.Text);
                webBrowser2.Dock = DockStyle.Fill;
                detailForm.ShowDialog();
                detailForm.FormClosed += (s, args) => detailForm.Dispose();

            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Process.Start(Turl.Text);
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // 阻止默认行为（换行和提示音）
                e.Handled = true;

                // 触发 Button1 的点击事件
                button1.PerformClick();
            }
        }

        private void Turl_Click(object sender, EventArgs e) => Avator_Link(Turl.Text);

        private void Tavator_Click(object sender, EventArgs e) => Avator_Link(Tavator.Text);
    }
}
