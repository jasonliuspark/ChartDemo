namespace FuwaiChartDemo
{
    partial class MainForm
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
            this.UltrasoundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CardiacUltrasoundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CardiacConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MeasurementConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UltrasoundToolStripMenuItem,
            this.CardiacConfigToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(775, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // UltrasoundToolStripMenuItem
            // 
            this.UltrasoundToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CardiacUltrasoundToolStripMenuItem});
            this.UltrasoundToolStripMenuItem.Name = "UltrasoundToolStripMenuItem";
            this.UltrasoundToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.UltrasoundToolStripMenuItem.Text = "心动超声";
            // 
            // CardiacUltrasoundToolStripMenuItem
            // 
            this.CardiacUltrasoundToolStripMenuItem.Name = "CardiacUltrasoundToolStripMenuItem";
            this.CardiacUltrasoundToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.CardiacUltrasoundToolStripMenuItem.Text = "超声心动图测量趋势";
            this.CardiacUltrasoundToolStripMenuItem.Click += new System.EventHandler(this.CardiacUltrasoundToolStripMenuItem_Click);
            // 
            // CardiacConfigToolStripMenuItem
            // 
            this.CardiacConfigToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MeasurementConfigToolStripMenuItem});
            this.CardiacConfigToolStripMenuItem.Name = "CardiacConfigToolStripMenuItem";
            this.CardiacConfigToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.CardiacConfigToolStripMenuItem.Text = "心动超声配置";
            // 
            // MeasurementConfigToolStripMenuItem
            // 
            this.MeasurementConfigToolStripMenuItem.Name = "MeasurementConfigToolStripMenuItem";
            this.MeasurementConfigToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.MeasurementConfigToolStripMenuItem.Text = "测量值选择";
            this.MeasurementConfigToolStripMenuItem.Click += new System.EventHandler(this.CalculationFigureToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 456);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Cardiac";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem UltrasoundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CardiacUltrasoundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CardiacConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MeasurementConfigToolStripMenuItem;
    }
}

