using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using CSharpToPythonConfigure;
//used for file paths
using System.IO;
//used for exception
using Microsoft.CSharp.RuntimeBinder;
//printer
using System.Drawing.Printing;
namespace PaycheckAppUI
{
    public partial class PaycheckCalcMainWindow : Form
    {
        private CSharpToPythonConfigure.PythonEngineBackend pythonEngineInstance;
        private bool is_employee;
        public PaycheckCalcMainWindow()
        {
            
            InitializeComponent();            
        }

        private void addOptionsToDropDowns()
        {
            //employer or employee
            EmployeeOrEmployerComboInitializtion addEmployeeOrEmployer = new EmployeeOrEmployerComboInitializtion();
            addEmployeeOrEmployer.ComboBoxControl = this.EmployerOrEmployee;
            addEmployeeOrEmployer.fillItemsInComboBox();
            this.EmployerOrEmployee = addEmployeeOrEmployer.ComboBoxControl;
            //Hourly versus Salary Wage
            hourlyOrSalariedComboInitialization addPayrollType = new hourlyOrSalariedComboInitialization();
            addPayrollType.ComboBoxControl = this.HourlyOrSalaried;
            addPayrollType.fillItemsInComboBox();
            this.HourlyOrSalaried = addPayrollType.ComboBoxControl;

        }
        private void addLimitsOnAllowances()
        {
            this.StateAllowanceInput.Maximum = 5;
            this.StateAllowanceInput.Minimum = 0;
            this.StateAllowanceInput.Value = 0;

            this.FederalAllowanceInput.Maximum = 5;
            this.FederalAllowanceInput.Minimum = 0;
            this.FederalAllowanceInput.Value = 0;
        }
        private void startPythonEngine()
        {
            this.pythonEngineInstance = new PythonEngineBackend();
            pythonEngineInstance.setupErrorOutputStream();
            pythonEngineInstance.initializePythonEngine();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void fileToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }
        private void PaycheckCalcMainWindow_Load(object sender, EventArgs e)
        {
            //set up some of the UI components manually
            addOptionsToDropDowns();
            addLimitsOnAllowances();
            //initialize the python engine
            startPythonEngine();
            //set default zip code if any
            if (Properties.Settings.Default.DefaultZipCode != "")
            {
                ZipCodeTextBox.Text = Properties.Settings.Default.DefaultZipCode;
            }
            //set defualt printer if not initialized already or the string is empty
            if (Properties.Settings.Default.PrinterName == "empty" || Properties.Settings.Default.PrinterName == "")
            {
                PrinterSettings settings = new PrinterSettings();
                Properties.Settings.Default.PrinterName = settings.PrinterName;
            }
            //output path default to local
            if(Properties.Settings.Default.OutputPath == "empty")// || Properties.Settings.Default.OuputPath == "")
            {
                Properties.Settings.Default.OutputPath = AppDomain.CurrentDomain.BaseDirectory;
            }
            //set up default image path
            if (Properties.Settings.Default.ImagePath == "empty")
            {
                Properties.Settings.Default.ImagePath =Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\defaultImage.png");
            }
            this.Icon = Properties.Resources.SBPC_Logo;
        }
        private void CalcPaycheckButton_Click(object sender, EventArgs e)
        {
            PaycheckUIOutput newOutputPaycheck = new PaycheckUIOutput();
            //query the database
            try
            {
                QueryCityDatabase newCityTaxRate = new QueryCityDatabase(ZipCodeTextBox.Text);
                newCityTaxRate.QueryDatabase();
                List<string> cityResults = newCityTaxRate.ResultStrListControl;
                cityResults[0].Replace(".", ",");
                double localTaxResults= Math.Round(double.Parse(cityResults[1], System.Globalization.CultureInfo.InvariantCulture),5);
                try
                {
                    //convert and store the values inputted by the user
                    double hourlywageOrBaseSalary = formatToDouble(hourlyWageInput.Text);
                    double salary = formatToDouble(hourlyWageInput.Text);
                    double hoursWorked = 0.0;
                    if (HoursWorkedTextBox.Text != "")
                    {
                        hoursWorked = formatToDouble(HoursWorkedTextBox.Text);
                    }
                    int fedA = Int32.Parse(FederalAllowanceInput.Text);
                    int stateA = Int32.Parse(StateAllowanceInput.Text);
                    //TODO: add more try blocks as necessary
                    //send to backend...
                    PaycheckCalcInitialize initializeCalculation = new PaycheckCalcInitialize(this.pythonEngineInstance, HourlyOrSalaried.Text, hourlywageOrBaseSalary, hoursWorked, is_employee, fedA, stateA,
                        localTaxResults, salary);
                    initializeCalculation.executeCalculation();
                    newOutputPaycheck.OutputControl = initializeCalculation.OutputControl;
                    newOutputPaycheck.MainFormInstance = this;
                    newOutputPaycheck.ShowDialog();
                }
                catch(System.FormatException Formaterror)
                {
                    MessageBox.Show("One or more fields has an invalid input. Please try again!", "Field Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (RuntimeBinderException binderError){
                MessageBox.Show("An Invalid Zip code was entered. Please try again!", "Zip Code error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private double formatToDouble(string input)
        {
            double output = Math.Round(double.Parse(input, System.Globalization.CultureInfo.InvariantCulture), 5);
            return output;
        }

        private void HourlyOrSalaried_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (HourlyOrSalaried.Text == "Salaried")
            {
                HouryWageOrSalaryLabel.Text = "Salary";
                HoursWorkedTextBox.Text = "";
                hoursWorkedLabel.Enabled = false;
                HoursWorkedTextBox.Enabled = false;
            }
            else
            {
                HouryWageOrSalaryLabel.Text = "Hourly Wage";
                hoursWorkedLabel.Enabled = true;
                HoursWorkedTextBox.Enabled = true;
            }
        }

        private void completePaycheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaycheckUIOutput newOutputPaycheck = new PaycheckUIOutput();
            //query the database
            try
            {
                QueryCityDatabase newCityTaxRate = new QueryCityDatabase(ZipCodeTextBox.Text);
                newCityTaxRate.QueryDatabase();
                List<string> cityResults = newCityTaxRate.ResultStrListControl;
                cityResults[0].Replace(".", ",");
                double localTaxResults = Math.Round(double.Parse(cityResults[1], System.Globalization.CultureInfo.InvariantCulture), 5);
                try
                {
                    //convert and store the values inputted by the user
                    double hourlywageOrBaseSalary = formatToDouble(hourlyWageInput.Text);
                    double salary = formatToDouble(hourlyWageInput.Text);
                    double hoursWorked = 0.0;
                    if (HoursWorkedTextBox.Text != "")
                    {
                        hoursWorked = formatToDouble(HoursWorkedTextBox.Text);
                    }
                    int fedA = Int32.Parse(FederalAllowanceInput.Text);
                    int stateA = Int32.Parse(StateAllowanceInput.Text);
                    //TODO: add more try blocks as necessary
                    //send to backend...
                    PaycheckCalcInitialize initializeCalculation = new PaycheckCalcInitialize(this.pythonEngineInstance, HourlyOrSalaried.Text, hourlywageOrBaseSalary, hoursWorked, is_employee, fedA, stateA,
                        localTaxResults, salary);
                    initializeCalculation.executeCalculation();
                    newOutputPaycheck.OutputControl = initializeCalculation.OutputControl;
                    //initializeCalculation.printParameters();
                    newOutputPaycheck.MainFormInstance = this;
                    newOutputPaycheck.ShowDialog();
                }
                catch (System.FormatException Formaterror)
                {
                    MessageBox.Show("One or more fields has an invalid input. Please try again!", "Field Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }
            catch (RuntimeBinderException binderError)
            {
                MessageBox.Show("An Invalid Zip code was entered. Please try again!", "Zip Code error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addBusinessInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BusinessInfoConfig newConfigWindow = new BusinessInfoConfig();
            newConfigWindow.ShowDialog();
        }

        private void printAndCompletePaycheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO: make this chunk more efficient
            PaycheckUIOutput newOutputPaycheck = new PaycheckUIOutput();
            //query the database
            try
            {
                QueryCityDatabase newCityTaxRate = new QueryCityDatabase(ZipCodeTextBox.Text);
                newCityTaxRate.QueryDatabase();
                List<string> cityResults = newCityTaxRate.ResultStrListControl;
                cityResults[0].Replace(".", ",");
                double localTaxResults = Math.Round(double.Parse(cityResults[1], System.Globalization.CultureInfo.InvariantCulture), 5);
                try
                {
                    //convert and store the values inputted by the user
                    double hourlywageOrBaseSalary = formatToDouble(hourlyWageInput.Text);
                    double salary = formatToDouble(hourlyWageInput.Text);
                    double hoursWorked = 0.0;
                    if (HoursWorkedTextBox.Text != "")
                    {
                        hoursWorked = formatToDouble(HoursWorkedTextBox.Text);
                    }
                    int fedA = Int32.Parse(FederalAllowanceInput.Text);
                    int stateA = Int32.Parse(StateAllowanceInput.Text);
                    PaycheckCalcInitialize initializeCalculation = new PaycheckCalcInitialize(this.pythonEngineInstance, HourlyOrSalaried.Text, hourlywageOrBaseSalary, hoursWorked, is_employee, fedA, stateA,
                        localTaxResults, salary);
                    initializeCalculation.executeCalculation();
                    newOutputPaycheck.OutputControl = initializeCalculation.OutputControl;
                    //initializeCalculation.printParameters();
                    newOutputPaycheck.MainFormInstance = this;
                    //newOutputPaycheck.ShowDialog();
                    //send directly to printer
                    //newOutputPaycheck.PrintButton.PerformClick();
                    //button1_Click(sender, e);
                    newOutputPaycheck.PaycheckUIOutput_Load(sender, e);
                    newOutputPaycheck.PrintButton_Click(sender, e);

                }
                catch (System.FormatException Formaterror)
                {
                    MessageBox.Show("One or more fields has an invalid input. Please try again!", "Field Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                //TODO: maybe this could preplace the above?
                //may create an event for both buttons?
                //button1_Click(sender, e);
                //newOutputPaycheck.PaycheckUIOutput_Load(sender, e);
                //newOutputPaycheck.PrintButton_Click(sender, e);


            }
            catch (RuntimeBinderException binderError)
            {
                MessageBox.Show("An Invalid Zip code was entered. Please try again!", "Zip Code error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void configureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenConfig newGeneralConfig = new GenConfig();
            newGeneralConfig.ShowDialog();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About newAbout = new About();
            newAbout.ShowDialog();
        }

        private void licenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LicensingInfo newLicenseInfo = new LicensingInfo();
            newLicenseInfo.ShowDialog();
        }

        private void checkNumberInput_Click(object sender, EventArgs e)
        {
            checkNumberInput.Select(0, 1);
        }

        private void EmployerOrEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EmployerOrEmployee.Text == "Employer")
            {
                is_employee = false;
            }
            else
            {
                is_employee = true;
            }
        }
    }
}
