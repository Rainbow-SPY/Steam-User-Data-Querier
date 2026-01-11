using System;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using AntdUI;
using Rox.Entertainment;
using SteamUserData.Properties;
using static Rox.Runtimes.LocalizedString;
using static Rox.Runtimes.LogLibraries;

namespace SteamUserData
{
    public partial class Main : Window
    {
        public Main()
        {
            InitializeComponent();
            foreach (var item in alerts())
                item.Hide();

            //    IAccountCreatedStr.Suffix = "v"
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
                // 测试 Steam 社区是否可达
                var ping = new Ping();
                var reply = ping.Send("steamcommunity.com");
                if (reply != null && reply.Status != IPStatus.Success)
                {
                    WriteLog.Error(LogKind.Network, "无法连接到 steamcommunity.com");
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

                var responseData = await response.Content.ReadAsStringAsync();
                // 检查最终 URL 是否符合预期（例如是否仍包含 gid）
                var finalUrl = response.RequestMessage.RequestUri.ToString();
                WriteLog.Info(LogKind.Network, $"最终请求的 URL: {finalUrl}");
                // 使用正则表达式提取<title>标签内容
                var match = Regex.Match(responseData, @"<title>(.*?)</title>", RegexOptions.IgnoreCase);
                if (!match.Success) return "未匹配到结果";
                var parts = match.Groups[1].Value.Trim().Split(new[] { "::" }, StringSplitOptions.RemoveEmptyEntries);
                var groupName = parts.LastOrDefault()?.Trim();
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
                var steamType = await SteamUserData_v1.GetDataJson_v1(SteamID, true);
                if (steamType != null)
                {
                    //Thread_I.NewThread(B);
                    //async void B()
                    //{
                    //    using (var _ = image3D2.Image = Image.FromStream(await new HttpClient().GetStreamAsync(steamType.avatarfull)) ?? SystemIcons.Error.ToBitmap())
                    //    {

                    //    }
                    //}
                    IUsername.Text = steamType.personaname;
                    ISteamID3.Text = steamType.steamID3;
                    ICMGroupID.Text = steamType.primaryclanid;
                    IFriendCode.Text = steamType.friendcode;
                    ISteamID.Text = Steam.Converter.SteamID.ToSteamID(steamType.steamid.ToString());
                    ISteamID64.Text = steamType.steamid.ToString();
                    IPersonaname.Text = steamType.realname;
                    IAccountCreatedStr.Text = steamType.timecreated_str;
                    foreach (var i in alerts())
                        i.Show();
                    ASteamCMVisibility.Icon = steamType.communityvisibilitystate == 3
                        ? TType.Success
                        : TType.Error;
                    if (steamType.communityvisibilitystate != 3)
                        ASteamCMVisibility.Text = "不可见";
                    ACMAbout.Text = (steamType.profilestate == 1
                        ? "已"
                        : "未") + "填写";
                    ACMAbout.Icon = steamType.profilestate == 1
                        ? TType.Success
                        : TType.Error;
                    AOnlineStatus.Icon = steamType.personastate == 0 || steamType.personastate == 3
                        ? TType.Error
                        : TType.Success;
                    AOnlineStatus.Text = steamType.personastate == 0 || steamType.personastate == 3
                        ? ""
                        : Steam.SteamID.GetPersonalState(steamType);
                    ARegistryRegion.Text = A(steamType.loccountrycode) == null
                        ? "未知"
                        : A(steamType.loccountrycode);
                    ARegistryRegion.Icon = string.IsNullOrWhiteSpace(A(steamType.loccountrycode))
                        ? TType.Error
                        : TType.Success;
                    if (steamType.personastate == 0 || steamType.personastate == 3)
                        AOnlineStatus.TextTitle = "当前离线";
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

        string A(string code)
        {
            var csvContent = Resources.iso3166?.Replace("\r\n", "\n") ?? string.Empty;
            if (string.IsNullOrEmpty(csvContent))
            {
                WriteLog.Warning("ISO3166 CSV资源为空");
                return null;
            }

            var array = csvContent.Split('\n');
            for (var i = 1; i < array.Length; i++)
            {
                if (string.IsNullOrEmpty(array[i].Trim())) continue;
                var a = array[i];
                var sp = a.Split(',');
                if (sp[1] != code) continue;
                WriteLog.Info("查询到的国家/地区:" + a);
                return sp[0];
            }

            return null;
        }

        private void Input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter) return;
            e.Handled = true;

            button1.PerformClick();
        }

        void A()
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

        private void Togawa_Sakiko_MouseDoubleClick(object sender, MouseEventArgs e) => A();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

      //  Process.Start($"{sender}"); }

        private void label9_Click(object sender, EventArgs e) => pictureBox1_Click(sender, e);

        private void panel1_Click(object sender, EventArgs e) => pictureBox1_Click(sender, e);

        private void pictureBox2_Click(object sender, EventArgs e) =>
            Process.Start($"https://github.com/Rainbow-SPY/Steam-User-Data-Querier");

        private void tooltip1_Click(object sender, EventArgs e) => pictureBox2_Click(sender, e);
    }
}