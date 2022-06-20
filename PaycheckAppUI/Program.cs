using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace PaycheckAppUI
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //create new form object
            PaycheckCalcMainWindow mainForm = new PaycheckCalcMainWindow();
            mainForm.BackColor = Color.LightGray;
            Application.Run(mainForm);
        }
    }
}
