
namespace PaycheckAppUI
{
    partial class About
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
            this.aboutLabel = new System.Windows.Forms.Label();
            this.forSupportLabel = new System.Windows.Forms.Label();
            this.myName = new System.Windows.Forms.Label();
            this.myEmailLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // aboutLabel
            // 
            this.aboutLabel.AutoSize = true;
            this.aboutLabel.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Underline);
            this.aboutLabel.Location = new System.Drawing.Point(8, 6);
            this.aboutLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.aboutLabel.Name = "aboutLabel";
            this.aboutLabel.Size = new System.Drawing.Size(113, 46);
            this.aboutLabel.TabIndex = 0;
            this.aboutLabel.Text = "About";
            this.aboutLabel.Click += new System.EventHandler(this.AboutLabel_Click);
            // 
            // forSupportLabel
            // 
            this.forSupportLabel.AutoSize = true;
            this.forSupportLabel.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.forSupportLabel.Location = new System.Drawing.Point(8, 58);
            this.forSupportLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.forSupportLabel.Name = "forSupportLabel";
            this.forSupportLabel.Size = new System.Drawing.Size(332, 46);
            this.forSupportLabel.TabIndex = 1;
            this.forSupportLabel.Text = "For Support Contact:";
            // 
            // myName
            // 
            this.myName.AutoSize = true;
            this.myName.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.myName.Location = new System.Drawing.Point(8, 113);
            this.myName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.myName.Name = "myName";
            this.myName.Size = new System.Drawing.Size(251, 46);
            this.myName.TabIndex = 2;
            this.myName.Text = "Colin Gohmann";
            // 
            // myEmailLabel
            // 
            this.myEmailLabel.AutoSize = true;
            this.myEmailLabel.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.myEmailLabel.Location = new System.Drawing.Point(8, 157);
            this.myEmailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.myEmailLabel.Name = "myEmailLabel";
            this.myEmailLabel.Size = new System.Drawing.Size(437, 46);
            this.myEmailLabel.TabIndex = 3;
            this.myEmailLabel.Text = "colin.gohmann@yahoo.com";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 206);
            this.Controls.Add(this.myEmailLabel);
            this.Controls.Add(this.myName);
            this.Controls.Add(this.forSupportLabel);
            this.Controls.Add(this.aboutLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "About";
            this.Text = "About Small Business Paycheck Calculator";
            this.Load += new System.EventHandler(this.About_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label aboutLabel;
        private System.Windows.Forms.Label forSupportLabel;
        private System.Windows.Forms.Label myName;
        private System.Windows.Forms.Label myEmailLabel;
    }
}