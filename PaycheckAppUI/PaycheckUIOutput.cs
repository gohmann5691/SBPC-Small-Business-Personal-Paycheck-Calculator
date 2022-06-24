using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
//used for printing
using System.Drawing.Printing;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using iTextSharp;
using System.Diagnostics;
using CSharpToPythonConfigure;
using PaycheckOutputAndPrinting;
namespace PaycheckAppUI
{
    public partial class PaycheckUIOutput : Form
    {
        //TODO: might use these to avoid using the getter and setter multiple times
        private OutputToUI outputToUI= null;
        private PaycheckStaticParam statParam= null;

        public PaycheckUIOutput()
        {

            InitializeComponent();

        }
        public void PaycheckUIOutput_Load(object sender, EventArgs e)
        {
            //format image for output
            ImageInsertFormatter NewImageResize = new ImageInsertFormatter(Properties.Settings.Default.ImagePath);
            NewImageResize.FormatImage();
            //set default Copy number
            numericPrinterCopies.Value = Properties.Settings.Default.PrintCopies;
            //add approach text to the Label
            companyNameLabel.Text = Properties.Settings.Default.CompanyName;
            //append to image box
            companyLogoBox.Image = NewImageResize.BitmappedImage;
            //write output to RTF
            //RTFWriter newOutputWriter = new RTFWriter(outputText, MainFormInstance.paycheckDateInput.Value.ToString("MM-dd-yyyy"),
            //    MainFormInstance.firstNameInput.Text + " " + MainFormInstance.lastNameInput.Text, MainFormInstance.checkNumberInput.Value,
            //    MainFormInstance.ZipCodeTextBox.Text, OutputControl);
            RTFWriter newOutputWriter = new RTFWriter(outputText, StaticParamIsntance.Date,
                StaticParamIsntance.FullName, StaticParamIsntance.CheckNumber, StaticParamIsntance.ZipCode, OutputControl);
            newOutputWriter.writeToRTF();
            this.Icon = Properties.Resources.SBPC_Logo;
        }

        public void PrintButton_Click(object sender, EventArgs e)
        {
            OutputPaycheckControl PaycheckOutput = new OutputPaycheckControl(outputText, StaticParamIsntance.EmployeeFileName, Properties.Settings.Default.OuputPath);
            PaycheckOutput.CheckForOutputDirectory();
            PaycheckOutput.lookThroughDirectories();
            //PaycheckOutput.WriteTextOutToPdf(companyLogoBox, companyNameLabel, Properties.Settings.Default.ShortDescription,
            //    MainFormInstance.paycheckDateInput.Value.ToString("MM-dd-yyyy"));
            PaycheckOutput.WriteTextOutToPdf(companyLogoBox, companyNameLabel, Properties.Settings.Default.ShortDescription,
               StaticParamIsntance.Date);
            string paperSizeI = "A4";
            string printFilePath = PaycheckOutput.PrintPaycheckPathControl;
            int enteredCopies = (int)numericPrinterCopies.Value;
            DocumentPrinter newPrinter = new DocumentPrinter(Properties.Settings.Default.PrinterName, paperSizeI, printFilePath, enteredCopies);
            newPrinter.PrintPDF();
        }
        //test button for saving paycheck to pdf
        private void SaveOnlyButon_Click(object sender, EventArgs e)
        {
            OutputPaycheckControl PaycheckOutput = new OutputPaycheckControl(outputText, StaticParamIsntance.EmployeeFileName, Properties.Settings.Default.OuputPath);
            PaycheckOutput.CheckForOutputDirectory();
            PaycheckOutput.lookThroughDirectories();
            //PaycheckOutput.WriteTextOutToPdf(companyLogoBox, companyNameLabel, Properties.Settings.Default.ShortDescription, 
            //    MainFormInstance.paycheckDateInput.Value.ToString("MM-dd-yyyy"));
            PaycheckOutput.WriteTextOutToPdf(companyLogoBox, companyNameLabel, Properties.Settings.Default.ShortDescription,
                StaticParamIsntance.Date);
            DialogResult notify = MessageBox.Show("Paycheck Saved to PDF!", "Success!");
        }
        public PaycheckStaticParam StaticParamIsntance { get; set; }
        public OutputToUI OutputControl { get; set; }

    }
}
