namespace FuwaiChartDemo
{
    partial class ChartSettingDialog
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
            this.keyWordLable = new System.Windows.Forms.Label();
            this.pNumLable = new System.Windows.Forms.Label();
            this.patientNumberTextBox1 = new System.Windows.Forms.TextBox();
            this.keyWordTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // keyWordLable
            // 
            this.keyWordLable.AutoSize = true;
            this.keyWordLable.Location = new System.Drawing.Point(60, 130);
            this.keyWordLable.Name = "keyWordLable";
            this.keyWordLable.Size = new System.Drawing.Size(48, 13);
            this.keyWordLable.TabIndex = 1;
            this.keyWordLable.Text = "Keyword";
            // 
            // pNumLable
            // 
            this.pNumLable.AutoSize = true;
            this.pNumLable.Location = new System.Drawing.Point(54, 189);
            this.pNumLable.Name = "pNumLable";
            this.pNumLable.Size = new System.Drawing.Size(77, 13);
            this.pNumLable.TabIndex = 2;
            this.pNumLable.Text = "PatientNumber";
            // 
            // patientNumberTextBox1
            // 
            this.patientNumberTextBox1.Location = new System.Drawing.Point(155, 185);
            this.patientNumberTextBox1.Name = "patientNumberTextBox1";
            this.patientNumberTextBox1.Size = new System.Drawing.Size(115, 20);
            this.patientNumberTextBox1.TabIndex = 3;
            // 
            // keyWordTextBox
            // 
            this.keyWordTextBox.Location = new System.Drawing.Point(147, 124);
            this.keyWordTextBox.Name = "keyWordTextBox";
            this.keyWordTextBox.Size = new System.Drawing.Size(100, 20);
            this.keyWordTextBox.TabIndex = 0;
            // 
            // ChartSettingDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 406);
            this.Controls.Add(this.patientNumberTextBox1);
            this.Controls.Add(this.pNumLable);
            this.Controls.Add(this.keyWordLable);
            this.Controls.Add(this.keyWordTextBox);
            this.Name = "ChartSettingDialog";
            this.Text = "ChartSettingDialog";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChartSettingDialog_FormClosing);
            this.Load += new System.EventHandler(this.ChartSettingDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox keyWordTextBox;
        private System.Windows.Forms.Label keyWordLable;
        private System.Windows.Forms.Label pNumLable;
        private System.Windows.Forms.TextBox patientNumberTextBox1;
    }
}