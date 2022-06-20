using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PaycheckAppUI
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void AboutLabel_Click(object sender, EventArgs e)
        {

        }

        private void About_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.SBPC_Logo;

        }
    }
}
