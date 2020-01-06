using System;
using System.Drawing;
using System.Windows.Forms;
using HZH_Controls.Forms;

namespace TrayCheat
{
    public static class Tray
    {
        //NotifyIcon 设置托盘相关参数
        private static readonly NotifyIcon notifyIcon = new NotifyIcon();//托盘
        private static readonly NotifyIcon notifyIcon_360 = new NotifyIcon();//托盘1
        private static readonly NotifyIcon notifyIcon_360bug = new NotifyIcon();//托盘2

        //托盘图标的大小
        private static readonly int _width = 128, _height = 128;

        //保存窗口句柄
        private static IntPtr currentWindowPtr;

        #region 初始化托盘图标
        public static void InitTray()
        {
            currentWindowPtr = WindowsForm.GetForegroundWindow();//记住当前窗口句柄
            notifyIcon.Text = @"托盘欺诈工具";
            //notifyIcon.Icon = new Icon(SystemIcons.Warning, _width, _height);//系统图标
            notifyIcon.Icon = CustomTrayIcon(Application.StartupPath + "/icon/tray_tool.ico", _width, _height);//自定义图标
            notifyIcon.MouseDoubleClick += NotifyIcon_MouseDoubleClick;//双击托盘图标 响应事件
        }
        public static void InitTray_360()
        {
            currentWindowPtr = WindowsForm.GetForegroundWindow();//记住当前窗口句柄
            notifyIcon_360.Text = @"这真的是 '360 安全卫士' 图标，真的！";
            notifyIcon_360.Icon = CustomTrayIcon(Application.StartupPath + "/icon/360.ico", _width, _height);
            notifyIcon_360.MouseDoubleClick += NotifyIcon_MouseDoubleClick;//双击托盘图标1 响应事件
        }
        public static void InitTray_360bug()
        {
            currentWindowPtr = WindowsForm.GetForegroundWindow();//记住当前窗口句柄
            notifyIcon_360bug.Text = @"这真的是 '360 杀毒' 图标，真的！";
            notifyIcon_360bug.Icon = CustomTrayIcon(Application.StartupPath + "/icon/360bug.ico", _width, _height);
            notifyIcon_360bug.MouseDoubleClick += NotifyIcon_MouseDoubleClick;//双击托盘图标2 响应事件
        }
        #endregion

        #region 显示托盘图标
        public static void ShowTray()
        {
            notifyIcon.Visible = true;//托盘按钮是否可见
        }
        public static void ShowTray_360()
        {
            notifyIcon_360.Visible = true;
        }
        public static void ShowTray_360bug()
        {
            notifyIcon_360bug.Visible = true;
        }
        #endregion

        #region 隐藏托盘图标
        public static void HideTray()
        {
            notifyIcon.Visible = false;//隐藏任务栏图标
        }
        public static void HideTray_360()
        {
            notifyIcon_360.Visible = false;
        }
        public static void HideTray_360bug()
        {
            notifyIcon_360bug.Visible = false;
        }
        #endregion

        #region 设置程序托盘图标
        private static Icon CustomTrayIcon(string iconPath, int width, int height)
        {
            Bitmap bt = new Bitmap(iconPath);
            Bitmap fitSizeBt = new Bitmap(bt, width, height);
            return Icon.FromHandle(fitSizeBt.GetHicon());
        }
        //private static Icon CustomTrayIcon(Image img, int width, int height)
        //{
        //    Bitmap bt = new Bitmap(img);
        //    Bitmap fitSizeBt = new Bitmap(bt, width, height);
        //    return Icon.FromHandle(fitSizeBt.GetHicon());
        //}
        public static Image ByteArrayToImage(byte[] byteArrayIn)// 将 byte[] 转换成 Image
        {
            if (byteArrayIn == null)
            {
                return null;
            }

            using (System.IO.MemoryStream ms = new System.IO.MemoryStream(byteArrayIn))
            {
                Image returnImage = Image.FromStream(ms);
                ms.Flush();
                return returnImage;
            }
        }
        #endregion

        #region 取消双击事件的注册
        public static void DestroyDoubleClick()
        {
            notifyIcon.MouseDoubleClick -= NotifyIcon_MouseDoubleClick;
        }
        public static void DestroyDoubleClick_360()
        {
            notifyIcon_360.MouseDoubleClick -= NotifyIcon_MouseDoubleClick;
        }
        public static void DestroyDoubleClick_360bug()
        {
            notifyIcon_360bug.MouseDoubleClick -= NotifyIcon_MouseDoubleClick;
        }
        #endregion

        //显示 Windows 气泡消息
        public static void ShowBalloonTipText(string str)
        {
            //使用 HZHControls 插件弹出气泡
            FrmTips.ShowTips(Form.ActiveForm, str, 4000, true, ContentAlignment.BottomRight, null, TipsSizeMode.Medium, null, TipsState.Success);

            // Windows 自带的消息气泡显示方法一
            //notifyIcon_360.BalloonTipText = str;
            //notifyIcon_360.ShowBalloonTip(2000);

            // Windows 自带的消息气泡显示方法二
            //notifyIcon_360bug.ShowBalloonTip(2000, "提示", str, ToolTipIcon.Info);
        }

        //事件: 双击任意一个托盘图标后，将程序窗口还原
        private static void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                WindowsForm.OnClickRestore(currentWindowPtr);
            }
        }
    }
}
