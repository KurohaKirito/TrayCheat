using System;
using System.Drawing;
using System.Windows.Forms;

namespace TrayCheat
{
    public partial class TrayCheat : Form
    {
        public TrayCheat()
        {
            InitializeComponent();
        }
        #region "初始化 360 卫士 图标" 按钮外观控制事件
        private void Init360_MouseEnter(object sender, EventArgs e)
        {
            Init360.BackgroundImage = Image.FromFile("sprite/button/Button Red A.png");
        }

        private void Init360_MouseDown(object sender, MouseEventArgs e)
        {
            Init360.BackgroundImage = Image.FromFile("sprite/button/Button Blue A.png");
        }

        private void Init360_MouseUp(object sender, MouseEventArgs e)
        {
            Init360.BackgroundImage = Image.FromFile("sprite/button/Button Red A.png");
        }

        private void Init360_MouseLeave(object sender, EventArgs e)
        {
            Init360.BackgroundImage = Image.FromFile("sprite/button/Button Blue A.png");
        }
        #endregion

        #region "初始化 360 杀毒 图标" 按钮外观控制事件
        private void Init360bug_MouseEnter(object sender, EventArgs e)
        {
            Init360bug.BackgroundImage = Image.FromFile("sprite/button/Button Red A.png");
        }

        private void Init360bug_MouseDown(object sender, MouseEventArgs e)
        {
            Init360bug.BackgroundImage = Image.FromFile("sprite/button/Button Blue A.png");
        }

        private void Init360bug_MouseUp(object sender, MouseEventArgs e)
        {
            Init360bug.BackgroundImage = Image.FromFile("sprite/button/Button Red A.png");
        }

        private void Init360bug_MouseLeave(object sender, EventArgs e)
        {
            Init360bug.BackgroundImage = Image.FromFile("sprite/button/Button Blue A.png");
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

        #region "初始化 Tray Cheat 图标" 按钮外观控制事件
        private void InitTrayCheat_MouseEnter(object sender, EventArgs e)
        {
            InitTrayCheat.BackgroundImage = Image.FromFile("sprite/button/Button Red A.png");
        }

        private void InitTrayCheat_MouseDown(object sender, MouseEventArgs e)
        {
            InitTrayCheat.BackgroundImage = Image.FromFile("sprite/button/Button Blue A.png");
        }

        private void InitTrayCheat_MouseUp(object sender, MouseEventArgs e)
        {
            InitTrayCheat.BackgroundImage = Image.FromFile("sprite/button/Button Red A.png");
        }

        private void InitTrayCheat_MouseLeave(object sender, EventArgs e)
        {
            InitTrayCheat.BackgroundImage = Image.FromFile("sprite/button/Button Blue A.png");
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

        //初始化 360 图标
        private void Init360_Click(object sender, EventArgs e)
        {
            Tray.InitTray_360();
        }

        //显示 360 图标
        private void Show360_Click(object sender, EventArgs e)
        {
            Tray.ShowTray_360();
        }

        //隐藏 360 图标
        private void Hide360_Click(object sender, EventArgs e)
        {
            Tray.ShowBalloonTipText("360 已隐藏!");
            Tray.HideTray_360();
        }

        //初始化 360 杀毒 图标
        private void Init360bug_Click(object sender, EventArgs e)
        {
            Tray.InitTray_360bug();
        }

        //显示 360 杀毒 图标
        private void Show360bug_Click(object sender, EventArgs e)
        {
            Tray.ShowTray_360bug();
        }

        //隐藏 360 杀毒 图标
        private void Hide360bug_Click(object sender, EventArgs e)
        {
            Tray.ShowBalloonTipText("360 杀毒 已隐藏!");
            Tray.HideTray_360bug();
        }

        //初始化 Tray Cheat 图标
        private void InitTrayCheat_Click(object sender, EventArgs e)
        {
            Tray.InitTray();
        }

        //显示 Tray Cheat 图标
        private void ShowTrayCheat_Click(object sender, EventArgs e)
        {
            Tray.ShowTray();
        }

        //隐藏 Tray Cheat 图标
        private void HideTrayCheat_Click(object sender, EventArgs e)
        {
            Tray.ShowBalloonTipText("Tray Cheat 已隐藏!");
            Tray.HideTray();
        }

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





        //隐藏窗口
        //WindowsForm.OnClickHide(currentWindowPtr);//隐藏窗口
    }
}


