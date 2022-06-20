using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
//for storing printer and output path
namespace PaycheckAppUI
{
    public partial class GenConfig : Form
    {
        public GenConfig()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //get a list of all avaialble printers
            //source: https://stackoverflow.com/questions/2354435/how-to-get-the-list-of-all-printers-in-computer
            //author: Jojo Sardez
            //editor: Arvo Bowen 
            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                printersCombo.Items.Add(printer);
                
            }
            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                if (printer == Properties.Settings.Default.PrinterName)
                {
                    printersCombo.SelectedItem = printer;
                }
            }
            //lead the application path as the default output paycheck location
            outputLocationTextBox.Text = Properties.Settings.Default.OutputPath;
            this.Icon = Properties.Resources.SBPC_Logo;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BrowseOutputButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openFile = new FolderBrowserDialog();
            DialogResult result2 = openFile.ShowDialog();
            if (result2 == DialogResult.OK)
            {
                //get the string when the user selects a file path
                string outputStringFilePath = openFile.SelectedPath;
                //BusinessLogoPathInput.Text = outputStringFilePath;
                //add to text box
                outputLocationTextBox.Text = outputStringFilePath;
            }
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            ///Source: https://stackoverflow.com/questions/3036829/how-do-i-create-a-message-box-with-yes-no-choices-and-a-dialogresult
            ///Author: Mikael Svenson
            DialogResult choice = MessageBox.Show("Confirm Settings Changes", "Confirmation", MessageBoxButtons.YesNo);
            if (choice.Equals(DialogResult.Yes))
            {
                //overwrite changed settings
                Properties.Settings.Default.PrinterName = printersCombo.SelectedItem.ToString();
                Properties.Settings.Default.OuputPath= outputLocationTextBox.Text;
                Properties.Settings.Default.DefaultZipCode = defaultZipTextBox.Text;
                //Properties.Settings.Default["ShortDescription"] = ShortDescInput.Text;
                Properties.Settings.Default.Save(); // Saves settings in application configuration file
            }
            else
            {
                //do nothing
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            DialogResult choice = MessageBox.Show("Would you like to reset to default settings?", "Confirmation", MessageBoxButtons.YesNo);
            if (choice.Equals(DialogResult.Yes))
            {
                //overwrite changed settings
                Properties.Settings.Default.PrinterName = "empty";
                Properties.Settings.Default.OutputPath = "empty";
                Properties.Settings.Default.DefaultZipCode = "";
                Properties.Settings.Default.Save();
                DialogResult notify = MessageBox.Show("Default setting Have been restored. Please restart application.", "Alert");
            }
            else
            {
                //do nothing
            }
        }
    }
}
