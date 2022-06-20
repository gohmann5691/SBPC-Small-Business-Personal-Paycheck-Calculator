from CSharpToPython import CSharpToPythonExhanger
from PaycheckType import PaycheckType
#import sys
class PythonMain():
    def __init__ (self):
        self.resultsArray=None
    #entry point from c#
    def cSharpToPythonTest(self, transferFromCSharp):
        transfer=CSharpToPythonExhanger()
        transfer.PayrollType=transferFromCSharp.PayrollTypeControl
        transfer.hourlyWage=transferFromCSharp.HourlyWageControl
        transfer.hoursWorked= transferFromCSharp.HoursWorkedControl
        transfer.is_Employee=transferFromCSharp.Is_EmployeeControl
        transfer.federal_Allowances=transferFromCSharp.Federal_AllowancesControl
        transfer.state_Allowances=transferFromCSharp.State_AllowancesControl
        transfer.CityTaxRate=transferFromCSharp.CityTaxRateControl
        transfer.FixedSalary=transferFromCSharp.SalaryControl
        #print(transferFromCSharp.SalaryControl)
        check=PaycheckType(transfer.PayrollType, transfer.hourlyWage, transfer.hoursWorked,
                           transfer.is_Employee,transfer.federal_Allowances, transfer.state_Allowances,
                           transfer.CityTaxRate, transfer.FixedSalary)
        check.determinePaycheckCalc()
        self.resultsArray=check.returnArrayValues()
        self.transfer=transfer
        self.transfer=self.appendArrayToTransferClass(self.transfer)
    def appendArrayToTransferClass(self, transfer):
        transfer.GrossAmount=self.resultsArray[0]
        transfer.FederalTaxAmount=self.resultsArray[1]
        transfer.StateTaxAmount=self.resultsArray[2]
        transfer.SSAmount=self.resultsArray[3]
        transfer.MedicareAmount=self.resultsArray[4]
        transfer.CityTaxAmount=self.resultsArray[5]
        transfer.NetPayAmount=self.resultsArray[6]
        return transfer
    def getPythonToCSharpExchangerObject(self):
        return self.transfer




    
