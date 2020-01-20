using System;
using System.Drawing;
using HZH_Controls.Forms;
using System.Windows.Forms;

namespace TrayCheat
{
    public partial class MainForm : Form
    {
        private static readonly NotifyIcon notifyIcon_360 = new NotifyIcon();//托盘 360
        private static readonly NotifyIcon notifyIcon_360bug = new NotifyIcon();//托盘 360 bug
        private static readonly int icon_width = 128, icon_height = 128;//托盘图标的大小
        private static IntPtr currentWindowPtr;//保存窗口句柄
        private static readonly Icon icon_360 = CustomTrayIcon(Application.StartupPath + "/icon/360.ico", icon_width, icon_height);
        private static readonly Icon icon_360bug = CustomTrayIcon(Application.StartupPath + "/icon/360bug.ico", icon_width, icon_height);

        #region 图标的闪烁效果 以及 图标的旋转效果
        public enum EffectFlickOrSpin { Effect_Flick, Effect_Spin }//枚举: 图标闪烁或者图标旋转
        private static readonly EffectFlickOrSpin currentIconEffect = EffectFlickOrSpin.Effect_Spin;

        public enum IconFlick { Icon_Tray, Icon_Tray_White }//枚举: 控制图标闪烁
        public enum IconSpin { Icon_Tray_000, Icon_Tray_075, Icon_Tray_150, Icon_Tray_225, Icon_Tray_300, Icon_Tray_375 }//枚举: 控制图标旋转

        private static readonly Icon icon_tray = CustomTrayIcon(Application.StartupPath + "/icon/tray.ico", icon_width, icon_height);
        private static readonly Icon icon_tray_white = CustomTrayIcon(Application.StartupPath + "/icon/tray_white.ico", icon_width, icon_height);
        private static IconFlick currentIconFlick = IconFlick.Icon_Tray;

        private static readonly Icon icon_tray_000 = CustomTrayIcon(Application.StartupPath + "/icon/spin/tray_000.ico", icon_width, icon_height);
        private static readonly Icon icon_tray_075 = CustomTrayIcon(Application.StartupPath + "/icon/spin/tray_075.ico", icon_width, icon_height);
        private static readonly Icon icon_tray_150 = CustomTrayIcon(Application.StartupPath + "/icon/spin/tray_150.ico", icon_width, icon_height);
        private static readonly Icon icon_tray_225 = CustomTrayIcon(Application.StartupPath + "/icon/spin/tray_225.ico", icon_width, icon_height);
        private static readonly Icon icon_tray_300 = CustomTrayIcon(Application.StartupPath + "/icon/spin/tray_300.ico", icon_width, icon_height);
        private static readonly Icon icon_tray_375 = CustomTrayIcon(Application.StartupPath + "/icon/spin/tray_375.ico", icon_width, icon_height);
        private static IconSpin currentIconSpin = IconSpin.Icon_Tray_000;
        #endregion

        // 窗体构造函数
        public MainForm()
        {
            InitializeComponent();
        }

        #region 程序初始化

        #region 探索学习过程
        //窗体加载事件, 在窗体加载前触发, 此时窗体尚未加载
        /*private void TrayCheat_Load(object sender, EventArgs e)
        {
            MessageBox.Show("窗体加载中......", "提示");
        }*/

        //窗体激活事件, 每次窗体被激活(选中), 都会触发这个方法
        /*private void TrayCheat_Activated(object sender, EventArgs e)
        {
            MessageBox.Show("窗体被激活", "提示");
        }*/
        #endregion

        //当窗体第一次显示前, 会执行这个方法, 此时窗体已经加载完毕
        private void TrayCheat_Shown(object sender, EventArgs e)
        {
            //MessageBox.Show("这是窗体的第一次显示", "提示");
            currentWindowPtr = WindowsForm.GetForegroundWindow();//获取窗口句柄, 必须在窗口被激活之后执行这句代码

            notifyIcon_360.Text = @"这真的是 '360 安全卫士' 图标，真的！";
            notifyIcon_360.Icon = icon_360;
            notifyIcon_360.MouseDoubleClick += NotifyIcon_TrayCheat_MouseDoubleClick;

            notifyIcon_360bug.Text = @"这真的是 '360 杀毒' 图标，真的！";
            notifyIcon_360bug.Icon = icon_360bug;
            notifyIcon_360bug.MouseDoubleClick += NotifyIcon_TrayCheat_MouseDoubleClick;

            //打开定时器
            Timer_IconFlick.Start();
        }

        #endregion

        #region 按钮按下效果实现

        #region "显示 360 卫士 图标" 按钮外观控制事件
        private void Show360_MouseEnter(object sender, EventArgs e)
        {
            Show360.BackgroundImage = Image.FromFile("sprite/button/Button Red A.png");
        }

        private void Show360_MouseDown(object sender, MouseEventArgs e)
        {
            Show360.BackgroundImage = Image.FromFile("sprite/button/Button Blue A.png");
        }

        private void Show360_MouseUp(object sender, MouseEventArgs e)
        {
            Show360.BackgroundImage = Image.FromFile("sprite/button/Button Red A.png");
        }

        private void Show360_MouseLeave(object sender, EventArgs e)
        {
            Show360.BackgroundImage = Image.FromFile("sprite/button/Button Blue A.png");
        }
        #endregion
        #region "隐藏 360 卫士 图标" 按钮外观控制事件
        private void Hide360_MouseEnter(object sender, EventArgs e)
        {
            Hide360.BackgroundImage = Image.FromFile("sprite/button/Button Red A.png");
        }

        private void Hide360_MouseDown(object sender, MouseEventArgs e)
        {
            Hide360.BackgroundImage = Image.FromFile("sprite/button/Button Blue A.png");
        }

        private void Hide360_MouseUp(object sender, MouseEventArgs e)
        {
            Hide360.BackgroundImage = Image.FromFile("sprite/button/Button Red A.png");
        }

        private void Hide360_MouseLeave(object sender, EventArgs e)
        {
            Hide360.BackgroundImage = Image.FromFile("sprite/button/Button Blue A.png");
        }
        #endregion

        #region "显示 360 杀毒 图标" 按钮外观控制事件
        private void Show360bug_MouseEnter(object sender, EventArgs e)
        {
            Show360bug.BackgroundImage = Image.FromFile("sprite/button/Button Red A.png");
        }

        private void Show360bug_MouseDown(object sender, MouseEventArgs e)
        {
            Show360bug.BackgroundImage = Image.FromFile("sprite/button/Button Blue A.png");
        }

        private void Show360bug_MouseUp(object sender, MouseEventArgs e)
        {
            Show360bug.BackgroundImage = Image.FromFile("sprite/button/Button Red A.png");
        }

        private void Show360bug_MouseLeave(object sender, EventArgs e)
        {
            Show360bug.BackgroundImage = Image.FromFile("sprite/button/Button Blue A.png");
        }
        #endregion
        #region "隐藏 360 杀毒 图标" 按钮外观控制事件
        private void Hide360bug_MouseEnter(object sender, EventArgs e)
        {
            Hide360bug.BackgroundImage = Image.FromFile("sprite/button/Button Red A.png");
        }

        private void Hide360bug_MouseDown(object sender, MouseEventArgs e)
        {
            Hide360bug.BackgroundImage = Image.FromFile("sprite/button/Button Blue A.png");
        }

        private void Hide360bug_MouseUp(object sender, MouseEventArgs e)
        {
            Hide360bug.BackgroundImage = Image.FromFile("sprite/button/Button Red A.png");
        }

        private void Hide360bug_MouseLeave(object sender, EventArgs e)
        {
            Hide360bug.BackgroundImage = Image.FromFile("sprite/button/Button Blue A.png");
        }
        #endregion

        #region "显示 Tray Cheat 图标" 按钮外观控制事件
        private void ShowTrayCheat_MouseEnter(object sender, EventArgs e)
        {
            ShowTrayCheat.BackgroundImage = Image.FromFile("sprite/button/Button Red A.png");
        }

        private void ShowTrayCheat_MouseDown(object sender, MouseEventArgs e)
        {
            ShowTrayCheat.BackgroundImage = Image.FromFile("sprite/button/Button Blue A.png");
        }

        private void ShowTrayCheat_MouseUp(object sender, MouseEventArgs e)
        {
            ShowTrayCheat.BackgroundImage = Image.FromFile("sprite/button/Button Red A.png");
        }

        private void ShowTrayCheat_MouseLeave(object sender, EventArgs e)
        {
            ShowTrayCheat.BackgroundImage = Image.FromFile("sprite/button/Button Blue A.png");
        }
        #endregion
        #region "隐藏 Tray Cheat 图标" 按钮外观控制事件
        private void HideTrayCheat_MouseEnter(object sender, EventArgs e)
        {
            HideTrayCheat.BackgroundImage = Image.FromFile("sprite/button/Button Red A.png");
        }
        private void HideTrayCheat_MouseDown(object sender, MouseEventArgs e)
        {
            HideTrayCheat.BackgroundImage = Image.FromFile("sprite/button/Button Blue A.png");
        }

        private void HideTrayCheat_MouseUp(object sender, MouseEventArgs e)
        {
            HideTrayCheat.BackgroundImage = Image.FromFile("sprite/button/Button Red A.png");
        }

        private void HideTrayCheat_MouseLeave(object sender, EventArgs e)
        {
            HideTrayCheat.BackgroundImage = Image.FromFile("sprite/button/Button Blue A.png");
        }
        #endregion

        #region "隐藏窗口" 按钮外观控制事件
        private void HideWindow_MouseEnter(object sender, EventArgs e)
        {
            HideWindow.BackgroundImage = Image.FromFile("sprite/button/Button Red A.png");
        }
        private void HideWindow_MouseLeave(object sender, EventArgs e)
        {
            HideWindow.BackgroundImage = Image.FromFile("sprite/button/Button Blue A.png");
        }
        private void HideWindow_MouseDown(object sender, MouseEventArgs e)
        {
            HideWindow.BackgroundImage = Image.FromFile("sprite/button/Button Blue A.png");
        }
        private void HideWindow_MouseUp(object sender, MouseEventArgs e)
        {
            HideWindow.BackgroundImage = Image.FromFile("sprite/button/Button Red A.png");
        }
        #endregion

        #region "退出程序" 按钮外观控制事件
        private void QuitWindow_MouseEnter(object sender, EventArgs e)
        {
            QuitWindow.BackgroundImage = Image.FromFile("sprite/button/Button Red A.png");
        }
        private void QuitWindow_MouseLeave(object sender, EventArgs e)
        {
            QuitWindow.BackgroundImage = Image.FromFile("sprite/button/Button Blue A.png");
        }
        private void QuitWindow_MouseDown(object sender, MouseEventArgs e)
        {
            QuitWindow.BackgroundImage = Image.FromFile("sprite/button/Button Blue A.png");
        }
        private void QuitWindow_MouseUp(object sender, MouseEventArgs e)
        {
            QuitWindow.BackgroundImage = Image.FromFile("sprite/button/Button Red A.png");
        }
        #endregion

        #endregion

        #region 程序主界面中的按钮事件
        //显示 360 图标
        private void Show360_Click(object sender, EventArgs e)
        {
            notifyIcon_360.Visible = true;
        }
        //隐藏 360 图标
        private void Hide360_Click(object sender, EventArgs e)
        {
            if (notifyIcon_360.Visible == true)
            {
                ShowBalloonTipText("360 已隐藏!");
                notifyIcon_360.Visible = false;
            }
        }

        //显示 360 杀毒 图标
        private void Show360bug_Click(object sender, EventArgs e)
        {
            notifyIcon_360bug.Visible = true;
        }
        //隐藏 360 杀毒 图标
        private void Hide360bug_Click(object sender, EventArgs e)
        {
            if (notifyIcon_360bug.Visible == true)
            {
                ShowBalloonTipText("360 杀毒 已隐藏!");
                notifyIcon_360bug.Visible = false;
            }
        }

        //显示 Tray Cheat 图标
        private void ShowTrayCheat_Click(object sender, EventArgs e)
        {
            NotifyIcon_TrayCheat.Visible = true;
        }
        //隐藏 Tray Cheat 图标
        private void HideTrayCheat_Click(object sender, EventArgs e)
        {
            if (NotifyIcon_TrayCheat.Visible == true)
            {
                ShowBalloonTipText("Tray Cheat 已隐藏!");
                NotifyIcon_TrayCheat.Visible = false;
            }
        }

        //隐藏窗口 按钮
        private void HideWindow_Click(object sender, EventArgs e)
        {
            if (notifyIcon_360.Visible == true ||
                notifyIcon_360bug.Visible == true ||
                NotifyIcon_TrayCheat.Visible == true)
            {
                WindowsForm.OnClickHide(currentWindowPtr);
            }
        }

        //退出程序 按钮
        private void QuitWindow_Click(object sender, EventArgs e)
        {
            ApplicationQuit();
        }
        #endregion

        #region 主程序的右上角 "最小化" "最大化" "关闭" 按钮的事件
        private void MainForm_Closed(object sender, FormClosedEventArgs e)
        {
            ApplicationQuit();
        }
        #endregion

        #region 托盘栏事件
        //事件: 双击托盘栏图标, 还原窗口
        private void NotifyIcon_TrayCheat_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                WindowsForm.OnClickRestore(currentWindowPtr);
            }
        }
        #endregion

        #region 托盘栏右键菜单事件
        //还原窗口
        private void ToolStripMenu_Restore_Click(object sender, EventArgs e)
        {
            WindowsForm.OnClickRestore(currentWindowPtr);
        }
        //隐藏窗口
        private void ToolStripMenu_Hide_Click(object sender, EventArgs e)
        {
            //如果图标都不存在了, 则不能隐藏窗口
            if (notifyIcon_360.Visible == true ||
                notifyIcon_360bug.Visible == true ||
                NotifyIcon_TrayCheat.Visible == true)
            {
                WindowsForm.OnClickHide(currentWindowPtr);
            }
        }
        //退出程序
        private void ToolStripMenu_Quit_Click(object sender, EventArgs e)
        {
            ApplicationQuit();
        }
        #endregion

        #region 将图片文件转换为图标文件
        private static Icon CustomTrayIcon(string iconPath, int width, int height)
        {
            Bitmap bt = new Bitmap(iconPath);

            //当 using 代码块执行完之后, 会自动将 () 中的资源 Dispose (释放) 掉. 
            using (Bitmap fitSizeBt = new Bitmap(bt, width, height))
            {
                return Icon.FromHandle(fitSizeBt.GetHicon());
            }
        }
        /*
        private static Icon CustomTrayIcon(Image img, int width, int height)
        {
            Bitmap bt = new Bitmap(img);
            Bitmap fitSizeBt = new Bitmap(bt, width, height);
            return Icon.FromHandle(fitSizeBt.GetHicon());
        }*/
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

        #region 显示 Windows 气泡消息
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
        #endregion

        #region 退出程序
        private void ApplicationQuit()
        {
            //退出前把所有的图标显示关闭
            notifyIcon_360.Visible = false;
            notifyIcon_360bug.Visible = false;
            NotifyIcon_TrayCheat.Visible = false;

            //关闭定时器
            Timer_IconFlick.Stop();

            Dispose(true);//释放资源
            Application.Exit();//退出程序
        }
        #endregion

        //特效定时器
        private void Timer_IconFlick_Tick(object sender, EventArgs e)
        {
            switch (currentIconEffect)
            {
                case EffectFlickOrSpin.Effect_Flick:
                    #region 闪烁效果
                    if (icon_tray != null && icon_tray_white != null)//判断图标是否已经赋值
                    {
                        switch (currentIconFlick)
                        {
                            case IconFlick.Icon_Tray:
                                NotifyIcon_TrayCheat.Icon = icon_tray_white;
                                currentIconFlick = IconFlick.Icon_Tray_White;
                                break;
                            case IconFlick.Icon_Tray_White:
                                NotifyIcon_TrayCheat.Icon = icon_tray;
                                currentIconFlick = IconFlick.Icon_Tray;
                                break;
                            default:
                                break;
                        }
                    }
                    #endregion
                    break;
                case EffectFlickOrSpin.Effect_Spin:
                    #region 旋转效果
                    if (icon_tray_000 != null && icon_tray_075 != null && icon_tray_150 != null &&
                        icon_tray_225 != null && icon_tray_300 != null && icon_tray_375 != null)//判断图标是否已经赋值
                    {
                        switch (currentIconSpin)
                        {
                            case IconSpin.Icon_Tray_000:
                                NotifyIcon_TrayCheat.Icon = icon_tray_075;
                                currentIconSpin = IconSpin.Icon_Tray_075;
                                break;
                            case IconSpin.Icon_Tray_075:
                                NotifyIcon_TrayCheat.Icon = icon_tray_150;
                                currentIconSpin = IconSpin.Icon_Tray_150;
                                break;
                            case IconSpin.Icon_Tray_150:
                                NotifyIcon_TrayCheat.Icon = icon_tray_225;
                                currentIconSpin = IconSpin.Icon_Tray_225;
                                break;
                            case IconSpin.Icon_Tray_225:
                                NotifyIcon_TrayCheat.Icon = icon_tray_300;
                                currentIconSpin = IconSpin.Icon_Tray_300;
                                break;
                            case IconSpin.Icon_Tray_300:
                                NotifyIcon_TrayCheat.Icon = icon_tray_375;
                                currentIconSpin = IconSpin.Icon_Tray_375;
                                break;
                            case IconSpin.Icon_Tray_375:
                                NotifyIcon_TrayCheat.Icon = icon_tray_000;
                                currentIconSpin = IconSpin.Icon_Tray_000;
                                break;
                            default:
                                break;
                        }
                    }
                    #endregion
                    break;
                default:
                    break;
            }
        }
    }
}


