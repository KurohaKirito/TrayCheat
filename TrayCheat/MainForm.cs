using System;
using System.Windows.Forms;

namespace TrayCheat
{
    public partial class TrayCheat : Form
    {
        public TrayCheat()
        {
            InitializeComponent();
        }

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
    }
}


