using System;
using System.Collections.Generic;
using System.Text;

namespace PaycheckAppUI

{
    class hourlyOrSalariedComboInitialization
    {
        private List<string> _hourlyOrSalaried = new List<string> { };
        private string _payrollType;

        System.Windows.Forms.ComboBox MyComboBox;
        public hourlyOrSalariedComboInitialization()
        {
            this._payrollType = "";
        }
        public System.Windows.Forms.ComboBox ComboBoxControl
        {
            set { MyComboBox = value; }
            get { return MyComboBox; }
        }
        public string IsEmployeeInputControl
        {
            set
            {
                if (this._payrollType == "Hourly")
                {
                    _payrollType = "Hourly";
                }
                else if (this._payrollType == "Salaried")
                {
                    _payrollType = "Salaried";
                }
            }
            get { return _payrollType; }
        }
        //puts values in combo box
        public void fillItemsInComboBox()
        {
            _hourlyOrSalaried.Add("Hourly");
            _hourlyOrSalaried.Add("Salaried");
            foreach (string i in _hourlyOrSalaried)
            {
                MyComboBox.Items.Add(i);
            }
            //set default value
            MyComboBox.SelectedIndex = 0;


        }
    }
}
