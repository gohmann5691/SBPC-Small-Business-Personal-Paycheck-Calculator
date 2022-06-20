using System;
using System.Collections.Generic;
using System.Text;
using CSharpToPythonConfigure;
using System.Diagnostics;
namespace PaycheckAppUI
{
    class PaycheckCalcInitialize
    {
        private PythonEngineBackend pythonEngineInstance;
        private Paycheck NewPayCheck;
        private OutputToUI output;
        private string payrollType;
        private double hourlyWage;
        private double hoursWorked;
        private bool is_Employee;
        private int federalAllowances;
        private int stateAllowances;
        private double cityTaxRate;
        private double salary;
        //private cSharpIronPythonConfigure.P
        //grab the scope of the current python engine
        //cSharpIronPythonConfigure.
        public PaycheckCalcInitialize(PythonEngineBackend myEngine,string payrollTypeInput, double hourlyWageInput, double hoursWorkedInput,
            bool isEmployeeInput, int fedAllowancesInput, int stateAllowancesInput, double cityTaxRateInput,  double salaryInput)
        {
            this.pythonEngineInstance = myEngine;
            this.NewPayCheck = new Paycheck();
            this.output = new OutputToUI();
            this.payrollType = payrollTypeInput;
            this.hourlyWage = hourlyWageInput;
            this.hoursWorked = hoursWorkedInput;
            this.is_Employee = isEmployeeInput;
            this.federalAllowances = fedAllowancesInput;
            this.stateAllowances = stateAllowancesInput;
            this.cityTaxRate = cityTaxRateInput;
            this.salary = salaryInput;
        }
        private void passInputsFromUI()
        {
            this.NewPayCheck.copyInputsFromUIToPython(payrollType, hourlyWage, hoursWorked, 
                is_Employee, federalAllowances, stateAllowances, cityTaxRate, salary);

        }
        private void passOutputToUI()
        {
            this.NewPayCheck.copyOutputsFromPython();
        }
        public void executeCalculation()
        {
            passInputsFromUI();
            this.NewPayCheck.executePythonMain(pythonEngineInstance.ScopeControl);
            dynamic PaycheckResults = NewPayCheck.getTaxResults();
            passOutputToUI();
            this.output = NewPayCheck.getResults();

        }
        //used for debugging only
        /*
        public void printParameters()
        {
            Debug.WriteLine(output.PayrollTypeControl);
            Debug.WriteLine(output.HourlyWageControl);
            Debug.WriteLine(output.HoursWorkedControl);
            Debug.WriteLine(output.Is_EmployeeControl);
            Debug.WriteLine(output.SalaryControl);
            Debug.WriteLine(output.Federal_AllowancesControl);
            Debug.WriteLine(output.State_AllowancesControl);
            Debug.WriteLine(output.CityTaxRateControl);
            //
            Debug.WriteLine(output.FederalResultControl);
            Debug.WriteLine(output.StateResultControl);
            Debug.WriteLine(output.MedicareResultControl);
            Debug.WriteLine(output.SSResultControl);
            Debug.WriteLine(output.CityResultControl);
            Debug.WriteLine(output.NetPayControl);
        }
        */
        //used to get the output
        public OutputToUI OutputControl
        {
            get { return this.output; }
        }
    }
}
