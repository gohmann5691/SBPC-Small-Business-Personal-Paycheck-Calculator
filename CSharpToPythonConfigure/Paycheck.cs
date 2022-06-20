using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using Microsoft.Scripting.Debugging;
namespace CSharpToPythonConfigure
{
    public class Paycheck
    {
        private PaycheckClassInput PayCheckInputInstance;
        private OutputToUI PaycheckOutputInstance;
        private dynamic taxvaluesList;
        public Paycheck()
        {
            this.PayCheckInputInstance = new PaycheckClassInput();
            this.PaycheckOutputInstance = new OutputToUI();
            this.taxvaluesList = null;

        }
        public void copyInputsFromUIToPython(string PayrollType, double HourlyWage, double HoursWorked, bool Is_Employee, int Federal_Allowances,
            int State_Allowances, double CityTaxRate, double salary=0)
        {
            this.PayCheckInputInstance.PayrollTypeControl=PayrollType;
            this.PayCheckInputInstance.HourlyWageControl=HourlyWage;
            this.PayCheckInputInstance.HoursWorkedControl=HoursWorked;
            this.PayCheckInputInstance.Is_EmployeeControl=Is_Employee;
            this.PayCheckInputInstance.Federal_AllowancesControl= Federal_Allowances;
            this.PayCheckInputInstance.State_AllowancesControl=State_Allowances;
            this.PayCheckInputInstance.CityTaxRateControl= CityTaxRate;
            this.PayCheckInputInstance.SalaryControl = salary;
        }
        public void copyOutputsFromPython()
        {
            //Don't execute body if the tax values haven't been calculated
            if (this.taxvaluesList != null)
            {
                //Store Input variables

                this.PaycheckOutputInstance.PayrollTypeControl = this.PayCheckInputInstance.PayrollTypeControl;
                this.PaycheckOutputInstance.HourlyWageControl = this.PayCheckInputInstance.HourlyWageControl;
                this.PaycheckOutputInstance.HoursWorkedControl = this.PayCheckInputInstance.HoursWorkedControl;
                this.PaycheckOutputInstance.Is_EmployeeControl = this.PayCheckInputInstance.Is_EmployeeControl;
                this.PaycheckOutputInstance.Federal_AllowancesControl = this.PayCheckInputInstance.Federal_AllowancesControl;
                this.PaycheckOutputInstance.State_AllowancesControl = this.PayCheckInputInstance.State_AllowancesControl;
                this.PaycheckOutputInstance.CityTaxRateControl = this.PayCheckInputInstance.CityTaxRateControl;
                this.PaycheckOutputInstance.SalaryControl = this.PayCheckInputInstance.SalaryControl;
                //Store Output Variables
                this.PaycheckOutputInstance.FederalResultControl = this.taxvaluesList.FederalTaxAmount;
                this.PaycheckOutputInstance.StateResultControl = this.taxvaluesList.StateTaxAmount;
                this.PaycheckOutputInstance.MedicareResultControl = this.taxvaluesList.MedicareAmount;
                this.PaycheckOutputInstance.SSResultControl = this.taxvaluesList.SSAmount;
                this.PaycheckOutputInstance.CityResultControl = this.taxvaluesList.CityTaxAmount;
                this.PaycheckOutputInstance.GrossControl = this.taxvaluesList.GrossAmount;
                this.PaycheckOutputInstance.NetPayControl = this.taxvaluesList.NetPayAmount;
            }

        }
        public void executePythonMain(ScriptScope myScope)
        {
            dynamic PythonMain = myScope.GetVariable("PythonMain");
            dynamic MainPythonClass = PythonMain();
            if(MainPythonClass != null)
            {
                MainPythonClass.cSharpToPythonTest(PayCheckInputInstance);
                this.taxvaluesList = MainPythonClass.getPythonToCSharpExchangerObject();
            }
            
        }
        public dynamic getTaxResults()
        {
            return this.taxvaluesList;
        }
        public dynamic getResults()
        {
            return this.PaycheckOutputInstance;
        }
    }
}
