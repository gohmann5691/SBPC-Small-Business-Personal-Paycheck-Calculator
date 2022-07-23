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
            OutputPaycheckControl PaycheckOutput = new OutputPaycheckControl(outputText, StaticParamIsntance.EmployeeFileName, Properties.Settings.Default.OutputPath);
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
            if (newPrinter.PrintPDF()==false)
            {
                MessageBox.Show("Printing failed, try changing default printer or contact support");
            }
        }
        //test button for saving paycheck to pdf
        private void SaveOnlyButon_Click(object sender, EventArgs e)
        {
            OutputPaycheckControl PaycheckOutput = new OutputPaycheckControl(outputText, StaticParamIsntance.EmployeeFileName, Properties.Settings.Default.OutputPath);
            PaycheckOutput.CheckForOutputDirectory();
            PaycheckOutput.lookThroughDirectories();
            //PaycheckOutput.WriteTextOutToPdf(companyLogoBox, companyNameLabel, Properties.Settings.Default.ShortDescription, 
            //    MainFormInstance.paycheckDateInput.Value.ToString("MM-dd-yyyy"));
            PaycheckOutput.WriteTextOutToPdf(companyLogoBox, companyNameLabel, Properties.Settings.Default.ShortDescription,
                StaticParamIsntance.Date);
            DialogResult notify = MessageBox.Show("Paycheck Saved to PDF!", "Success!");
        }
        /// <summary>
        /// /Source: Stack overflow --- https://stackoverflow.com/questions/18966407/enable-copy-cut-past-window-in-a-rich-text-box
        /// /Author: Thilina H --- https://stackoverflow.com/users/894801/thilina-h
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void outputText_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {   //click event
                ContextMenu contextMenu = new ContextMenu();
                MenuItem menuItem = new MenuItem("Cut");
                menuItem.Click += new EventHandler(CutAction);
                contextMenu.MenuItems.Add(menuItem);
                menuItem = new MenuItem("Copy");
                menuItem.Click += new EventHandler(CopyAction);
                contextMenu.MenuItems.Add(menuItem);
                menuItem = new MenuItem("Paste");
                menuItem.Click += new EventHandler(PasteAction);
                contextMenu.MenuItems.Add(menuItem);

                outputText.ContextMenu = contextMenu;
            }
            
        }
        void CutAction(object sender, EventArgs e)
        {
            outputText.Cut();
        }

        void CopyAction(object sender, EventArgs e)
        {
            Clipboard.SetText(outputText.SelectedText);
        }

        void PasteAction(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                outputText.Text
                    += Clipboard.GetText(TextDataFormat.Text).ToString();
            }
        }

        public PaycheckStaticParam StaticParamIsntance { get; set; }
        public OutputToUI OutputControl { get; set; }

        
    }
}
