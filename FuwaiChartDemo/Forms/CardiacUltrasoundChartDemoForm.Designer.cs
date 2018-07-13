namespace FuwaiChartDemo
{
    partial class CadiacUltrasoundChartDemoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.超声心动ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.超声心动图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.心动超声配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.测量值选择ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.超声心动ToolStripMenuItem,
            this.心动超声配置ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(775, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 超声心动ToolStripMenuItem
            // 
            this.超声心动ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.超声心动图ToolStripMenuItem});
            this.超声心动ToolStripMenuItem.Name = "超声心动ToolStripMenuItem";
            this.超声心动ToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.超声心动ToolStripMenuItem.Text = "心动超声";
            // 
            // 超声心动图ToolStripMenuItem
            // 
            this.超声心动图ToolStripMenuItem.Name = "超声心动图ToolStripMenuItem";
            this.超声心动图ToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.超声心动图ToolStripMenuItem.Text = "超声心动图测量趋势";
            this.超声心动图ToolStripMenuItem.Click += new System.EventHandler(this.超声心动图ToolStripMenuItem_Click);
            // 
            // 心动超声配置ToolStripMenuItem
            // 
            this.心动超声配置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.测量值选择ToolStripMenuItem});
            this.心动超声配置ToolStripMenuItem.Name = "心动超声配置ToolStripMenuItem";
            this.心动超声配置ToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.心动超声配置ToolStripMenuItem.Text = "心动超声配置";
            // 
            // 测量值选择ToolStripMenuItem
            // 
            this.测量值选择ToolStripMenuItem.Name = "测量值选择ToolStripMenuItem";
            this.测量值选择ToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.测量值选择ToolStripMenuItem.Text = "测量值选择";
            this.测量值选择ToolStripMenuItem.Click += new System.EventHandler(this.测量值选择ToolStripMenuItem_Click);
            // 
            // CadiacUltrasoundChartDemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 456);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CadiacUltrasoundChartDemoForm";
            this.Text = "Cardiac";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 超声心动ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 超声心动图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 心动超声配置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 测量值选择ToolStripMenuItem;
    }
}

