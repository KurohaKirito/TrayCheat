namespace TrayCheat
{
    partial class TrayCheat
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
            this.Init360 = new System.Windows.Forms.Button();
            this.Show360 = new System.Windows.Forms.Button();
            this.Init360bug = new System.Windows.Forms.Button();
            this.Show360bug = new System.Windows.Forms.Button();
            this.Hide360 = new System.Windows.Forms.Button();
            this.Hide360bug = new System.Windows.Forms.Button();
            this.InitTrayCheat = new System.Windows.Forms.Button();
            this.ShowTrayCheat = new System.Windows.Forms.Button();
            this.HideTrayCheat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Init360
            // 
            this.Init360.Location = new System.Drawing.Point(83, 48);
            this.Init360.Name = "Init360";
            this.Init360.Size = new System.Drawing.Size(75, 23);
            this.Init360.TabIndex = 0;
            this.Init360.Text = "初始化360";
            this.Init360.UseVisualStyleBackColor = true;
            this.Init360.Click += new System.EventHandler(this.Init360_Click);
            // 
            // Show360
            // 
            this.Show360.Location = new System.Drawing.Point(83, 123);
            this.Show360.Name = "Show360";
            this.Show360.Size = new System.Drawing.Size(75, 23);
            this.Show360.TabIndex = 1;
            this.Show360.Text = "显示360";
            this.Show360.UseVisualStyleBackColor = true;
            this.Show360.Click += new System.EventHandler(this.Show360_Click);
            // 
            // Init360bug
            // 
            this.Init360bug.Location = new System.Drawing.Point(269, 48);
            this.Init360bug.Name = "Init360bug";
            this.Init360bug.Size = new System.Drawing.Size(102, 23);
            this.Init360bug.TabIndex = 2;
            this.Init360bug.Text = "初始化360杀毒";
            this.Init360bug.UseVisualStyleBackColor = true;
            this.Init360bug.Click += new System.EventHandler(this.Init360bug_Click);
            // 
            // Show360bug
            // 
            this.Show360bug.Location = new System.Drawing.Point(269, 123);
            this.Show360bug.Name = "Show360bug";
            this.Show360bug.Size = new System.Drawing.Size(102, 23);
            this.Show360bug.TabIndex = 3;
            this.Show360bug.Text = "显示360杀毒";
            this.Show360bug.UseVisualStyleBackColor = true;
            this.Show360bug.Click += new System.EventHandler(this.Show360bug_Click);
            // 
            // Hide360
            // 
            this.Hide360.Location = new System.Drawing.Point(83, 194);
            this.Hide360.Name = "Hide360";
            this.Hide360.Size = new System.Drawing.Size(75, 23);
            this.Hide360.TabIndex = 4;
            this.Hide360.Text = "隐藏360";
            this.Hide360.UseVisualStyleBackColor = true;
            this.Hide360.Click += new System.EventHandler(this.Hide360_Click);
            // 
            // Hide360bug
            // 
            this.Hide360bug.Location = new System.Drawing.Point(269, 194);
            this.Hide360bug.Name = "Hide360bug";
            this.Hide360bug.Size = new System.Drawing.Size(102, 23);
            this.Hide360bug.TabIndex = 5;
            this.Hide360bug.Text = "隐藏360杀毒";
            this.Hide360bug.UseVisualStyleBackColor = true;
            this.Hide360bug.Click += new System.EventHandler(this.Hide360bug_Click);
            // 
            // InitTrayCheat
            // 
            this.InitTrayCheat.Location = new System.Drawing.Point(462, 47);
            this.InitTrayCheat.Name = "InitTrayCheat";
            this.InitTrayCheat.Size = new System.Drawing.Size(113, 23);
            this.InitTrayCheat.TabIndex = 6;
            this.InitTrayCheat.Text = "初始化 TrayCheat";
            this.InitTrayCheat.UseVisualStyleBackColor = true;
            this.InitTrayCheat.Click += new System.EventHandler(this.InitTrayCheat_Click);
            // 
            // ShowTrayCheat
            // 
            this.ShowTrayCheat.Location = new System.Drawing.Point(462, 123);
            this.ShowTrayCheat.Name = "ShowTrayCheat";
            this.ShowTrayCheat.Size = new System.Drawing.Size(113, 23);
            this.ShowTrayCheat.TabIndex = 7;
            this.ShowTrayCheat.Text = "显示 TrayCheat";
            this.ShowTrayCheat.UseVisualStyleBackColor = true;
            this.ShowTrayCheat.Click += new System.EventHandler(this.ShowTrayCheat_Click);
            // 
            // HideTrayCheat
            // 
            this.HideTrayCheat.Location = new System.Drawing.Point(462, 194);
            this.HideTrayCheat.Name = "HideTrayCheat";
            this.HideTrayCheat.Size = new System.Drawing.Size(113, 23);
            this.HideTrayCheat.TabIndex = 8;
            this.HideTrayCheat.Text = "隐藏 TrayCheat";
            this.HideTrayCheat.UseVisualStyleBackColor = true;
            this.HideTrayCheat.Click += new System.EventHandler(this.HideTrayCheat_Click);
            // 
            // TrayCheat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HideTrayCheat);
            this.Controls.Add(this.ShowTrayCheat);
            this.Controls.Add(this.InitTrayCheat);
            this.Controls.Add(this.Hide360bug);
            this.Controls.Add(this.Hide360);
            this.Controls.Add(this.Show360bug);
            this.Controls.Add(this.Init360bug);
            this.Controls.Add(this.Show360);
            this.Controls.Add(this.Init360);
            this.Name = "TrayCheat";
            this.Text = "TrayCheat";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Init360;
        private System.Windows.Forms.Button Show360;
        private System.Windows.Forms.Button Init360bug;
        private System.Windows.Forms.Button Show360bug;
        private System.Windows.Forms.Button Hide360;
        private System.Windows.Forms.Button Hide360bug;
        private System.Windows.Forms.Button InitTrayCheat;
        private System.Windows.Forms.Button ShowTrayCheat;
        private System.Windows.Forms.Button HideTrayCheat;
    }
}

