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
            // 
            // TrayCheat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Show360);
            this.Controls.Add(this.Init360);
            this.Name = "TrayCheat";
            this.Text = "TrayCheat";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Init360;
        private System.Windows.Forms.Button Show360;
    }
}

