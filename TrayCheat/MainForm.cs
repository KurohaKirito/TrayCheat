using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace TrayCheat
{
    public partial class TrayCheat : Form
    {
        public TrayCheat()
        {
            InitializeComponent();
        }

        //初始化 360 按钮
        private void Init360_Click(object sender, EventArgs e)
        {
            Tray.InitTray();
            Tray.InitTray_1();
            Tray.InitTray_2();

            Tray.ShowTray_1();
            Tray.ShowTray_2();
        }
    }

    public class WindowsForm
    {
        [DllImport("user32.dll")]//需要导入该dll
        public static extern bool ShowWindow(IntPtr hwnd, int nCmdShow);

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern IntPtr GetForegroundWindow();

        const int SW_Hide = 0;//隐藏任务栏图标  
        const int SW_SHOWRESTORE = 1;//还原  
        const int SW_SHOWMINIMIZED = 2; //{最小化, 激活}
        const int SW_SHOWMAXIMIZED = 3;//最大化  
        const int GWL_STYLE = -16;
        const int WS_POPUP = 0x800000;
        const uint SWP_SHOWWINDOW = 0x0040;

        /// <summary>
        /// 最大化   
        /// </summary>
        public static void OnClickMaximize(IntPtr hwnd)
        {
            ShowWindow(hwnd, SW_SHOWMAXIMIZED);
        }

        /// <summary>
        /// 隐藏任务栏图标   
        /// </summary>
        public static void OnClickHide(IntPtr hwnd)
        {
            ShowWindow(hwnd, SW_Hide);
        }

        /// <summary>
        /// 最小化
        /// </summary>
        /// <param name="hwnd"></param>
        public static void OnClickMinimize(IntPtr hwnd)
        {
            ShowWindow(hwnd, SW_SHOWMINIMIZED);
        }

        /// <summary>
        /// 还原窗口
        /// </summary>
        /// <param name="hwnd"></param>
        public static void OnClickRestore(IntPtr hwnd)
        {
            ShowWindow(hwnd, SW_SHOWRESTORE);
        }
    }
}


