using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using CSharpToPythonConfigure;
namespace PaycheckOutputAndPrinting
{
    public class RTFWriter
    {
        /// <summary>
        /// public RTFWriter(RichTextBox inputRichTextBox,string dateInput, string fullNameInput, decimal checkNumInput, string payrollTypeInput,
        /// string hoursWorkedInput, string hourlyWageInput, string zipCodeInput, OutputToUI outputInput)
        /// </summary>
        private RichTextBox myRichTextBox;
        //private PaycheckCalcMainWindow mainFormInstance;
        //metrics pulled from main form
        private string date;
        private string fullName;
        private decimal checkNum;
        private string zipCode;
        //paycheck output storage class will write most of the info out to the RTF
        private OutputToUI output;
        public RTFWriter(RichTextBox inputRichTextBox,string dateInput, string fullNameInput, decimal checkNumInput,  string zipCodeInput, OutputToUI outputInput)
        {
            this.myRichTextBox = inputRichTextBox;
            this.date = dateInput;
            this.fullName = fullNameInput;
            this.checkNum = checkNumInput;
            this.zipCode = zipCodeInput;
            this.output = outputInput;
        }
        public void writeToRTF()
        {
            //OutputText.SelectionFont = new Font("Segoe UI", 25, FontStyle.Underline);
            myRichTextBox.Text = "Paycheck for " + date;
            myRichTextBox.Text += '\n';
            myRichTextBox.Text += "Employee Full Name: " + fullName;
            myRichTextBox.Text += '\n';
            myRichTextBox.Text += "Check Number: " + checkNum;
            myRichTextBox.Text += '\n';
            myRichTextBox.Text += "Payroll type: " + output.PayrollTypeControl;
            myRichTextBox.Text += '\n';
            //if else statment here
            if (output.PayrollTypeControl == "Hourly")
            {
                myRichTextBox.Text += "Hours Worked: " + output.HoursWorkedControl;
                myRichTextBox.Text += '\n';
                myRichTextBox.Text += "Hourly Wage: " + output.HourlyWageControl;
                myRichTextBox.Text += '\n';
                myRichTextBox.Text += "Gross Pay: " + output.GrossControl;
                myRichTextBox.Text += '\n';
            }
            else
            {
                myRichTextBox.Text += "Salary: " + output.SalaryControl;
                myRichTextBox.Text += '\n';
                myRichTextBox.Text += "Gross Pay: " + output.GrossControl;
                myRichTextBox.Text += '\n';

            }
            myRichTextBox.Text += "Net Pay: " + output.NetPayControl.ToString("0.00");
            myRichTextBox.Text += '\n';
            myRichTextBox.Text += "Zip Code: " + zipCode;
            myRichTextBox.Text += '\n';
            myRichTextBox.Text += "Federal Allowances: " + output.Federal_AllowancesControl;
            myRichTextBox.Text += '\n';
            myRichTextBox.Text += "State Allowances: " + output.State_AllowancesControl;
            myRichTextBox.Text += '\n';
            myRichTextBox.Text += "Deductions: ";

            myRichTextBox.Text += '\n';
            myRichTextBox.Text += "Federal Tax: " + output.FederalResultControl.ToString("0.00");
            myRichTextBox.Text += '\n';
            myRichTextBox.Text += "State Income Tax: " + output.StateResultControl.ToString("0.00");
            myRichTextBox.Text += '\n';
            myRichTextBox.Text += "Social Security Tax: " + output.SSResultControl.ToString("0.00");
            myRichTextBox.Text += '\n';
            myRichTextBox.Text += "Medicare Tax: " + output.MedicareResultControl.ToString("0.00");
            myRichTextBox.Text += '\n';
            myRichTextBox.Text += "City Tax: " + output.CityResultControl.ToString("0.00");

            myRichTextBox.Select(myRichTextBox.Find("Deductions"), 10);
            myRichTextBox.SelectionFont = new System.Drawing.Font("Segoe UI", 30, FontStyle.Underline);
            myRichTextBox.DeselectAll();


        }
        public RichTextBox RichTextBoxPreview
        {
            set { myRichTextBox = value; }
            get { return myRichTextBox; }
        }
        
    }
}
