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

        const int SW_Hide = 0;//隐藏任务栏图标  
        const int SW_SHOWRESTORE = 1;//还原  
        const int SW_SHOWMINIMIZED = 2; //{最小化, 激活}
        const int SW_SHOWMAXIMIZED = 3;//最大化  
        //const int GWL_STYLE = -16;
        //const int WS_POPUP = 0x800000;
        //const uint SWP_SHOWWINDOW = 0x0040;

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

        //事件: 隐藏任务栏图标   
        public static void OnClickHide(IntPtr hwnd)
        {
            ShowWindow(hwnd, SW_Hide);
        }
    }
}
