using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using PdfiumViewer;
using System.Drawing.Printing;

namespace PaycheckOutputAndPrinting
{
    public class DocumentPrinter
    {
        private string printer;
        private string paperName;
        private string fileName;
        private int copies;
        public DocumentPrinter(string printerInput, string paperNameInput, string fileNameInput, int copiesInput=1)
        {
            this.printer = printerInput;
            this.paperName = paperNameInput;
            this.fileName = fileNameInput;
            this.copies = copiesInput;
        }
        public void listPrinters()
        {
            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                Console.WriteLine(printer);
            }
        }
        public void getDeafultPrinter()
        {
            PrinterSettings settings = new PrinterSettings();
        }
        /// <summary>
        /// This method was derived from the following:
        /// https://stackoverflow.com/questions/6103705/how-can-i-send-a-file-document-to-the-printer-and-have-it-print
        /// Author: Kendall Bennett ~ https://stackoverflow.com/users/443943/kendall-bennett
        /// </summary>
        /// <returns></returns>
        public string PrintPDF()
         {
            try
            {
                // Create the printer settings for our printer
                var printerSettings = new PrinterSettings()
                {
                    PrinterName = printer,
                    Copies = (short)copies,
                };

                // Create our page settings for the paper size selected
                var pageSettings = new PageSettings(printerSettings)
                {
                    Margins = new Margins(0, 0, 0, 0),
                };
                foreach (PaperSize paperSize in printerSettings.PaperSizes)
                {
                    if (paperSize.PaperName == paperName)
                    {
                        
                        pageSettings.PaperSize = paperSize;
                        break;
                    }
                }

                // Now print the PDF document
                using (var document = PdfDocument.Load(fileName))
                {
                    using (var printDocument = document.CreatePrintDocument())
                    {
                        printDocument.PrinterSettings = printerSettings;
                        printDocument.DefaultPageSettings = pageSettings;
                        printDocument.PrintController = new StandardPrintController();
                        printDocument.Print();
                    }
                }
                return "worked!";
            }
            catch(Exception e)
            {
                return e.ToString();
            }
        }
    }
}
