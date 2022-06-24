
namespace PaycheckAppUI
{
    public partial class PaycheckCalcMainWindow
    {

        //this.BackColor = System.Drawing.Color.Black; // <this instance>.<property>

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.completePaycheckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printAndCompletePaycheckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBusinessInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TitleOfApplication = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.name2Label = new System.Windows.Forms.Label();
            this.HouryWageOrSalaryLabel = new System.Windows.Forms.Label();
            this.hoursWorkedLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.paycheckDateInput = new System.Windows.Forms.DateTimePicker();
            this.firstNameInput = new System.Windows.Forms.TextBox();
            this.lastNameInput = new System.Windows.Forms.TextBox();
            this.hourlyWageInput = new System.Windows.Forms.TextBox();
            this.HoursWorkedTextBox = new System.Windows.Forms.TextBox();
            this.zipCodeLabel = new System.Windows.Forms.Label();
            this.fedAllowancesLabel = new System.Windows.Forms.Label();
            this.checkNumberInput = new System.Windows.Forms.NumericUpDown();
            this.checkNumberLabel = new System.Windows.Forms.Label();
            this.CalculatePaycheckButton = new System.Windows.Forms.Button();
            this.stateAllowanceLabel = new System.Windows.Forms.Label();
            this.ZipCodeTextBox = new System.Windows.Forms.TextBox();
            this.FederalAllowanceInput = new System.Windows.Forms.NumericUpDown();
            this.StateAllowanceInput = new System.Windows.Forms.NumericUpDown();
            this.EmployerOrEmployee = new System.Windows.Forms.ComboBox();
            this.HourlyOrSalaried = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkNumberInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FederalAllowanceInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StateAllowanceInput)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(914, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.completePaycheckToolStripMenuItem,
            this.printAndCompletePaycheckToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // completePaycheckToolStripMenuItem
            // 
            this.completePaycheckToolStripMenuItem.Name = "completePaycheckToolStripMenuItem";
            this.completePaycheckToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.completePaycheckToolStripMenuItem.Size = new System.Drawing.Size(407, 34);
            this.completePaycheckToolStripMenuItem.Text = "Complete Paycheck";
            this.completePaycheckToolStripMenuItem.Click += new System.EventHandler(this.completePaycheckToolStripMenuItem_Click);
            // 
            // printAndCompletePaycheckToolStripMenuItem
            // 
            this.printAndCompletePaycheckToolStripMenuItem.Name = "printAndCompletePaycheckToolStripMenuItem";
            this.printAndCompletePaycheckToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printAndCompletePaycheckToolStripMenuItem.Size = new System.Drawing.Size(407, 34);
            this.printAndCompletePaycheckToolStripMenuItem.Text = "Print And Complete Paycheck";
            this.printAndCompletePaycheckToolStripMenuItem.Click += new System.EventHandler(this.printAndCompletePaycheckToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBusinessInfoToolStripMenuItem,
            this.configureToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // addBusinessInfoToolStripMenuItem
            // 
            this.addBusinessInfoToolStripMenuItem.Name = "addBusinessInfoToolStripMenuItem";
            this.addBusinessInfoToolStripMenuItem.Size = new System.Drawing.Size(257, 34);
            this.addBusinessInfoToolStripMenuItem.Text = "Add Business Info";
            this.addBusinessInfoToolStripMenuItem.Click += new System.EventHandler(this.addBusinessInfoToolStripMenuItem_Click);
            // 
            // configureToolStripMenuItem
            // 
            this.configureToolStripMenuItem.Name = "configureToolStripMenuItem";
            this.configureToolStripMenuItem.Size = new System.Drawing.Size(257, 34);
            this.configureToolStripMenuItem.Text = "Configure";
            this.configureToolStripMenuItem.Click += new System.EventHandler(this.configureToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.licenseToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.helpToolStripMenuItem.Text = "About";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // licenseToolStripMenuItem
            // 
            this.licenseToolStripMenuItem.Name = "licenseToolStripMenuItem";
            this.licenseToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.licenseToolStripMenuItem.Text = "License";
            this.licenseToolStripMenuItem.Click += new System.EventHandler(this.licenseToolStripMenuItem_Click);
            // 
            // TitleOfApplication
            // 
            this.TitleOfApplication.AutoSize = true;
            this.TitleOfApplication.Font = new System.Drawing.Font("Lucida Console", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.TitleOfApplication.Location = new System.Drawing.Point(8, 52);
            this.TitleOfApplication.Name = "TitleOfApplication";
            this.TitleOfApplication.Size = new System.Drawing.Size(611, 50);
            this.TitleOfApplication.TabIndex = 1;
            this.TitleOfApplication.Text = "Paycheck Calculator";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.nameLabel.Location = new System.Drawing.Point(9, 152);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(280, 38);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Empolyee First Name";
            // 
            // name2Label
            // 
            this.name2Label.AutoSize = true;
            this.name2Label.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.name2Label.Location = new System.Drawing.Point(14, 207);
            this.name2Label.Name = "name2Label";
            this.name2Label.Size = new System.Drawing.Size(276, 38);
            this.name2Label.TabIndex = 7;
            this.name2Label.Text = "Empolyee Last Name";
            // 
            // HouryWageOrSalaryLabel
            // 
            this.HouryWageOrSalaryLabel.AutoSize = true;
            this.HouryWageOrSalaryLabel.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.HouryWageOrSalaryLabel.Location = new System.Drawing.Point(114, 260);
            this.HouryWageOrSalaryLabel.Name = "HouryWageOrSalaryLabel";
            this.HouryWageOrSalaryLabel.Size = new System.Drawing.Size(178, 38);
            this.HouryWageOrSalaryLabel.TabIndex = 9;
            this.HouryWageOrSalaryLabel.Text = "Hourly Wage";
            // 
            // hoursWorkedLabel
            // 
            this.hoursWorkedLabel.AutoSize = true;
            this.hoursWorkedLabel.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.hoursWorkedLabel.Location = new System.Drawing.Point(98, 314);
            this.hoursWorkedLabel.Name = "hoursWorkedLabel";
            this.hoursWorkedLabel.Size = new System.Drawing.Size(195, 38);
            this.hoursWorkedLabel.TabIndex = 11;
            this.hoursWorkedLabel.Text = "Hours Worked";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.dateLabel.Location = new System.Drawing.Point(92, 104);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(197, 38);
            this.dateLabel.TabIndex = 15;
            this.dateLabel.Text = "Paycheck Date";
            // 
            // paycheckDateInput
            // 
            this.paycheckDateInput.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.paycheckDateInput.Location = new System.Drawing.Point(292, 102);
            this.paycheckDateInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paycheckDateInput.Name = "paycheckDateInput";
            this.paycheckDateInput.Size = new System.Drawing.Size(410, 39);
            this.paycheckDateInput.TabIndex = 16;
            // 
            // firstNameInput
            // 
            this.firstNameInput.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.firstNameInput.Location = new System.Drawing.Point(292, 152);
            this.firstNameInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstNameInput.Name = "firstNameInput";
            this.firstNameInput.Size = new System.Drawing.Size(410, 39);
            this.firstNameInput.TabIndex = 17;
            // 
            // lastNameInput
            // 
            this.lastNameInput.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lastNameInput.Location = new System.Drawing.Point(292, 206);
            this.lastNameInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lastNameInput.Name = "lastNameInput";
            this.lastNameInput.Size = new System.Drawing.Size(410, 39);
            this.lastNameInput.TabIndex = 18;
            // 
            // hourlyWageInput
            // 
            this.hourlyWageInput.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hourlyWageInput.Location = new System.Drawing.Point(292, 260);
            this.hourlyWageInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hourlyWageInput.Name = "hourlyWageInput";
            this.hourlyWageInput.Size = new System.Drawing.Size(410, 39);
            this.hourlyWageInput.TabIndex = 19;
            // 
            // HoursWorkedTextBox
            // 
            this.HoursWorkedTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.HoursWorkedTextBox.Location = new System.Drawing.Point(292, 314);
            this.HoursWorkedTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HoursWorkedTextBox.Name = "HoursWorkedTextBox";
            this.HoursWorkedTextBox.Size = new System.Drawing.Size(410, 39);
            this.HoursWorkedTextBox.TabIndex = 20;
            // 
            // zipCodeLabel
            // 
            this.zipCodeLabel.AutoSize = true;
            this.zipCodeLabel.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.zipCodeLabel.Location = new System.Drawing.Point(158, 406);
            this.zipCodeLabel.Name = "zipCodeLabel";
            this.zipCodeLabel.Size = new System.Drawing.Size(128, 38);
            this.zipCodeLabel.TabIndex = 21;
            this.zipCodeLabel.Text = "Zip Code";
            // 
            // fedAllowancesLabel
            // 
            this.fedAllowancesLabel.AutoSize = true;
            this.fedAllowancesLabel.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.fedAllowancesLabel.Location = new System.Drawing.Point(32, 454);
            this.fedAllowancesLabel.Name = "fedAllowancesLabel";
            this.fedAllowancesLabel.Size = new System.Drawing.Size(254, 38);
            this.fedAllowancesLabel.TabIndex = 22;
            this.fedAllowancesLabel.Text = "Federal Allowances";
            // 
            // checkNumberInput
            // 
            this.checkNumberInput.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.checkNumberInput.Location = new System.Drawing.Point(292, 360);
            this.checkNumberInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkNumberInput.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.checkNumberInput.Name = "checkNumberInput";
            this.checkNumberInput.Size = new System.Drawing.Size(177, 39);
            this.checkNumberInput.TabIndex = 23;
            this.checkNumberInput.Click += new System.EventHandler(this.checkNumberInput_Click);
            // 
            // checkNumberLabel
            // 
            this.checkNumberLabel.AutoSize = true;
            this.checkNumberLabel.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.checkNumberLabel.Location = new System.Drawing.Point(84, 362);
            this.checkNumberLabel.Name = "checkNumberLabel";
            this.checkNumberLabel.Size = new System.Drawing.Size(202, 38);
            this.checkNumberLabel.TabIndex = 26;
            this.checkNumberLabel.Text = "Check Number";
            // 
            // CalculatePaycheckButton
            // 
            this.CalculatePaycheckButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CalculatePaycheckButton.Location = new System.Drawing.Point(640, 492);
            this.CalculatePaycheckButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CalculatePaycheckButton.Name = "CalculatePaycheckButton";
            this.CalculatePaycheckButton.Size = new System.Drawing.Size(262, 50);
            this.CalculatePaycheckButton.TabIndex = 40;
            this.CalculatePaycheckButton.Text = "Calculate Paycheck";
            this.CalculatePaycheckButton.UseVisualStyleBackColor = true;
            this.CalculatePaycheckButton.Click += new System.EventHandler(this.CalcPaycheckButton_Click);
            // 
            // stateAllowanceLabel
            // 
            this.stateAllowanceLabel.AutoSize = true;
            this.stateAllowanceLabel.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.stateAllowanceLabel.Location = new System.Drawing.Point(62, 501);
            this.stateAllowanceLabel.Name = "stateAllowanceLabel";
            this.stateAllowanceLabel.Size = new System.Drawing.Size(224, 38);
            this.stateAllowanceLabel.TabIndex = 30;
            this.stateAllowanceLabel.Text = "State Allowances";
            // 
            // ZipCodeTextBox
            // 
            this.ZipCodeTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ZipCodeTextBox.Location = new System.Drawing.Point(292, 406);
            this.ZipCodeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ZipCodeTextBox.Name = "ZipCodeTextBox";
            this.ZipCodeTextBox.Size = new System.Drawing.Size(178, 39);
            this.ZipCodeTextBox.TabIndex = 31;
            // 
            // FederalAllowanceInput
            // 
            this.FederalAllowanceInput.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FederalAllowanceInput.Location = new System.Drawing.Point(292, 453);
            this.FederalAllowanceInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FederalAllowanceInput.Name = "FederalAllowanceInput";
            this.FederalAllowanceInput.Size = new System.Drawing.Size(50, 39);
            this.FederalAllowanceInput.TabIndex = 33;
            // 
            // StateAllowanceInput
            // 
            this.StateAllowanceInput.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.StateAllowanceInput.Location = new System.Drawing.Point(292, 500);
            this.StateAllowanceInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StateAllowanceInput.Name = "StateAllowanceInput";
            this.StateAllowanceInput.Size = new System.Drawing.Size(50, 39);
            this.StateAllowanceInput.TabIndex = 34;
            // 
            // EmployerOrEmployee
            // 
            this.EmployerOrEmployee.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.EmployerOrEmployee.FormattingEnabled = true;
            this.EmployerOrEmployee.Location = new System.Drawing.Point(722, 150);
            this.EmployerOrEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmployerOrEmployee.Name = "EmployerOrEmployee";
            this.EmployerOrEmployee.Size = new System.Drawing.Size(164, 40);
            this.EmployerOrEmployee.TabIndex = 35;
            this.EmployerOrEmployee.SelectedIndexChanged += new System.EventHandler(this.EmployerOrEmployee_SelectedIndexChanged);
            // 
            // HourlyOrSalaried
            // 
            this.HourlyOrSalaried.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.HourlyOrSalaried.FormattingEnabled = true;
            this.HourlyOrSalaried.Location = new System.Drawing.Point(722, 258);
            this.HourlyOrSalaried.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HourlyOrSalaried.Name = "HourlyOrSalaried";
            this.HourlyOrSalaried.Size = new System.Drawing.Size(164, 40);
            this.HourlyOrSalaried.TabIndex = 36;
            this.HourlyOrSalaried.SelectedIndexChanged += new System.EventHandler(this.HourlyOrSalaried_SelectedIndexChanged);
            // 
            // PaycheckCalcMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(914, 554);
            this.Controls.Add(this.HourlyOrSalaried);
            this.Controls.Add(this.EmployerOrEmployee);
            this.Controls.Add(this.StateAllowanceInput);
            this.Controls.Add(this.FederalAllowanceInput);
            this.Controls.Add(this.ZipCodeTextBox);
            this.Controls.Add(this.stateAllowanceLabel);
            this.Controls.Add(this.CalculatePaycheckButton);
            this.Controls.Add(this.checkNumberLabel);
            this.Controls.Add(this.checkNumberInput);
            this.Controls.Add(this.fedAllowancesLabel);
            this.Controls.Add(this.zipCodeLabel);
            this.Controls.Add(this.HoursWorkedTextBox);
            this.Controls.Add(this.hourlyWageInput);
            this.Controls.Add(this.lastNameInput);
            this.Controls.Add(this.firstNameInput);
            this.Controls.Add(this.paycheckDateInput);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.hoursWorkedLabel);
            this.Controls.Add(this.HouryWageOrSalaryLabel);
            this.Controls.Add(this.name2Label);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.TitleOfApplication);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PaycheckCalcMainWindow";
            this.Text = "Paycheck Calculator v2.0";
            this.Load += new System.EventHandler(this.PaycheckCalcMainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkNumberInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FederalAllowanceInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StateAllowanceInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem completePaycheckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printAndCompletePaycheckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem licenseToolStripMenuItem;
        private System.Windows.Forms.Label TitleOfApplication;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label name2Label;
        private System.Windows.Forms.Label HouryWageOrSalaryLabel;
        private System.Windows.Forms.Label hoursWorkedLabel;
        private System.Windows.Forms.Label dateLabel;
        public System.Windows.Forms.DateTimePicker paycheckDateInput;
        public System.Windows.Forms.TextBox firstNameInput;
        public System.Windows.Forms.TextBox lastNameInput;
        public System.Windows.Forms.TextBox hourlyWageInput;
        public System.Windows.Forms.TextBox HoursWorkedTextBox;
        private System.Windows.Forms.Label zipCodeLabel;
        private System.Windows.Forms.Label fedAllowancesLabel;
        public System.Windows.Forms.NumericUpDown checkNumberInput;
        private System.Windows.Forms.Label checkNumberLabel;
        private System.Windows.Forms.Button CalculatePaycheckButton;
        private System.Windows.Forms.Label stateAllowanceLabel;
        public System.Windows.Forms.TextBox ZipCodeTextBox;
        public System.Windows.Forms.NumericUpDown FederalAllowanceInput;
        public System.Windows.Forms.NumericUpDown StateAllowanceInput;
        public System.Windows.Forms.ComboBox EmployerOrEmployee;
        public System.Windows.Forms.ComboBox HourlyOrSalaried;
        private System.Windows.Forms.ToolStripMenuItem addBusinessInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configureToolStripMenuItem;
    }
    
}

