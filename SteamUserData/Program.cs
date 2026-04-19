using System;
using Rox.Runtimes;

namespace SteamUserData
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Console.Title = $"日志输出中, 请勿关闭!";
            new Reporter.InitializeReportInterface(form).Run();
            return;
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //WriteLog.Info(LogKind.Form, _PROCESS_STARTED + Process.GetCurrentProcess().Id);
            //Application.Run(new Form1());

            Main form() => new Main();
        }
    }
}
