using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace TrayCheat
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //获取此程序的进程名
            string currentProcessName = Process.GetCurrentProcess().ProcessName;
            //取出和此进程同名的所有其他进程
            Process[] processes = Process.GetProcessesByName(currentProcessName);
            //如果存在其他同名进程
            if (processes.Length >= 2)
            {
                MessageBox.Show("系统中已经有一个程序进程在运行, 您不能同时运行多个实例!", "提示:");
                return;
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
        }
    }
}
