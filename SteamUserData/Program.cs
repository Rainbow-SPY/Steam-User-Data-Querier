using Rox.Runtimes;
using System;
using static Rox.Runtimes.Reporter;
namespace SteamUserData
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Console.Title = $"日志输出中, 请勿关闭!";
            Main form() => new Main();
            InitializeReportInterface reporter = new Reporter.InitializeReportInterface(form);
            reporter.Run();
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //WriteLog.Info(LogKind.Form, _PROCESS_STARTED + Process.GetCurrentProcess().Id);
            //Application.Run(new Form1());

        }
    }
}
