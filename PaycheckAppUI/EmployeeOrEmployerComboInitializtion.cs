using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
namespace PaycheckAppUI
{
    class EmployeeOrEmployerComboInitializtion
    {
        private List<string> _employeeOrEmployer = new List<string> { };
        private string userComboInputValue;
        bool isEmployee;

        System.Windows.Forms.ComboBox MyComboBox;
        public EmployeeOrEmployerComboInitializtion()
        {
            this.userComboInputValue = "";
        }
        public System.Windows.Forms.ComboBox ComboBoxControl
        {
            set { MyComboBox = value; }
            get { return MyComboBox; }
        }
        public bool IsEmployeeInputControl
        {
            set
            {
                if (this.userComboInputValue == "Employee")
                {
                    isEmployee = true;
                }
                else if (this.userComboInputValue == "Employer")
                {
                    isEmployee = false;
                }
            }
            get { return isEmployee; }
        }
        //puts values in combo box
        public void fillItemsInComboBox()
        {
            _employeeOrEmployer.Add("Employee");
            _employeeOrEmployer.Add("Employer");
            foreach (string i in _employeeOrEmployer)
            {
                MyComboBox.Items.Add(i);
            }
            //set default value
            MyComboBox.SelectedIndex = 0;


        }



    }
}
