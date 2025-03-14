using System;
using System.IO;
using System.Windows.Forms;

namespace SteamUserData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 查询Steam用户信息
        /// </summary>
        /// <param name="SteamID">SteamID,通常以7656为开头</param>
        /// <returns></returns>
        //public static async void SteamUserData(string SteamID)
        //{
        //    // 创建HttpClient实例
        //    var httpClient = new HttpClient();

        //    try
        //    {
        //        // 构建GET请求的URL，将用户ID作为查询参数
        //        var requestUrl = $"https://uapis.cn/api/steamuserinfo?input={SteamID}";

        //        // 发送GET请求并获取响应
        //        var response = await httpClient.GetAsync(requestUrl);

        //        // 检查响应是否成功
        //        if (!response.IsSuccessStatusCode)
        //        {
        //            MessageBox.Show($"Request failed with status code: {response.StatusCode}");
        //            return;
        //        }

        //        // 读取响应内容
        //        var responseData = await response.Content.ReadAsStringAsync();
        //        // 压缩 JSON 字符串
        //        string compressedJson = CompressJson(responseData);
        //        // 直接解析 JSON 字符串
        //        NinjaMagisk.Text.Json.JObject jObject = NinjaMagisk.Text.Json.JObject.Parse(compressedJson);
        //        // 反序列化为 SteamType 对象
        //        var SteamType = NinjaMagisk.Text.Json.DeserializeObject<SteamType>(compressedJson);
        //        // 检查 jObject 是否为空
        //        if (jObject == null)
        //        {
        //            return;
        //        }
        //        MessageBox.Show(
        //            "Steam 个人信息查询\n\n" +
        //            $"Https 返回值: {SteamType.code}\n" +
        //            $"SteamID: {SteamType.steamID}\n" +
        //            $"用户名: {SteamType.username} \n" +
        //            $"个人主页地址: {SteamType.profileurl.Replace("\\/", "/")}\n" +
        //            $"账号创建日期: {SteamType.accountcreationdate}\n" +
        //            $"账号绑定区域: {SteamType.location}\n" +
        //            $"当前状态: {SteamType.onlinestatus}\n", "查询结果", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        //    }
        //    catch (Exception ex)
        //    {
        //        // 捕获并输出异常
        //        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
        //#region Steam Get Json Process
        //public static string CompressJson(string json)
        //{
        //    var result = new StringBuilder();
        //    bool inString = false; // 是否在字符串内
        //    bool skipWhitespace = false; // 是否跳过空白字符

        //    for (int i = 0; i < json.Length; i++)
        //    {
        //        char currentChar = json[i];

        //        // 处理引号
        //        if (currentChar == '"')
        //        {
        //            inString = !inString; // 切换字符串状态
        //            result.Append(currentChar);
        //            continue;
        //        }

        //        // 在字符串内，直接追加字符
        //        if (inString)
        //        {
        //            result.Append(currentChar);
        //            continue;
        //        }

        //        // 处理空白字符
        //        if (char.IsWhiteSpace(currentChar))
        //        {
        //            // 如果当前字符是空格，且需要跳过空白字符，则跳过
        //            if (skipWhitespace)
        //            {
        //                continue;
        //            }

        //            // 检查是否需要保留空格（如日期时间字段）
        //            if (IsDateTimeField(json, i))
        //            {
        //                result.Append(currentChar);
        //                skipWhitespace = true; // 跳过后续空白字符
        //                continue;
        //            }

        //            // 否则，跳过空白字符
        //            continue;
        //        }

        //        // 追加非空白字符
        //        result.Append(currentChar);
        //        skipWhitespace = false; // 重置跳过空白字符的标志
        //    }

        //    return result.ToString();
        //}

        //// 检查当前字符是否属于日期时间字段
        //private static bool IsDateTimeField(string json, int index)
        //{
        //    // 检查当前字符是否在日期时间字段中
        //    // 例如："accountcreationdate":"2022-10-23 20:23:58"
        //    string[] dateTimeFields = { "accountcreationdate", "lastlogoff" };

        //    foreach (var field in dateTimeFields)
        //    {
        //        // 检查字段名是否出现在当前位置之前
        //        if (index >= field.Length && json.Substring(index - field.Length, field.Length) == field)
        //        {
        //            return true;
        //        }
        //    }

        //    return false;
        //}
        //// 自定义类型，用于反序列化 JSON 数据
        //public class SteamType
        //{
        //    public int code { get; set; }
        //    public string communitystate { get; set; }
        //    public string steamID { get; set; }
        //    public string steamID3 { get; set; }
        //    public string steamID64 { get; set; }
        //    public string username { get; set; }
        //    public string realname { get; set; }
        //    public string profileurl { get; set; }
        //    public string avatar { get; set; }
        //    public string accountcreationdate { get; set; }
        //    public string lastlogoff { get; set; }
        //    public string location { get; set; }
        //    public string onlinestatus { get; set; }
        //}
        //#endregion


        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Leave += TextBox_Leave;
            textBox5.Leave += TextBox_Leave;
            textBox4.Leave += TextBox_Leave;
            textBox3.Leave += TextBox_Leave;
            textBox6.Leave += TextBox_Leave;
            textBox7.Leave += TextBox_Leave;
            textBox8.Leave += TextBox_Leave;
            textBox9.Leave += TextBox_Leave;
            textBox10.Leave += TextBox_Leave;
            textBox11.Leave += TextBox_Leave;
            textBox12.Leave += TextBox_Leave;
            textBox13.Leave += TextBox_Leave;
            textBox14.Leave += TextBox_Leave;
        }

        private async void Button1_Click(object sender, EventArgs e)
        {
            string SteamID = textBox1.Text;
            var steamType = await NinjaMagisk.API.SteamUserData(SteamID);
            if (steamType != null)
            {
                textBox2.Text = steamType.username;
                textBox5.Text = steamType.steamID;
                textBox4.Text = steamType.steamID3;
                textBox3.Text = steamType.steamID64;
                textBox6.Text = steamType.communitystate;
                textBox7.Text = steamType.realname;
                textBox8.Text = steamType.profileurl.Replace("\\/", "/");
                textBox9.Text = steamType.avatar.Replace("\\/", "/");
                textBox10.Text = steamType.accountcreationdate;
                textBox11.Text = steamType.lastlogoff;
                textBox12.Text = steamType.location;
                textBox13.Text = steamType.onlinestatus;
                textBox14.Text = steamType.friendcode;

                // 将所有 TextBox 控件放入一个数组
                TextBox[] textBoxes = { textBox2, textBox5, textBox4, textBox3, textBox6, textBox7, textBox8, textBox9, textBox10, textBox11, textBox12, textBox13, textBox14 };

                // 遍历数组并设置 ReadOnly 属性
                foreach (var textBox in textBoxes)
                {
                    textBox.Enabled = true;
                }
            }
            else
            {
                // 将所有 TextBox 控件放入一个数组
                TextBox[] textBoxes = { textBox1, textBox2, textBox5, textBox4, textBox3, textBox6, textBox7, textBox8, textBox9, textBox10, textBox11, textBox12, textBox13, textBox14 };

                // 遍历数组并设置 ReadOnly 属性
                foreach (var textBox in textBoxes)
                {
                    textBox.Clear();
                    if (textBox == textBox1)
                        continue;
                    textBox.Enabled = false;
                }
            }
        }
        // 通用事件处理程序

        private void TextBox_Leave(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                // 取消文本选择
                textBox.SelectionLength = 0;
            }
        }
        private void TextBox2_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox2.Text);
        }

        private void TextBox5_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox5.Text);
        }

        private void TextBox4_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox4.Text);
        }

        private void TextBox3_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox3.Text);
        }

        private void TextBox6_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox6.Text);
        }

        private void TextBox7_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox7.Text);
        }

        private void TextBox8_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox8.Text);
        }

        private void TextBox9_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox9.Text);
        }

        private void TextBox10_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox10.Text);
        }

        private void TextBox11_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox11.Text);
        }

        private void TextBox12_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox12.Text);
        }

        private void TextBox13_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox13.Text);
        }

        private void TextBox14_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox14.Text);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string Text = $"SteamID: {textBox5.Text}\n" +
                $"SteamID3: {textBox4.Text}\n" +
                $"SteamID64: {textBox3.Text}\n" +
                $"用户名: {textBox2.Text}\n" +
                $"真实姓名: {textBox7.Text}\n" +
                $"个人主页: {textBox8.Text}\n" +
                $"头像地址: {textBox9.Text}\n" +
                $"账号创建日期: {textBox10.Text}\n" +
                $"最后登录日期: {textBox11.Text}\n" +
                $"账号绑定区域: {textBox12.Text}\n" +
                $"当前状态: {textBox13.Text}\n" +
                $"好友代码: {textBox14.Text}\n";
            var file = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), $"Steam User {textBox3.Text}`s Data.txt");
            if (!File.Exists(file) || File.Exists(file))
                File.Create(file).Close();


            StreamWriter sw = new StreamWriter(file);
            sw.Write(Text);
            sw.Close();
            sw.Dispose();
        }
    }
}
