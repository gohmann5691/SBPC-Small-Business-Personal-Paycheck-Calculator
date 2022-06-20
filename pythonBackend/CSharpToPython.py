'''
variables passed from cSharp;
-Hourly wage (if applicable)
-Hours worked (if applicable)
-Salary amount (if applicable)
-isEmployee
-federalAllowances
-stateAllowances
-cityTaxRate
'''
class CSharpToPythonExhanger():
    def __init__(self):
        self._hourlyWage=0.0
        self._hoursWorked=0.0
        self._salaryAmount=0.0
        self._isEmployee=None
        self._federalAllowances=0
        self._stateAllowances=0
        self._cityTaxRate=0
        self._payrollType=None
    #getter and setter for hourly wage
    @property
    def HourlyWage(self):
        return self._hourlyWage
    @HourlyWage.setter
    def HourlyWage(self, hW):
        if isinstance(hW, int) or isinstance(hW, float):
            self._hourlyWage=hW
        else:
            raise ValueError("Not a Valid Entry!")
    #getter and setter for hours worked
    @property
    def HoursWorked(self):
        return self._hoursWorked
    @HoursWorked.setter
    def HoursWorked(self, hWK):
        if isinstance(hWK, int) or isinstance(hWK, float):
            self._hoursWorked=hWK
        else:
            raise ValueError("Not a Valid Entry for hours worked!")
    #getter and setter for fixed salary amount
    @property
    def FixedSalary(self):
        return self._salaryAmount
    @FixedSalary.setter
    def FixedSalary(self, fS):
        if isinstance(fS, int) or isinstance(fS, float):
            self._salaryAmount=fS
        else:
            raise ValueError("Not a Valid Entry for fixed salary!")
    #getter and setter for isEmployee
    @property
    def Is_Employee(self):
        return self._isEmployee
    @Is_Employee.setter
    def Is_Employee(self, iE):
        if isinstance(iE, bool):
            self._isEmployee=iE
        else:
            raise ValueError("Not a Valid Entry for isEmpoloyee")
    @property
    def Federal_Allowances(self):
        return self._federalAllowances
    @Federal_Allowances.setter
    def Federal_Allowances(self, fA):
        if isinstance(fA, int) and fA>=0 and fA <= 5:
            self._federalAllowances=fA
        else:
            raise ValueError("Not a Valid Entry for federal allowance")
    @property
    def State_Allowances(self):
        return self._federalAllowances
    @State_Allowances.setter
    def State_Allowances(self, sA):
        if isinstance(sA, int) and sA>=0 and sA <= 5:
            self._federalAllowances=sA
        else:
            raise ValueError("Not a Valid Entry for state allowance")
    @property
    def CityTaxRate(self):
        return self._cityTaxRate
    @CityTaxRate.setter
    def CityTaxRate(self, ctr):
        if isinstance(ctr, float) and ctr>=0 and ctr < 1:
            self._cityTaxRate=ctr
        else:
            raise ValueError("Not a Valid Entry for city tax rate")
    @property
    def PayrollType(self):
        return self._payrollType
    @PayrollType.setter
    def PayrollType(self, pT):
        if isinstance(pT, str) and (pT=="Hourly" or pT == "Salaried"):
            self._payrollType=pT
        else:
            raise ValueError("Not a Valid Entry for PayrollType")
    @property
    def GrossAmount(self):
        return self._returnGross
    @GrossAmount.setter
    def GrossAmount(self, ga):
        if isinstance(ga, int) or isinstance(ga, float):
            self._returnGross=ga
        else:
            raise ValueError("Not a Valid Entry!")
    @property
    def FederalTaxAmount(self):
        return self._returnFederalTax
    @FederalTaxAmount.setter
    def FederalTaxAmount(self, fta):
        if isinstance(fta, int) or isinstance(fta, float):
            self._returnFederalTax=fta
        else:
            raise ValueError("Not a Valid Entry!")
    @property
    def StateTaxAmount(self):
        return self._returnStateAmount
    @StateTaxAmount.setter
    def StateTaxAmount(self, sta):
        if isinstance(sta, int) or isinstance(sta, float):
            self._returnStateAmount=sta
        else:
            raise ValueError("Not a Valid Entry!")
    @property
    def MedicareAmount(self):
        return self._returnStateAmount
    @MedicareAmount.setter
    def MedicareAmount(self, ma):
        if isinstance(ma, int) or isinstance(ma, float):
            self._returnStateAmount=ma
        else:
            raise ValueError("Not a Valid Entry!")
    @property
    def SSAmount(self):
        return self._returnStateAmount
    @SSAmount.setter
    def SSAmount(self, ssa):
        if isinstance(ssa, int) or isinstance(ssa, float):
            self._returnStateAmount=ssa
        else:
            raise ValueError("Not a Valid Entry!")
    @property
    def CityTaxAmount(self):
        return self._returnCityAmount
    @SSAmount.setter
    def CityTaxAmount(self, cta):
        if isinstance(cta, int) or isinstance(cta, float):
            self._returnCityAmount=cta
        else:
            raise ValueError("Not a Valid Entry!")
    @property
    def NetPayAmount(self):
        return self._returnStateAmount
    @NetPayAmount.setter
    def NetPayAmount(self, na):
        if isinstance(na, int) or isinstance(na, float):
            self._returnStateAmount=na
        else:
            raise ValueError("Not a Valid Entry!")
