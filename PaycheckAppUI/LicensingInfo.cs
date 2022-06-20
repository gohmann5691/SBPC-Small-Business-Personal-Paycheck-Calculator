using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PaycheckAppUI
{
    public partial class LicensingInfo : Form
    {
        public LicensingInfo()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LicensingInfo_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.SBPC_Logo;
            licensingRTF.ReadOnly = true;
        }
    }
}
