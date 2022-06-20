
namespace PaycheckAppUI
{
    partial class PaycheckUIOutput
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
            this.outputText = new System.Windows.Forms.RichTextBox();
            this.companyLogoBox = new System.Windows.Forms.PictureBox();
            this.companyNameLabel = new System.Windows.Forms.Label();
            this.printButton = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.saveButton = new System.Windows.Forms.Button();
            this.copiesLabel = new System.Windows.Forms.Label();
            this.numericPrinterCopies = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.companyLogoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrinterCopies)).BeginInit();
            this.SuspendLayout();
            // 
            // outputText
            // 
            this.outputText.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.outputText.Location = new System.Drawing.Point(11, 226);
            this.outputText.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(671, 492);
            this.outputText.TabIndex = 0;
            this.outputText.Text = "";
            // 
            // companyLogoBox
            // 
            this.companyLogoBox.Location = new System.Drawing.Point(11, 26);
            this.companyLogoBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.companyLogoBox.Name = "companyLogoBox";
            this.companyLogoBox.Size = new System.Drawing.Size(197, 170);
            this.companyLogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.companyLogoBox.TabIndex = 1;
            this.companyLogoBox.TabStop = false;
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.AutoSize = true;
            this.companyNameLabel.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Underline);
            this.companyNameLabel.Location = new System.Drawing.Point(227, 89);
            this.companyNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(307, 54);
            this.companyNameLabel.TabIndex = 2;
            this.companyNameLabel.Text = "Company Name";
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(551, 10);
            this.printButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(131, 33);
            this.printButton.TabIndex = 3;
            this.printButton.Text = "Print Paycheck";
            this.printButton.UseCompatibleTextRendering = true;
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.saveButton.Location = new System.Drawing.Point(551, 47);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(131, 33);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save Paycheck Only";
            this.saveButton.UseCompatibleTextRendering = true;
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveOnlyButon_Click);
            // 
            // copiesLabel
            // 
            this.copiesLabel.AutoSize = true;
            this.copiesLabel.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.copiesLabel.Location = new System.Drawing.Point(571, 118);
            this.copiesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.copiesLabel.Name = "copiesLabel";
            this.copiesLabel.Size = new System.Drawing.Size(69, 25);
            this.copiesLabel.TabIndex = 5;
            this.copiesLabel.Text = "Copies";
            // 
            // numericPrinterCopies
            // 
            this.numericPrinterCopies.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.numericPrinterCopies.Location = new System.Drawing.Point(634, 114);
            this.numericPrinterCopies.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.numericPrinterCopies.Name = "numericPrinterCopies";
            this.numericPrinterCopies.Size = new System.Drawing.Size(48, 32);
            this.numericPrinterCopies.TabIndex = 6;
            // 
            // PaycheckUIOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 728);
            this.Controls.Add(this.numericPrinterCopies);
            this.Controls.Add(this.copiesLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.companyNameLabel);
            this.Controls.Add(this.companyLogoBox);
            this.Controls.Add(this.outputText);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "PaycheckUIOutput";
            this.Text = "Paycheck Preview";
            this.Load += new System.EventHandler(this.PaycheckUIOutput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.companyLogoBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrinterCopies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox outputText;
        private System.Windows.Forms.PictureBox companyLogoBox;
        private System.Windows.Forms.Label companyNameLabel;
        public System.Windows.Forms.Button printButton;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label copiesLabel;
        private System.Windows.Forms.NumericUpDown numericPrinterCopies;
    }
}