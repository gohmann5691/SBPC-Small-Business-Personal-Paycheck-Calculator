using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpToPythonConfigure
{
    public class PaycheckClassInput
    {
        private string payrollType;
        private double hourlyWage;
        private double hoursWorked;
        private bool is_Employee;
        private int federal_Allowances;
        private int state_Allowances;
        private double cityTaxRate;
        private double salary;
        public PaycheckClassInput()
        {
            hourlyWage = 0.0;
            hoursWorked = 0.0;
            salary = 0.0;
        }

        public string PayrollTypeControl
        {
            get { return payrollType; }
            set { payrollType = value; }
        }
        public double HourlyWageControl
        {
            get { return hourlyWage; }
            set { hourlyWage = value; }
        }
        public double HoursWorkedControl
        {
            get { return hoursWorked; }
            set { hoursWorked = value; }
        }
        public bool Is_EmployeeControl
        {
            get { return is_Employee; }
            set { is_Employee = value; }
        }
        public int Federal_AllowancesControl
        {
            get { return federal_Allowances; }
            set { federal_Allowances = value; }
        }
        public int State_AllowancesControl
        {
            get { return state_Allowances; }
            set { state_Allowances = value; }
        }
        public double CityTaxRateControl
        {
            get { return cityTaxRate; }
            set { cityTaxRate = value; }
        }
        public double SalaryControl
        {
            get { return salary; }
            set { salary = value; }
        }
    }
}
