namespace TrayCheat
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Show360 = new System.Windows.Forms.Button();
            this.Show360bug = new System.Windows.Forms.Button();
            this.Hide360 = new System.Windows.Forms.Button();
            this.Hide360bug = new System.Windows.Forms.Button();
            this.ShowTrayCheat = new System.Windows.Forms.Button();
            this.HideTrayCheat = new System.Windows.Forms.Button();
            this.NotifyIcon_TrayCheat = new System.Windows.Forms.NotifyIcon(this.components);
            this.ContextMenuStrip_TrayCheat = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenu_Restore = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenu_Hide = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenu_Quit = new System.Windows.Forms.ToolStripMenuItem();
            this.HideWindow = new System.Windows.Forms.Button();
            this.QuitWindow = new System.Windows.Forms.Button();
            this.Timer_IconEffect = new System.Windows.Forms.Timer(this.components);
            this.ICONEffect = new System.Windows.Forms.Button();
            this.ContextMenuStrip_TrayCheat.SuspendLayout();
            this.SuspendLayout();
            // 
            // Show360
            // 
            this.Show360.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Show360.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Show360.BackgroundImage")));
            this.Show360.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Show360.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Show360.FlatAppearance.BorderSize = 0;
            this.Show360.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.Show360.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Show360.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Show360.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Show360.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show360.Location = new System.Drawing.Point(50, 50);
            this.Show360.Name = "Show360";
            this.Show360.Size = new System.Drawing.Size(150, 50);
            this.Show360.TabIndex = 1;
            this.Show360.Text = "显示 360 卫士图标";
            this.Show360.UseVisualStyleBackColor = false;
            this.Show360.Click += new System.EventHandler(this.Show360_Click);
            this.Show360.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Show360_MouseDown);
            this.Show360.MouseEnter += new System.EventHandler(this.Show360_MouseEnter);
            this.Show360.MouseLeave += new System.EventHandler(this.Show360_MouseLeave);
            this.Show360.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Show360_MouseUp);
            // 
            // Show360bug
            // 
            this.Show360bug.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Show360bug.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Show360bug.BackgroundImage")));
            this.Show360bug.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Show360bug.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Show360bug.FlatAppearance.BorderSize = 0;
            this.Show360bug.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.Show360bug.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Show360bug.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Show360bug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Show360bug.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show360bug.Location = new System.Drawing.Point(250, 50);
            this.Show360bug.Name = "Show360bug";
            this.Show360bug.Size = new System.Drawing.Size(150, 50);
            this.Show360bug.TabIndex = 3;
            this.Show360bug.Text = "显示 360 杀毒图标";
            this.Show360bug.UseVisualStyleBackColor = false;
            this.Show360bug.Click += new System.EventHandler(this.Show360bug_Click);
            this.Show360bug.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Show360bug_MouseDown);
            this.Show360bug.MouseEnter += new System.EventHandler(this.Show360bug_MouseEnter);
            this.Show360bug.MouseLeave += new System.EventHandler(this.Show360bug_MouseLeave);
            this.Show360bug.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Show360bug_MouseUp);
            // 
            // Hide360
            // 
            this.Hide360.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Hide360.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Hide360.BackgroundImage")));
            this.Hide360.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Hide360.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Hide360.FlatAppearance.BorderSize = 0;
            this.Hide360.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.Hide360.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Hide360.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Hide360.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Hide360.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hide360.Location = new System.Drawing.Point(50, 150);
            this.Hide360.Name = "Hide360";
            this.Hide360.Size = new System.Drawing.Size(150, 50);
            this.Hide360.TabIndex = 4;
            this.Hide360.Text = "隐藏 360 卫士图标";
            this.Hide360.UseVisualStyleBackColor = false;
            this.Hide360.Click += new System.EventHandler(this.Hide360_Click);
            this.Hide360.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Hide360_MouseDown);
            this.Hide360.MouseEnter += new System.EventHandler(this.Hide360_MouseEnter);
            this.Hide360.MouseLeave += new System.EventHandler(this.Hide360_MouseLeave);
            this.Hide360.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Hide360_MouseUp);
            // 
            // Hide360bug
            // 
            this.Hide360bug.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Hide360bug.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Hide360bug.BackgroundImage")));
            this.Hide360bug.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Hide360bug.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Hide360bug.FlatAppearance.BorderSize = 0;
            this.Hide360bug.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.Hide360bug.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Hide360bug.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Hide360bug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Hide360bug.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hide360bug.Location = new System.Drawing.Point(250, 150);
            this.Hide360bug.Name = "Hide360bug";
            this.Hide360bug.Size = new System.Drawing.Size(150, 50);
            this.Hide360bug.TabIndex = 5;
            this.Hide360bug.Text = "隐藏 360 杀毒图标";
            this.Hide360bug.UseVisualStyleBackColor = false;
            this.Hide360bug.Click += new System.EventHandler(this.Hide360bug_Click);
            this.Hide360bug.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Hide360bug_MouseDown);
            this.Hide360bug.MouseEnter += new System.EventHandler(this.Hide360bug_MouseEnter);
            this.Hide360bug.MouseLeave += new System.EventHandler(this.Hide360bug_MouseLeave);
            this.Hide360bug.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Hide360bug_MouseUp);
            // 
            // ShowTrayCheat
            // 
            this.ShowTrayCheat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ShowTrayCheat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ShowTrayCheat.BackgroundImage")));
            this.ShowTrayCheat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ShowTrayCheat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ShowTrayCheat.FlatAppearance.BorderSize = 0;
            this.ShowTrayCheat.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.ShowTrayCheat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ShowTrayCheat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ShowTrayCheat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowTrayCheat.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowTrayCheat.Location = new System.Drawing.Point(450, 50);
            this.ShowTrayCheat.Name = "ShowTrayCheat";
            this.ShowTrayCheat.Size = new System.Drawing.Size(150, 50);
            this.ShowTrayCheat.TabIndex = 7;
            this.ShowTrayCheat.Text = "显示 Tray Cheat 图标";
            this.ShowTrayCheat.UseVisualStyleBackColor = false;
            this.ShowTrayCheat.Click += new System.EventHandler(this.ShowTrayCheat_Click);
            this.ShowTrayCheat.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ShowTrayCheat_MouseDown);
            this.ShowTrayCheat.MouseEnter += new System.EventHandler(this.ShowTrayCheat_MouseEnter);
            this.ShowTrayCheat.MouseLeave += new System.EventHandler(this.ShowTrayCheat_MouseLeave);
            this.ShowTrayCheat.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ShowTrayCheat_MouseUp);
            // 
            // HideTrayCheat
            // 
            this.HideTrayCheat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.HideTrayCheat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HideTrayCheat.BackgroundImage")));
            this.HideTrayCheat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HideTrayCheat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.HideTrayCheat.FlatAppearance.BorderSize = 0;
            this.HideTrayCheat.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.HideTrayCheat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.HideTrayCheat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.HideTrayCheat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HideTrayCheat.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HideTrayCheat.Location = new System.Drawing.Point(450, 150);
            this.HideTrayCheat.Name = "HideTrayCheat";
            this.HideTrayCheat.Size = new System.Drawing.Size(150, 50);
            this.HideTrayCheat.TabIndex = 8;
            this.HideTrayCheat.Text = "隐藏 Tray Cheat 图标";
            this.HideTrayCheat.UseVisualStyleBackColor = false;
            this.HideTrayCheat.Click += new System.EventHandler(this.HideTrayCheat_Click);
            this.HideTrayCheat.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HideTrayCheat_MouseDown);
            this.HideTrayCheat.MouseEnter += new System.EventHandler(this.HideTrayCheat_MouseEnter);
            this.HideTrayCheat.MouseLeave += new System.EventHandler(this.HideTrayCheat_MouseLeave);
            this.HideTrayCheat.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HideTrayCheat_MouseUp);
            // 
            // NotifyIcon_TrayCheat
            // 
            this.NotifyIcon_TrayCheat.ContextMenuStrip = this.ContextMenuStrip_TrayCheat;
            this.NotifyIcon_TrayCheat.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon_TrayCheat.Icon")));
            this.NotifyIcon_TrayCheat.Text = "Tray Cheat";
            this.NotifyIcon_TrayCheat.Visible = true;
            this.NotifyIcon_TrayCheat.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_TrayCheat_MouseDoubleClick);
            // 
            // ContextMenuStrip_TrayCheat
            // 
            this.ContextMenuStrip_TrayCheat.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenu_Restore,
            this.ToolStripMenu_Hide,
            this.ToolStripMenu_Quit});
            this.ContextMenuStrip_TrayCheat.Name = "contextMenuStrip";
            this.ContextMenuStrip_TrayCheat.Size = new System.Drawing.Size(101, 70);
            // 
            // ToolStripMenu_Restore
            // 
            this.ToolStripMenu_Restore.Name = "ToolStripMenu_Restore";
            this.ToolStripMenu_Restore.Size = new System.Drawing.Size(100, 22);
            this.ToolStripMenu_Restore.Text = "还原";
            this.ToolStripMenu_Restore.Click += new System.EventHandler(this.ToolStripMenu_Restore_Click);
            // 
            // ToolStripMenu_Hide
            // 
            this.ToolStripMenu_Hide.Name = "ToolStripMenu_Hide";
            this.ToolStripMenu_Hide.Size = new System.Drawing.Size(100, 22);
            this.ToolStripMenu_Hide.Text = "隐藏";
            this.ToolStripMenu_Hide.Click += new System.EventHandler(this.ToolStripMenu_Hide_Click);
            // 
            // ToolStripMenu_Quit
            // 
            this.ToolStripMenu_Quit.Name = "ToolStripMenu_Quit";
            this.ToolStripMenu_Quit.Size = new System.Drawing.Size(100, 22);
            this.ToolStripMenu_Quit.Text = "退出";
            this.ToolStripMenu_Quit.Click += new System.EventHandler(this.ToolStripMenu_Quit_Click);
            // 
            // HideWindow
            // 
            this.HideWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.HideWindow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HideWindow.BackgroundImage")));
            this.HideWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HideWindow.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.HideWindow.FlatAppearance.BorderSize = 0;
            this.HideWindow.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.HideWindow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.HideWindow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.HideWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HideWindow.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HideWindow.Location = new System.Drawing.Point(250, 250);
            this.HideWindow.Name = "HideWindow";
            this.HideWindow.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HideWindow.Size = new System.Drawing.Size(150, 50);
            this.HideWindow.TabIndex = 9;
            this.HideWindow.Text = "隐藏窗口";
            this.HideWindow.UseVisualStyleBackColor = false;
            this.HideWindow.Click += new System.EventHandler(this.HideWindow_Click);
            this.HideWindow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HideWindow_MouseDown);
            this.HideWindow.MouseEnter += new System.EventHandler(this.HideWindow_MouseEnter);
            this.HideWindow.MouseLeave += new System.EventHandler(this.HideWindow_MouseLeave);
            this.HideWindow.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HideWindow_MouseUp);
            // 
            // QuitWindow
            // 
            this.QuitWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.QuitWindow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("QuitWindow.BackgroundImage")));
            this.QuitWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.QuitWindow.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.QuitWindow.FlatAppearance.BorderSize = 0;
            this.QuitWindow.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.QuitWindow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.QuitWindow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.QuitWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuitWindow.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitWindow.Location = new System.Drawing.Point(450, 250);
            this.QuitWindow.Name = "QuitWindow";
            this.QuitWindow.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.QuitWindow.Size = new System.Drawing.Size(150, 50);
            this.QuitWindow.TabIndex = 10;
            this.QuitWindow.Text = "退出程序";
            this.QuitWindow.UseVisualStyleBackColor = false;
            this.QuitWindow.Click += new System.EventHandler(this.QuitWindow_Click);
            this.QuitWindow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.QuitWindow_MouseDown);
            this.QuitWindow.MouseEnter += new System.EventHandler(this.QuitWindow_MouseEnter);
            this.QuitWindow.MouseLeave += new System.EventHandler(this.QuitWindow_MouseLeave);
            this.QuitWindow.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HideWindow_MouseUp);
            // 
            // Timer_IconEffect
            // 
            this.Timer_IconEffect.Interval = 50;
            this.Timer_IconEffect.Tick += new System.EventHandler(this.Timer_IconEffect_Tick);
            // 
            // ICONEffect
            // 
            this.ICONEffect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ICONEffect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ICONEffect.BackgroundImage")));
            this.ICONEffect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ICONEffect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ICONEffect.FlatAppearance.BorderSize = 0;
            this.ICONEffect.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.ICONEffect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ICONEffect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ICONEffect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ICONEffect.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ICONEffect.Location = new System.Drawing.Point(50, 250);
            this.ICONEffect.Name = "ICONEffect";
            this.ICONEffect.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ICONEffect.Size = new System.Drawing.Size(150, 50);
            this.ICONEffect.TabIndex = 11;
            this.ICONEffect.Text = "提示当前图标效果";
            this.ICONEffect.UseVisualStyleBackColor = false;
            this.ICONEffect.Click += new System.EventHandler(this.ICONEffect_Click);
            this.ICONEffect.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ICONEffect_MouseDown);
            this.ICONEffect.MouseEnter += new System.EventHandler(this.ICONEffect_MouseEnter);
            this.ICONEffect.MouseLeave += new System.EventHandler(this.ICONEffect_MouseLeave);
            this.ICONEffect.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ICONEffect_MouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(634, 411);
            this.Controls.Add(this.ICONEffect);
            this.Controls.Add(this.QuitWindow);
            this.Controls.Add(this.HideWindow);
            this.Controls.Add(this.HideTrayCheat);
            this.Controls.Add(this.ShowTrayCheat);
            this.Controls.Add(this.Hide360bug);
            this.Controls.Add(this.Hide360);
            this.Controls.Add(this.Show360bug);
            this.Controls.Add(this.Show360);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "TrayCheat";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_Closed);
            this.Shown += new System.EventHandler(this.TrayCheat_Shown);
            this.ContextMenuStrip_TrayCheat.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Show360;
        private System.Windows.Forms.Button Show360bug;
        private System.Windows.Forms.Button Hide360;
        private System.Windows.Forms.Button Hide360bug;
        private System.Windows.Forms.Button ShowTrayCheat;
        private System.Windows.Forms.Button HideTrayCheat;
        private System.Windows.Forms.Button HideWindow;

        private System.Windows.Forms.NotifyIcon NotifyIcon_TrayCheat;

        private System.Windows.Forms.ContextMenuStrip ContextMenuStrip_TrayCheat;
        
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenu_Quit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenu_Hide;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenu_Restore;
        private System.Windows.Forms.Button QuitWindow;
        private System.Windows.Forms.Timer Timer_IconEffect;
        private System.Windows.Forms.Button ICONEffect;
    }
}

