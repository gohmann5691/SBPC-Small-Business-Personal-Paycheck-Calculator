
namespace PaycheckAppUI
{
    partial class BusinessInfoConfig
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
            this.businessLogoInputLabel = new System.Windows.Forms.Label();
            this.businessNameLabel = new System.Windows.Forms.Label();
            this.shorDescLabel = new System.Windows.Forms.Label();
            this.businessLogoPathInput = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.setNameInput = new System.Windows.Forms.TextBox();
            this.shortDescInput = new System.Windows.Forms.TextBox();
            this.applyButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.bussTitleConfig = new System.Windows.Forms.Label();
            this.resetBusinessSettButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // businessLogoInputLabel
            // 
            this.businessLogoInputLabel.AutoSize = true;
            this.businessLogoInputLabel.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.businessLogoInputLabel.Location = new System.Drawing.Point(31, 49);
            this.businessLogoInputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.businessLogoInputLabel.Name = "businessLogoInputLabel";
            this.businessLogoInputLabel.Size = new System.Drawing.Size(167, 28);
            this.businessLogoInputLabel.TabIndex = 0;
            this.businessLogoInputLabel.Text = "Set Business Logo";
            // 
            // businessNameLabel
            // 
            this.businessNameLabel.AutoSize = true;
            this.businessNameLabel.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.businessNameLabel.Location = new System.Drawing.Point(24, 85);
            this.businessNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.businessNameLabel.Name = "businessNameLabel";
            this.businessNameLabel.Size = new System.Drawing.Size(174, 28);
            this.businessNameLabel.TabIndex = 1;
            this.businessNameLabel.Text = "Set Business Name";
            // 
            // shorDescLabel
            // 
            this.shorDescLabel.AutoSize = true;
            this.shorDescLabel.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.shorDescLabel.Location = new System.Drawing.Point(0, 121);
            this.shorDescLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.shorDescLabel.Name = "shorDescLabel";
            this.shorDescLabel.Size = new System.Drawing.Size(198, 28);
            this.shorDescLabel.TabIndex = 2;
            this.shorDescLabel.Text = "Set Short Description";
            // 
            // businessLogoPathInput
            // 
            this.businessLogoPathInput.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.businessLogoPathInput.Location = new System.Drawing.Point(203, 49);
            this.businessLogoPathInput.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.businessLogoPathInput.Name = "businessLogoPathInput";
            this.businessLogoPathInput.Size = new System.Drawing.Size(343, 34);
            this.businessLogoPathInput.TabIndex = 3;
            // 
            // browseButton
            // 
            this.browseButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton.Location = new System.Drawing.Point(560, 49);
            this.browseButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(100, 32);
            this.browseButton.TabIndex = 4;
            this.browseButton.Text = "Browse";
            this.browseButton.UseCompatibleTextRendering = true;
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // setNameInput
            // 
            this.setNameInput.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.setNameInput.Location = new System.Drawing.Point(203, 82);
            this.setNameInput.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.setNameInput.Name = "setNameInput";
            this.setNameInput.Size = new System.Drawing.Size(343, 34);
            this.setNameInput.TabIndex = 5;
            // 
            // shortDescInput
            // 
            this.shortDescInput.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.shortDescInput.Location = new System.Drawing.Point(203, 115);
            this.shortDescInput.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.shortDescInput.Name = "shortDescInput";
            this.shortDescInput.Size = new System.Drawing.Size(343, 34);
            this.shortDescInput.TabIndex = 6;
            // 
            // applyButton
            // 
            this.applyButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyButton.Location = new System.Drawing.Point(560, 158);
            this.applyButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(100, 32);
            this.applyButton.TabIndex = 7;
            this.applyButton.Text = "Apply";
            this.applyButton.UseCompatibleTextRendering = true;
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(456, 158);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 32);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseCompatibleTextRendering = true;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // bussTitleConfig
            // 
            this.bussTitleConfig.AutoSize = true;
            this.bussTitleConfig.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Underline);
            this.bussTitleConfig.Location = new System.Drawing.Point(179, 6);
            this.bussTitleConfig.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bussTitleConfig.Name = "bussTitleConfig";
            this.bussTitleConfig.Size = new System.Drawing.Size(293, 37);
            this.bussTitleConfig.TabIndex = 9;
            this.bussTitleConfig.Text = "Business Info Configure";
            // 
            // resetBusinessSettButton
            // 
            this.resetBusinessSettButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBusinessSettButton.Location = new System.Drawing.Point(560, 6);
            this.resetBusinessSettButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.resetBusinessSettButton.Name = "resetBusinessSettButton";
            this.resetBusinessSettButton.Size = new System.Drawing.Size(100, 32);
            this.resetBusinessSettButton.TabIndex = 10;
            this.resetBusinessSettButton.Text = "Reset";
            this.resetBusinessSettButton.UseCompatibleTextRendering = true;
            this.resetBusinessSettButton.UseVisualStyleBackColor = true;
            this.resetBusinessSettButton.Click += new System.EventHandler(this.ResetBusinessSettButton_Click);
            // 
            // BusinessInfoConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 200);
            this.Controls.Add(this.resetBusinessSettButton);
            this.Controls.Add(this.bussTitleConfig);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.shortDescInput);
            this.Controls.Add(this.setNameInput);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.businessLogoPathInput);
            this.Controls.Add(this.shorDescLabel);
            this.Controls.Add(this.businessNameLabel);
            this.Controls.Add(this.businessLogoInputLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "BusinessInfoConfig";
            this.Text = "Business Info";
            this.Load += new System.EventHandler(this.BusinessInfoConfig_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label businessLogoInputLabel;
        private System.Windows.Forms.Label businessNameLabel;
        private System.Windows.Forms.Label shorDescLabel;
        private System.Windows.Forms.TextBox businessLogoPathInput;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TextBox setNameInput;
        private System.Windows.Forms.TextBox shortDescInput;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label bussTitleConfig;
        private System.Windows.Forms.Button resetBusinessSettButton;
    }
}