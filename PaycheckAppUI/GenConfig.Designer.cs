
namespace PaycheckAppUI
{
    partial class GenConfig
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
            this.components = new System.ComponentModel.Container();
            this.generalConfigLabel = new System.Windows.Forms.Label();
            this.setPrinterLabel = new System.Windows.Forms.Label();
            this.directoryLocLabel = new System.Windows.Forms.Label();
            this.printersCombo = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.outputLocationTextBox = new System.Windows.Forms.TextBox();
            this.browseOutputButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.setDefaultZipLabel = new System.Windows.Forms.Label();
            this.defaultZipTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // generalConfigLabel
            // 
            this.generalConfigLabel.AutoSize = true;
            this.generalConfigLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Underline);
            this.generalConfigLabel.Location = new System.Drawing.Point(160, 6);
            this.generalConfigLabel.Name = "generalConfigLabel";
            this.generalConfigLabel.Size = new System.Drawing.Size(432, 54);
            this.generalConfigLabel.TabIndex = 0;
            this.generalConfigLabel.Text = "General Configurations";
            // 
            // setPrinterLabel
            // 
            this.setPrinterLabel.AutoSize = true;
            this.setPrinterLabel.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.setPrinterLabel.Location = new System.Drawing.Point(12, 53);
            this.setPrinterLabel.Name = "setPrinterLabel";
            this.setPrinterLabel.Size = new System.Drawing.Size(186, 48);
            this.setPrinterLabel.TabIndex = 1;
            this.setPrinterLabel.Text = "Set Printer";
            // 
            // directoryLocLabel
            // 
            this.directoryLocLabel.AutoSize = true;
            this.directoryLocLabel.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.directoryLocLabel.Location = new System.Drawing.Point(12, 260);
            this.directoryLocLabel.Name = "directoryLocLabel";
            this.directoryLocLabel.Size = new System.Drawing.Size(588, 48);
            this.directoryLocLabel.TabIndex = 2;
            this.directoryLocLabel.Text = "Paycheck Output Directory Location";
            this.directoryLocLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // printersCombo
            // 
            this.printersCombo.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.printersCombo.FormattingEnabled = true;
            this.printersCombo.Location = new System.Drawing.Point(12, 103);
            this.printersCombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.printersCombo.Name = "printersCombo";
            this.printersCombo.Size = new System.Drawing.Size(530, 53);
            this.printersCombo.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // outputLocationTextBox
            // 
            this.outputLocationTextBox.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.outputLocationTextBox.Location = new System.Drawing.Point(12, 320);
            this.outputLocationTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.outputLocationTextBox.Name = "outputLocationTextBox";
            this.outputLocationTextBox.ReadOnly = true;
            this.outputLocationTextBox.Size = new System.Drawing.Size(716, 50);
            this.outputLocationTextBox.TabIndex = 5;
            // 
            // browseOutputButton
            // 
            this.browseOutputButton.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.browseOutputButton.Location = new System.Drawing.Point(750, 320);
            this.browseOutputButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.browseOutputButton.Name = "browseOutputButton";
            this.browseOutputButton.Size = new System.Drawing.Size(150, 50);
            this.browseOutputButton.TabIndex = 6;
            this.browseOutputButton.Text = "Browse";
            this.browseOutputButton.UseVisualStyleBackColor = true;
            this.browseOutputButton.Click += new System.EventHandler(this.BrowseOutputButton_Click);
            // 
            // applyButton
            // 
            this.applyButton.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.applyButton.Location = new System.Drawing.Point(750, 402);
            this.applyButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(150, 50);
            this.applyButton.TabIndex = 7;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.exitButton.Location = new System.Drawing.Point(594, 402);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.exitButton.Size = new System.Drawing.Size(150, 50);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.resetButton.Location = new System.Drawing.Point(750, 11);
            this.resetButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resetButton.Name = "resetButton";
            this.resetButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.resetButton.Size = new System.Drawing.Size(150, 50);
            this.resetButton.TabIndex = 9;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // setDefaultZipLabel
            // 
            this.setDefaultZipLabel.AutoSize = true;
            this.setDefaultZipLabel.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.setDefaultZipLabel.Location = new System.Drawing.Point(12, 158);
            this.setDefaultZipLabel.Name = "setDefaultZipLabel";
            this.setDefaultZipLabel.Size = new System.Drawing.Size(348, 48);
            this.setDefaultZipLabel.TabIndex = 10;
            this.setDefaultZipLabel.Text = "Set Default Zip Code";
            // 
            // defaultZipTextBox
            // 
            this.defaultZipTextBox.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.defaultZipTextBox.Location = new System.Drawing.Point(12, 208);
            this.defaultZipTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.defaultZipTextBox.Name = "defaultZipTextBox";
            this.defaultZipTextBox.Size = new System.Drawing.Size(530, 50);
            this.defaultZipTextBox.TabIndex = 11;
            // 
            // GenConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 463);
            this.Controls.Add(this.defaultZipTextBox);
            this.Controls.Add(this.setDefaultZipLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.browseOutputButton);
            this.Controls.Add(this.outputLocationTextBox);
            this.Controls.Add(this.printersCombo);
            this.Controls.Add(this.directoryLocLabel);
            this.Controls.Add(this.setPrinterLabel);
            this.Controls.Add(this.generalConfigLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GenConfig";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label generalConfigLabel;
        private System.Windows.Forms.Label setPrinterLabel;
        private System.Windows.Forms.Label directoryLocLabel;
        private System.Windows.Forms.ComboBox printersCombo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox outputLocationTextBox;
        private System.Windows.Forms.Button browseOutputButton;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label setDefaultZipLabel;
        private System.Windows.Forms.TextBox defaultZipTextBox;
    }
}