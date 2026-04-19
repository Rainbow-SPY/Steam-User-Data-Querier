using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AntdUI;
using Rox.Runtimes;
using SteamUserData.Properties;
using UAPI;
using static Rox.Runtimes.LocalizedString;
using static Rox.Runtimes.LogLibraries;

namespace SteamUserData
{
    public partial class Main : Window
    {
        private static Font CustomFont(int size = 10) => new Font("微软雅黑", size, FontStyle.Regular);

        public Main()
        {
            InitializeComponent();
            foreach (var item in alerts())
                item.Hide();

            Thread_I.NewThread(() => p(this));
        }

        private static void p(Form parent)
        {
            Thread.Sleep(1000);
            var a = new Modal.Config(parent, "温馨提示", "如果遇到请求失败 TaskCanceled 取消了一个任务, 请等待1分钟后再次尝试, 已知问题已经在修复中...",
                TType.Info)
            {
                Font = CustomFont(10),
                OkFont = CustomFont(10),
                OkText = "我知道了",
                MaskClosable = false,
                Draggable = false,
            }.open();
        }

        private void Input_Leave(object sender, EventArgs e)
        {
            if (sender is Input textBox)
                // 取消文本选择
                textBox.SelectionLength = 0;
        }

        internal async Task<string> GetGroupTitle(string gid)
        {
            try
            {
                if (Rox.Runtimes.Network_I.GetPingDelay("steamcommunity.com", 1000) > 500)
                {
                    WriteLog.Error(LogKind.Network, "无法连接到 steamcommunity.com, 因为 DelayMs 大于 400ms");
                    return null;
                }
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

                WriteLog.Info(LogKind.Network, $"最终请求的 URL: {response.RequestMessage.RequestUri}");
                // 使用正则表达式提取<title>标签内容
                var match = Regex.Match(await response.Content.ReadAsStringAsync(), @"<title>(.*?)</title>",
                    RegexOptions.IgnoreCase);
                if (!match.Success)
                    return "未匹配到结果";

                var groupName = match.Groups[1].Value.Trim()
                    .Split(new[] { "::" }, StringSplitOptions.RemoveEmptyEntries).LastOrDefault()?.Trim();

                if (groupName == "Error")
                    return "未匹配到结果";
                WriteLog.Info(LogKind.Regex, $"获取到的群组名称: {groupName}");
#if DEBUG
                MessageBox_I.Info($"获取到的群组名称: {groupName}", _TIPS);
#endif

                return groupName;
            }
            catch (Exception ex)
            {
                WriteLog.Error(_Exception_With_xKind("获取群组标题", ex));
                return null;
            }
        }

        public Input[] inputs() => new[]
            { IUsername, ISteamID3, ICMGroupID, IFriendCode, ISteamID, ISteamID64, IPersonaname, IAccountCreatedStr };

        public Alert[] alerts() => new[] { ASteamCMVisibility, AOnlineStatus, ACMAbout, ARegistryRegion };

        public void ResetAlerts()
        {
            ASteamCMVisibility.Icon = TType.Info;
            ASteamCMVisibility.Text = "可见";
            ASteamCMVisibility.Hide();
            AOnlineStatus.Icon = TType.Info;
            AOnlineStatus.Text = "";
            AOnlineStatus.Hide();
            ACMAbout.Icon = TType.Info;
            ACMAbout.Text = "已填写";
            ACMAbout.Hide();
            ARegistryRegion.Icon = TType.Info;
            ARegistryRegion.Text = "";
            ARegistryRegion.Hide();
        }

        private async void GetData_Click(object sender, EventArgs e)
        {
            try
            {
                var SteamID = IInput.Text;
                if (string.IsNullOrEmpty(SteamID))
                {
                    WriteLog.Error($"给定的参数字符串 IInput.Text 为空或null, 错误代码: {_String_NullOrEmpty}");
                    return;
                }

                foreach (var i in inputs())
                    i.Clear();
                ResetAlerts();
                var steamType = await Steam.GetUserData(SteamID);
                if (steamType != null)
                {
                    IUsername.Text = steamType.Name;
                    ISteamID3.Text = steamType.SteamID3;
                    ICMGroupID.Text = steamType.PrimaryClanID;
                    IFriendCode.Text = steamType.FriendCode;
                    ISteamID.Text = steamType.SteamID1;
                    ISteamID64.Text = steamType.SteamID64;
                    IPersonaname.Text = steamType.RealName;
                    IAccountCreatedStr.Text = steamType.RegisterTime;
                    foreach (var i in alerts())
                        i.Show();
                    ASteamCMVisibility.Icon = steamType.IsCommunityVisibility
                        ? TType.Success
                        : TType.Error;
                    if (steamType.IsCommunityVisibility)
                        ASteamCMVisibility.Text = "不可见";
                    ACMAbout.Text = (steamType.IsInitialized
                        ? "已"
                        : "未") + "填写";
                    ACMAbout.Icon = steamType.IsInitialized
                        ? TType.Success
                        : TType.Error;
                    AOnlineStatus.Icon = steamType.PersonaState != "未知状态" || steamType.PersonaState != "离线"
                        ? TType.Error
                        : TType.Success;
                    AOnlineStatus.Text = steamType.PersonaState;
                    ARegistryRegion.Text = A(steamType.BindLocationRegionCode) == null
                        ? "未知"
                        : A(steamType.BindLocationRegionCode);
                    ARegistryRegion.Icon = string.IsNullOrWhiteSpace(A(steamType.BindLocationRegionCode))
                        ? TType.Error
                        : TType.Success;
                }
                else
                {
                    WriteLog.Error("Steam", "未能获取到 Steam 用户数据, 因为 steamType为null");
                }
            }
            catch (Exception ex)
            {
                WriteLog.Error(_Exception_With_xKind("获取 Steam 用户数据时", ex));
            }
        }

        private static string A(string code)
        {
            var csvContent = Resources.iso3166?.Replace("\r\n", "\n") ?? string.Empty;
            if (string.IsNullOrEmpty(csvContent))
            {
                WriteLog.Warning(LogKind.File, "ISO3166 CSV资源为空");
                return null;
            }

            var array = csvContent.Split('\n');
            for (var i = 1; i < array.Length; i++)
            {
                if (string.IsNullOrEmpty(array[i].Trim()))
                    continue;
                var a = array[i];
                var sp = a.Split(',');
                if (sp[1] != code)
                    continue;
                WriteLog.Info("查询到的国家/地区:" + a);
                return sp[0];
            }

            return null;
        }

        private void Input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter)
                return;
            e.Handled = true;

            button1.PerformClick();
        }

        private static void B()
        {
            string[] talk =
            {
                "你这个人真的是高高在上呢...(*咂舌)",
                "从今往后我们就是乐队，是一起演奏音乐的命运共同体",
                "你这个人，满脑子都是你自己呢",
                "祝你幸福。",
                "不要再来了!!!!!!",
            };
            WriteLog.Info("丰川祥子",
                talk[
                    new Random(new Random(new Random(new Random().Next(12, 1999)).Next(123, 321)).Next(18, 360)).Next(
                        talk.Count())]);
        }

        private void Togawa_Sakiko_MouseDoubleClick(object sender, MouseEventArgs e) => B();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e) => pictureBox1_Click(sender, e);

        private void panel1_Click(object sender, EventArgs e) => pictureBox1_Click(sender, e);

        private void pictureBox2_Click(object sender, EventArgs e) =>
            Process.Start($"https://github.com/Rainbow-SPY/Steam-User-Data-Querier");

        private void tooltip1_Click(object sender, EventArgs e) => pictureBox2_Click(sender, e);
    }
}