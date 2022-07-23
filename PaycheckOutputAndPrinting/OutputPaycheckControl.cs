using System;
using System.Windows;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Drawing;
//using System.Drawing
using System.Drawing.Imaging;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp;
using System.Diagnostics;
//add forms to get image box datatype
using System.Windows.Forms;

namespace PaycheckOutputAndPrinting
{
    public class OutputPaycheckControl
    {
        //used as the default if the user doesn't specify in settings
        private string applicationDirectory=Application.StartupPath;
        private List<string> outputString= new List<string>();
        //private string outputPath;
        //set the working directory to save paycheck
        private string workingDirectory;
        private string paycheckPrintDirectory=null;
        private RichTextBox outputText;
        private string employeeName;
        //used to store the path to print out the doucment
        private string printingPath;
        //used to change the pdf font
        private int pdfFontSize;
        public OutputPaycheckControl(RichTextBox RTFParameter, string employeeNameInput, string workingDirectoryInput="", int pdfFontSizeInput=12)
        {
            this.outputText = RTFParameter;
            this.employeeName = employeeNameInput;
            this.pdfFontSize = pdfFontSizeInput;
            if (workingDirectoryInput == "")
            {
                this.workingDirectory = applicationDirectory;
            }
            else
            {
                this.workingDirectory = workingDirectoryInput;
            }
        }
        public string WorkingDirectory
        {
            set { this.workingDirectory = value; }
            get { return this.workingDirectory; }
        }
        //create the output directory if it doesn't already exist
        public void CheckForOutputDirectory()
        {
            bool fileExists = false;

            //get all the directories in the user's specified path
            string[] directories = Directory.GetDirectories(this.workingDirectory);
            //check to see if an output folder already exists
            foreach(string i in directories){
                if(i == "Paycheck_Output")
                {
                    this.workingDirectory = this.workingDirectory + @"\" + i+ @"\";
                    fileExists = true;
                }
            }
            //if the folder doesn't exist, create it!
            if (fileExists == false)
            {
                Directory.CreateDirectory(this.workingDirectory + @"\Paycheck_Output");
                this.workingDirectory = this.workingDirectory + @"\Paycheck_Output\";
            }
        }
        public void WriteTextOutToPdf(dynamic companyLogoBox, dynamic CompanyNameLabel, string description, string date="00-00-0000")
        {
            if(paycheckPrintDirectory != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    companyLogoBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                    byte[] buff = ms.GetBuffer();
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 15);
                    PdfWriter.GetInstance(pdfDoc, new FileStream(this.paycheckPrintDirectory + @"\" +employeeName+date+".pdf", FileMode.Create));
                    //store the pdf path for printing later
                    PrintPaycheckPathControl = this.paycheckPrintDirectory + @"\" + employeeName + date + ".pdf";
                    pdfDoc.Open();

                    //add title
                    var titleFont = FontFactory.GetFont("Segoe UI", 24, iTextSharp.text.Font.UNDERLINE, BaseColor.BLACK);
                    Paragraph title = new Paragraph(CompanyNameLabel.Text, titleFont);
                    pdfDoc.Add(title);
                    //add sub description
                    var descFont = FontFactory.GetFont("Segoe UI", 15, iTextSharp.text.Font.ITALIC, BaseColor.BLACK);
                    Paragraph desc = new Paragraph(description, descFont);
                    pdfDoc.Add(desc);
                    iTextSharp.text.Image myLogo = iTextSharp.text.Image.GetInstance(buff);
                    //System
                    myLogo.PaddingTop=30;
                    myLogo.SetAbsolutePosition(25, 550);
                    pdfDoc.Add(myLogo);
                    //add in text from rich text box
                    StringFromRichTextBox(this.outputText, pdfDoc);
                    pdfDoc.Close();
                }
            }
        }
        private void StringFromRichTextBox(RichTextBox rtb, Document pdfdoc)
        {
            var bodyFont = FontFactory.GetFont("Segoe UI", this.pdfFontSize,  BaseColor.BLACK);
            //TODO: improve image formatting when rendering to the PDF
            for (int i = 0; i < 15; i++)
            {
                Paragraph imagefit = new Paragraph(""+'\n');
                pdfdoc.Add(imagefit);
            }
            var lines = rtb.Text.Split('\n');
            foreach (var line in lines)
            {
                //Debug.WriteLine(line);
                if (line == "Deductions: ")
                {
                    var deductionSubtitleFont= FontFactory.GetFont("Segoe UI", this.pdfFontSize + 4, iTextSharp.text.Font.UNDERLINE, BaseColor.BLACK);
                    Paragraph deductions = new Paragraph(line, deductionSubtitleFont);
                    pdfdoc.Add(deductions);
                }
                else
                {
                    Paragraph body = new Paragraph(line, bodyFont);

                    pdfdoc.Add(body);  
                }
                
            }
        }
        public void lookThroughDirectories()
        {
            string folderPath = this.workingDirectory;
            string[] files = Directory.GetDirectories(folderPath);
            printOutDirectories(files);
        }
        public void printOutDirectories(string[] files)
        {
            foreach(string i in files)
            {
                //Console.WriteLine(i);
                if(workingDirectory + this.employeeName == i)
                {
                    this.paycheckPrintDirectory = workingDirectory + @"\"+ this.employeeName;
                    break;
                }
            }
            if (paycheckPrintDirectory == null)
            {
                Directory.CreateDirectory(workingDirectory + this.employeeName);
                this.paycheckPrintDirectory = workingDirectory + this.employeeName;
            }
        }
        public string PrintPaycheckPathControl
        {
            set { printingPath=value; }
            get { return printingPath; }
        }




    }
}
