using System;
using System.Runtime.InteropServices;

namespace TrayCheat
{
    public static class WindowsForm
    {
        [DllImport("user32.dll")]//需要导入该dll
        private static extern bool ShowWindow(IntPtr hwnd, int nCmdShow);

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        private static extern IntPtr GetForegroundWindow();

        private const int SW_Hide = 0;//隐藏窗口 
        private const int SW_SHOWRESTORE = 1;//还原窗口, 应用程序在第一次显示窗口的时候应该指定此标志
        private const int SW_SHOWMINIMIZED = 2;//激活窗口并最小化
        private const int SW_SHOWMAXIMIZED = 3;//激活窗口并最大化
        private const int SW_RESTORE = 9;//还原窗口

        public static IntPtr MyGetForegroundWindow()
        {
            return GetForegroundWindow();//获取窗口句柄, 必须在窗口被激活之后执行这句代码
        }

        //最大化
        public static void OnClickMaximize(IntPtr hwnd)
        {
            ShowWindow(hwnd, SW_SHOWMAXIMIZED);
        }

        //最小化
        public static void OnClickMinimize(IntPtr hwnd)
        {
            ShowWindow(hwnd, SW_SHOWMINIMIZED);
        }

        //还原
        public static void OnClickRestore(IntPtr hwnd)
        {
            ShowWindow(hwnd, SW_SHOWRESTORE);
            ShowWindow(hwnd, SW_RESTORE);
        }

        //隐藏
        public static void OnClickHide(IntPtr hwnd)
        {
            ShowWindow(hwnd, SW_Hide);
        }
    }
}
