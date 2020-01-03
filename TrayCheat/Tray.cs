using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace TrayCheat
{
    public static class Tray
    {
        //NotifyIcon 设置托盘相关参数
        private static readonly NotifyIcon _notifyIcon = new NotifyIcon();//托盘
        private static readonly NotifyIcon _notifyIcon1 = new NotifyIcon();//托盘1
        private static readonly NotifyIcon _notifyIcon2 = new NotifyIcon();//托盘2

        //托盘图标的宽高
        private static readonly int _width = 128, _height = 128;

        //保存窗口句柄
        private static IntPtr currentWindowPtr;

        //初始化系统托盘
        public static void InitTray()
        {
            currentWindowPtr = WindowsForm.GetForegroundWindow();//记住当前窗口句柄

            _notifyIcon.Text = "托盘欺诈工具";

            //_notifyIcon1.Icon = new Icon(SystemIcons.Warning, _width, _height);//托盘图标
            _notifyIcon.Icon = CustomTrayIcon(Application.StartupPath + "/icon/tray_tool.ico", _width, _height);

            _notifyIcon.MouseDoubleClick += NotifyIcon_MouseDoubleClick;//双击托盘图标 响应事件

            _notifyIcon.Visible = true;//显示托盘图标
        }
        public static void InitTray_1()
        {
            currentWindowPtr = WindowsForm.GetForegroundWindow();//记住当前窗口句柄

            _notifyIcon1.Text = "这真的是 \"360 安全卫士\" 图标，真的！";

            //_notifyIcon1.Icon = new Icon(SystemIcons.Warning, _width, _height);//托盘图标
            _notifyIcon1.Icon = CustomTrayIcon(Application.StartupPath + "/icon/360.ico", _width, _height);

            //_notifyIcon1.MouseDoubleClick += NotifyIcon_MouseDoubleClick;//双击托盘图标1 响应事件
        }
        public static void InitTray_2()
        {
            currentWindowPtr = WindowsForm.GetForegroundWindow();//记住当前窗口句柄

            _notifyIcon2.Text = "这真的是 \"360 杀毒\" 图标，真的！";

            //_notifyIcon.Icon = new Icon(SystemIcons.Warning, _width, _height);//托盘图标
            _notifyIcon2.Icon = CustomTrayIcon(Application.StartupPath + "/icon/360bug.ico", _width, _height);

            //_notifyIcon2.MouseDoubleClick += NotifyIcon_MouseDoubleClick;//双击托盘图标2 响应事件
        }

        //显示托盘图标
        public static void ShowTray_1()
        {
            _notifyIcon1.Visible = true;//托盘按钮是否可见
        }
        public static void ShowTray_2()
        {
            _notifyIcon2.Visible = true;//托盘按钮是否可见
        }

        //隐藏托盘图标
        public static void HideTray_1()
        {
            _notifyIcon1.Visible = false;//托盘按钮是否可见
        }
        public static void HideTray_2()
        {
            _notifyIcon2.Visible = false;//托盘按钮是否可见
        }

        //设置程序托盘图标
        private static Icon CustomTrayIcon(string iconPath, int width, int height)
        {
            Bitmap bt = new Bitmap(iconPath);
            Bitmap fitSizeBt = new Bitmap(bt, width, height);
            return Icon.FromHandle(fitSizeBt.GetHicon());
        }
        private static Icon CustomTrayIcon(Image img, int width, int height)
        {
            Bitmap bt = new Bitmap(img);
            Bitmap fitSizeBt = new Bitmap(bt, width, height);
            return Icon.FromHandle(fitSizeBt.GetHicon());
        }

        // byte[] 转换成 Image
        public static Image ByteArrayToImage(byte[] byteArrayIn)
        {
            if (byteArrayIn == null)
                return null;
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream(byteArrayIn))
            {
                Image returnImage = Image.FromStream(ms);
                ms.Flush();
                return returnImage;
            }
        }

        //取消双击事件的注册
        public static void DestroyDoubleClick()
        {
            _notifyIcon.MouseDoubleClick -= NotifyIcon_MouseDoubleClick;
        }
        public static void DestroyDoubleClick_1()
        {
            _notifyIcon1.MouseDoubleClick -= NotifyIcon_MouseDoubleClick;
        }
        public static void DestroyDoubleClick_2()
        {
            _notifyIcon2.MouseDoubleClick -= NotifyIcon_MouseDoubleClick;
        }

        //显示 Windows 气泡消息
        public static void ShowBalloonTipText(string str)
        {
            _notifyIcon.BalloonTipText = str;// Windows 消息气泡显示内容
            _notifyIcon.ShowBalloonTip(2);//显示 Windows 消息气泡，并设置显示时间为 2s
        }
        public static void ShowBalloonTipText_1(string str)
        {
            _notifyIcon1.BalloonTipText = str;// Windows 消息气泡显示内容
            _notifyIcon1.ShowBalloonTip(2);//显示 Windows 消息气泡，并设置显示时间为 2s
        }
        public static void ShowBalloonTipText_2(string str)
        {
            _notifyIcon2.BalloonTipText = str;// Windows 消息气泡显示内容
            _notifyIcon2.ShowBalloonTip(2);//显示 Windows 消息气泡，并设置显示时间为 2s
        }

        //双击任意一个托盘图标后，将程序窗口还原
        private static void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                WindowsForm.OnClickRestore(currentWindowPtr);
            }
        }

        //隐藏此工具的任务栏图标
        public static void HideTaskIcon()
        {
            WindowsForm.OnClickHide(currentWindowPtr);
        }
    }
}
