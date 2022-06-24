using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpToPythonConfigure
{
    public class PaycheckStaticParam
    {
        //The contents of this object are not sent to the python backend
        //static input variables
        private string date;
        private string fullName;
        private decimal checkNumber;
        private string zipCode;
        //used for outputting paycheck file name(gets rid of all spaces)
        private string employeeFileName;

        public PaycheckStaticParam(string dateInput, string fullNameInput, decimal checkNumberInput, string zipCodeinput)
        {
            this.date = dateInput;
            this.fullName = fullNameInput;
            this.checkNumber = checkNumberInput;
            this.zipCode = zipCodeinput;
            this.employeeFileName = fullName.Replace(' ', '_');
        }
        public string Date
        {
            get { return date; }
            set { this.date = value; }
        }
        public string FullName
        {
            get { return fullName; }
            set { this.fullName = value; }
        }
        public string ZipCode
        {
            get { return zipCode; }
            set { this.zipCode = value; }
        }
        public decimal CheckNumber
        {
            get { return checkNumber; }
            set { this.checkNumber = value; }
        }
        public string EmployeeFileName
        {
            get { return employeeFileName; }
            set { this.employeeFileName = value; }
        }
    }
}
