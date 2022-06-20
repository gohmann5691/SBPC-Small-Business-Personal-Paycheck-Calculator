
namespace PaycheckAppUI
{
    partial class LicensingInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LicensingInfo));
            this.licenseLabel = new System.Windows.Forms.Label();
            this.licensingRTF = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // licenseLabel
            // 
            this.licenseLabel.AutoSize = true;
            this.licenseLabel.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Underline);
            this.licenseLabel.Location = new System.Drawing.Point(179, 5);
            this.licenseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.licenseLabel.Name = "licenseLabel";
            this.licenseLabel.Size = new System.Drawing.Size(129, 46);
            this.licenseLabel.TabIndex = 0;
            this.licenseLabel.Text = "License";
            // 
            // licensingRTF
            // 
            this.licensingRTF.Location = new System.Drawing.Point(8, 53);
            this.licensingRTF.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.licensingRTF.Name = "licensingRTF";
            this.licensingRTF.Size = new System.Drawing.Size(473, 299);
            this.licensingRTF.TabIndex = 1;
            this.licensingRTF.Text = resources.GetString("licensingRTF.Text");
            this.licensingRTF.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // LicensingInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 357);
            this.Controls.Add(this.licensingRTF);
            this.Controls.Add(this.licenseLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "LicensingInfo";
            this.Text = "Licensing Information";
            this.Load += new System.EventHandler(this.LicensingInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label licenseLabel;
        private System.Windows.Forms.RichTextBox licensingRTF;
    }
}