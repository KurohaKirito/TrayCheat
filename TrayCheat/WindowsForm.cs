using System;
using System.Runtime.InteropServices;

namespace TrayCheat
{
    public class WindowsForm
    {
        [DllImport("user32.dll")]//需要导入该dll
        public static extern bool ShowWindow(IntPtr hwnd, int nCmdShow);

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern IntPtr GetForegroundWindow();

        private const int SW_Hide = 0;//隐藏窗口 
        private const int SW_SHOWRESTORE = 1;//还原窗口, 应用程序在第一次显示窗口的时候应该指定此标志
        private const int SW_SHOWMINIMIZED = 2;//激活窗口并最小化
        private const int SW_SHOWMAXIMIZED = 3;//激活窗口并最大化
        //private const int SW_RESTORE = 9;//还原窗口
        //private const int GWL_STYLE = -16;
        //private const int WS_POPUP = 0x800000;
        //private const uint SWP_SHOWWINDOW = 0x0040;

        //事件: 最大化窗口
        public static void OnClickMaximize(IntPtr hwnd)
        {
            ShowWindow(hwnd, SW_SHOWMAXIMIZED);
        }

        //事件: 最小化窗口
        public static void OnClickMinimize(IntPtr hwnd)
        {
            ShowWindow(hwnd, SW_SHOWMINIMIZED);
        }

        //事件: 还原窗口
        public static void OnClickRestore(IntPtr hwnd)
        {
            ShowWindow(hwnd, SW_SHOWRESTORE);
        }

        //事件: 隐藏窗口
        public static void OnClickHide(IntPtr hwnd)
        {
            ShowWindow(hwnd, SW_Hide);
        }
    }
}
