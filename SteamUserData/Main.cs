using AntdUI;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Rox.Runtimes.LocalizedString;
using static Rox.Runtimes.LogLibraries;

namespace SteamUserData
{
    public partial class Main : AntdUI.Window
    {
        public Main()
        {
            InitializeComponent();
            foreach (var item in alerts())
                item.Hide();
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
                var ping = new System.Net.NetworkInformation.Ping();
                var reply = ping.Send("steamcommunity.com");
                if (reply.Status != System.Net.NetworkInformation.IPStatus.Success)
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
                HttpClient httpClient = new HttpClient(new HttpClientHandler
                {
                    AllowAutoRedirect = true,
                    UseProxy = true,
                    Proxy = WebRequest.GetSystemWebProxy()
                });
                httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.3");
                var response = await httpClient.GetAsync($"https://steamcommunity.com/gid/{gid}");
                WriteLog.Info(LogKind.Network, $"请求 URL: https://steamcommunity.com/gid/{gid}");
                if (!response.IsSuccessStatusCode)
                {
                    WriteLog.Error(LogKind.Network, $"请求失败: {response.StatusCode}, {_HttpClient_Request_Failed}");
                    return null;
                }
                var responseData = await response.Content.ReadAsStringAsync();
                // 检查最终 URL 是否符合预期（例如是否仍包含 gid）
                string finalUrl = response.RequestMessage.RequestUri.ToString();
                WriteLog.Info(LogKind.Network, $"最终请求的 URL: {finalUrl}");
                // 使用正则表达式提取<title>标签内容
                Match match = Regex.Match(responseData, @"<title>(.*?)</title>", RegexOptions.IgnoreCase);
                if (match.Success)
                {
                    string[] parts = match.Groups[1].Value.Trim().Split(new[] { "::" }, StringSplitOptions.RemoveEmptyEntries);
                    string groupName = parts.LastOrDefault()?.Trim();
                    if (groupName == "Error")
                        return "未匹配到结果";
                    WriteLog.Info(LogKind.Regex, $"获取到的群组名称: {groupName}");
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
            catch (Exception ex)
            {
                WriteLog.Error(_Exception_With_xKind("获取群组标题", ex));
                return null;
            }
        }
        public Input[] inputs() => new Input[] { IUsername, ISteamID3, ICMGroupID, IFriendCode, ISteamID, ISteamID64, IPersonaname, IAccountCreatedStr };
        public Alert[] alerts() => new Alert[] { ASteamCMVisibility, AOnlineStatus, ACMAbout };
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

            IInput.Text += GetFlagEmoji("CN");
        }
        private async void GetData_Click(object sender, EventArgs e)
        {
            string SteamID = IInput.Text;
            if (string.IsNullOrEmpty(SteamID))
            {
                WriteLog.Error($"给定的参数字符串 IInput.Text 为空或null, 错误代码: {_String_NullOrEmpty}");
                return;
            }
            foreach (var i in inputs())
                i.Clear();
            ResetAlerts();
            try
            {
                var steamType = await Rox.Entertainment.SteamUserData_v1.GetDataJson_v1(SteamID, true);
                if (steamType != null)
                {
                    IUsername.Text = steamType.personaname;
                    ISteamID3.Text = steamType.steamID3;
                    ICMGroupID.Text = steamType.primaryclanid;
                    IFriendCode.Text = steamType.friendcode;
                    ISteamID.Text = Rox.Entertainment.Steam.Converter.SteamID.ToSteamID(steamType.steamid.ToString());
                    ISteamID64.Text = steamType.steamid.ToString();
                    IPersonaname.Text = steamType.realname;
                    IAccountCreatedStr.Text = steamType.timecreated_str;
                    foreach (var i in alerts())
                        i.Show();
                    ASteamCMVisibility.Icon = steamType.communityvisibilitystate == 1
                        ? TType.Success
                        : TType.Error;
                    if (steamType.communityvisibilitystate != 1)
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
                        : Rox.Entertainment.Steam.SteamID.GetPersonalState(steamType);
                    if (steamType.personastate == 0 || steamType.personastate == 3)
                        AOnlineStatus.TextTitle = "当前离线";
                }
                else
                {
                    WriteLog.Error("Steam", "未能获取到 Steam 用户数据, 因为 steamType为null");
                    return;
                }
            }
            catch (Exception ex)
            {
                WriteLog.Error(_Exception_With_xKind("获取 Steam 用户数据时", ex));
            }
        }
        /// <summary>
        /// 根据两位国家/地区代码生成国旗Emoji
        /// </summary>
        /// <param name="countryCode">两位大写代码（如CN、US、JP）</param>
        /// <returns>国旗Emoji字符串，无效代码返回空</returns>
        public static string GetFlagEmoji(string countryCode)
        {
            // 验证输入：必须是两位大写字母
            if (string.IsNullOrEmpty(countryCode) || countryCode.Length != 2)
            {
                return string.Empty;
            }

            countryCode = countryCode.ToUpper();
            char firstChar = countryCode[0];
            char secondChar = countryCode[1];

            // 验证字符范围（A-Z）
            if (firstChar < 'A' || firstChar > 'Z' || secondChar < 'A' || secondChar > 'Z')
            {
                return string.Empty;
            }

            // 计算Regional Indicator Symbol编码：A=0x1F1E6，B=0x1F1E7...Z=0x1F1FF
            int firstCode = 0x1F1E6 + (firstChar - 'A');
            int secondCode = 0x1F1E6 + (secondChar - 'A');

            // 转换为Emoji字符
            StringBuilder flagEmoji = new StringBuilder();
            flagEmoji.Append(char.ConvertFromUtf32(firstCode));
            flagEmoji.Append(char.ConvertFromUtf32(secondCode));

            return flagEmoji.ToString();
        }

        // 测试示例
        public static void TestFlagEmoji()
        {
            // 控制台需先设置UTF8编码
            Console.OutputEncoding = Encoding.UTF8;

            // 常用国家测试
            Console.WriteLine($"CN: {GetFlagEmoji("CN")} 中国");
            Console.WriteLine($"US: {GetFlagEmoji("US")} 美国");
            Console.WriteLine($"JP: {GetFlagEmoji("JP")} 日本");
            Console.WriteLine($"GB: {GetFlagEmoji("GB")} 英国");
            Console.WriteLine($"DE: {GetFlagEmoji("DE")} 德国");
            Console.WriteLine($"FR: {GetFlagEmoji("FR")} 法国");

            // 无效代码测试
            Console.WriteLine($"无效代码 12: {GetFlagEmoji("12")}");
            Console.WriteLine($"无效代码 C: {GetFlagEmoji("C")}");
        }
        private void Input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                button1.PerformClick();
            }
        }

        private void Togawa_Sakiko_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string[] talk =
            {
                "你这个人真的是高高在上呢...(*咂舌)",
                "从今往后我们就是乐队，是一起演奏音乐的命运共同体",
                "你这个人，满脑子都是你自己呢",
                "祝你幸福。",
                "不要再来了!!!!!!",
            };
            WriteLog.Info("丰川祥子", talk[new Random(new Random(new Random(new Random().Next(12,1999)).Next(123,321)).Next(18,360)).Next(talk.Count())]);
        }
    }
}