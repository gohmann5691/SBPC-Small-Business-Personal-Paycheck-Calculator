using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
//used for getting the file extensions
using System.IO;
namespace PaycheckAppUI
{
    public partial class BusinessInfoConfig : Form
    {
        public BusinessInfoConfig()
        {
            InitializeComponent();
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            DialogResult result2 = openFile.ShowDialog();
            if (result2 == DialogResult.OK)
            {
                //get the string when the user selects a file path
                string outputStringFilePath = openFile.FileName;
                businessLogoPathInput.Text = outputStringFilePath;

            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            ///Source: https://stackoverflow.com/questions/3036829/how-do-i-create-a-message-box-with-yes-no-choices-and-a-dialogresult
            ///Author: Mikael Svenson
            DialogResult choice = MessageBox.Show("Confirm Settings Changes", "Confirmation", MessageBoxButtons.YesNo);
            if (choice.Equals(DialogResult.Yes))
            {
                string filePath = businessLogoPathInput.Text;
                if (Path.GetExtension(filePath)== ".png"|| Path.GetExtension(filePath)==".jpg")
                {

                    //overwrite changed settings
                    Properties.Settings.Default["ImagePath"] = filePath;
                    Properties.Settings.Default["CompanyName"] = setNameInput.Text;
                    Properties.Settings.Default["ShortDescription"] = shortDescInput.Text;
                    Properties.Settings.Default.Save(); // Saves settings in application configuration file
                    this.Close(); // close after successfuly applying settings
                }
                else
                {
                    DialogResult notify = MessageBox.Show("Invalid Image Format! Settings were unchanged. " +
                    "Accpeted image types are .png and .jpg", "Alert");
                }
            }
            else
            {
                //do nothing
            }
        }

        private void BusinessInfoConfig_Load(object sender, EventArgs e)
        {
            //show settings pre-set in text boxes
            businessLogoPathInput.Text = Properties.Settings.Default.ImagePath;
            setNameInput.Text= Properties.Settings.Default.CompanyName;
            shortDescInput.Text = Properties.Settings.Default.ShortDescription;
            this.Icon = Properties.Resources.SBPC_Logo;

        }

        private void ResetBusinessSettButton_Click(object sender, EventArgs e)
        {
            DialogResult choice = MessageBox.Show("Would you like to reset to default settings?", "Confirmation", MessageBoxButtons.YesNo);
            if (choice.Equals(DialogResult.Yes))
            {
                //overwrite changed settings
                Properties.Settings.Default.ImagePath = "empty";
                Properties.Settings.Default.CompanyName = "";
                Properties.Settings.Default.ShortDescription = "";
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
