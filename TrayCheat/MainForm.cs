using System;
using System.Drawing;
using HZH_Controls.Forms;
using System.Windows.Forms;

namespace TrayCheat
{
    public partial class MainForm : Form
    {
        private static readonly NotifyIcon notifyIcon_360 = new NotifyIcon();//托盘 360 safe
        private static readonly NotifyIcon notifyIcon_360bug = new NotifyIcon();//托盘 360 bug
        
        private static IntPtr currentWindowPtr;//保存窗口句柄
        private static readonly Icon icon_360 = new Icon(Application.StartupPath + "/icon/360.ico", SystemInformation.SmallIconSize);
        private static readonly Icon icon_360bug = new Icon(Application.StartupPath + "/icon/360bug.ico", SystemInformation.SmallIconSize);

        #region 存在 bug 的旧方法不再使用
        //下面自定义图标文件的方法会导致图标模糊, 不再使用
        //private const int icon_width = 16, icon_height = 16;//托盘图标的大小
        //private static readonly Icon icon_360 = CustomTrayIcon(Application.StartupPath + "/icon/360.ico", icon_width, icon_height);
        //private static readonly Icon icon_360bug = CustomTrayIcon(Application.StartupPath + "/icon/360bug.ico", icon_width, icon_height);
        #endregion

        #region 图标的闪烁效果 以及 图标的旋转效果
        public enum EffectFlickOrSpin { Effect_Spin, Effect_Flick, Effect_Still }//枚举: 旋转 闪烁 静止
        private static EffectFlickOrSpin currentIconEffect = EffectFlickOrSpin.Effect_Spin;//默认是旋转

        public enum IconFlick { Icon_Tray, Icon_Tray_White }//枚举: 控制图标闪烁
        private static IconFlick currentIconFlick = IconFlick.Icon_Tray_White;//标志当前的闪烁状态, 默认为: 透明
        private static readonly Icon icon_tray = new Icon(Application.StartupPath + "/icon/tray.ico", SystemInformation.SmallIconSize);
        private static readonly Icon icon_tray_white = new Icon(Application.StartupPath + "/icon/tray_white.ico", SystemInformation.SmallIconSize);
        
        public enum IconSpin { Icon_Tray_000, Icon_Tray_075, Icon_Tray_150, Icon_Tray_225, Icon_Tray_300, Icon_Tray_375 }//枚举: 控制图标旋转
        private static IconSpin currentIconSpin = IconSpin.Icon_Tray_000;//标志当前的旋转状态, 默认为: 未旋转
        private static readonly Icon icon_tray_000 = new Icon(Application.StartupPath + "/icon/spin/tray_000.ico", SystemInformation.SmallIconSize);
        private static readonly Icon icon_tray_075 = new Icon(Application.StartupPath + "/icon/spin/tray_075.ico", SystemInformation.SmallIconSize);
        private static readonly Icon icon_tray_150 = new Icon(Application.StartupPath + "/icon/spin/tray_150.ico", SystemInformation.SmallIconSize);
        private static readonly Icon icon_tray_225 = new Icon(Application.StartupPath + "/icon/spin/tray_225.ico", SystemInformation.SmallIconSize);
        private static readonly Icon icon_tray_300 = new Icon(Application.StartupPath + "/icon/spin/tray_300.ico", SystemInformation.SmallIconSize);
        private static readonly Icon icon_tray_375 = new Icon(Application.StartupPath + "/icon/spin/tray_375.ico", SystemInformation.SmallIconSize);
        
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
            currentWindowPtr = WindowsForm.MyGetForegroundWindow();//获取窗口句柄, 必须在窗口被激活之后执行这句代码

            notifyIcon_360.Text = @"360安全卫士 - 安全防护中心完全开启";
            notifyIcon_360.Icon = icon_360;
            notifyIcon_360.MouseDoubleClick += NotifyIcon_TrayCheat_MouseDoubleClick;

            notifyIcon_360bug.Text = @"360杀毒 - 文件系统实时防护已开启";
            notifyIcon_360bug.Icon = icon_360bug;
            notifyIcon_360bug.MouseDoubleClick += NotifyIcon_TrayCheat_MouseDoubleClick;

            //打开定时器
            Timer_IconEffect.Start();

            //修改按钮文本显示
            switch (currentIconEffect)
            {
                case EffectFlickOrSpin.Effect_Spin:
                    ICONEffect.Text = "当前图标效果: 旋转";
                    break;
                case EffectFlickOrSpin.Effect_Flick:
                    ICONEffect.Text = "当前图标效果: 闪烁";
                    break;
                case EffectFlickOrSpin.Effect_Still:
                    ICONEffect.Text = "当前图标效果: 无";
                    break;
                default:
                    break;
            }
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

        #region "特效控制" 按钮外观控制事件
        private void ICONEffect_MouseEnter(object sender, EventArgs e)
        {
            ICONEffect.BackgroundImage = Image.FromFile("sprite/button/Button Red A.png");
        }
        private void ICONEffect_MouseLeave(object sender, EventArgs e)
        {
            ICONEffect.BackgroundImage = Image.FromFile("sprite/button/Button Blue A.png");
        }
        private void ICONEffect_MouseDown(object sender, MouseEventArgs e)
        {
            ICONEffect.BackgroundImage = Image.FromFile("sprite/button/Button Blue A.png");
        }
        private void ICONEffect_MouseUp(object sender, MouseEventArgs e)
        {
            ICONEffect.BackgroundImage = Image.FromFile("sprite/button/Button Red A.png");
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
                ShowBalloonTipText("360 安全卫士图标 已隐藏!");
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
                ShowBalloonTipText("360 杀毒图标 已隐藏!");
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
                ShowBalloonTipText("Tray Cheat 图标 已隐藏!");
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

        #region 存在 bug 的旧方法不再使用
        //下面自定义图标文件的方法会导致图标模糊, 不再使用
        /*private static Icon CustomTrayIcon(string iconPath, int width, int height)
        {
            Bitmap bt = new Bitmap(iconPath);

            //当 using 代码块执行完之后, 会自动将 () 中的资源 Dispose (释放) 掉. 
            using (Bitmap fitSizeBt = new Bitmap(bt, width, height))
            {
                return Icon.FromHandle(fitSizeBt.GetHicon());
            }
        }
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
            Timer_IconEffect.Stop();

            Dispose(true);//释放资源
            Application.Exit();//退出程序
        }
        #endregion

        //特效控制器
        private void ICONEffect_Click(object sender, EventArgs e)
        {
            switch (currentIconEffect)//判断当前效果
            {
                case EffectFlickOrSpin.Effect_Spin:
                    currentIconEffect = EffectFlickOrSpin.Effect_Flick;//旋转切换为闪烁
                    ICONEffect.Text = "当前图标效果: 闪烁";//修改按钮文本显示
                    Timer_IconEffect.Stop();//停止计时器
                    Timer_IconEffect.Interval = 300;//设置定时器时间间隔
                    Timer_IconEffect.Start();//开启计时器
                    break;
                case EffectFlickOrSpin.Effect_Flick:
                    currentIconEffect = EffectFlickOrSpin.Effect_Still;//闪烁切换为静止
                    ICONEffect.Text = "当前图标效果: 无";//修改按钮文本显示
                    break;
                case EffectFlickOrSpin.Effect_Still:
                    currentIconEffect = EffectFlickOrSpin.Effect_Spin;//静止切换为旋转
                    ICONEffect.Text = "当前图标效果: 旋转";//修改按钮文本显示
                    Timer_IconEffect.Stop();//停止计时器
                    Timer_IconEffect.Interval = 50;//设置定时器时间间隔
                    Timer_IconEffect.Start();//开启计时器
                    break;
                default:
                    break;
            }
        }

        //特效生成器
        private void Timer_IconEffect_Tick(object sender, EventArgs e)
        {
            switch (currentIconEffect)
            {
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
                case EffectFlickOrSpin.Effect_Still:
                    #region 无效果
                    if (icon_tray != null)//判断图标是否已经赋值
                    {
                        NotifyIcon_TrayCheat.Icon = icon_tray;
                    }
                    #endregion
                    break;
                default:
                    break;
            }
        }
    }
}


