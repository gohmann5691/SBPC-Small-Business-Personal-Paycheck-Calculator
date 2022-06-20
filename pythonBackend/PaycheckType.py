#import warnings
from HourlyPayRate import HourlyPayRate
from FederalIncomeTax import FederalIncomeTax
from StateIncomeTax import StateIncomeTax
from SocialSecurityTax import SocialSecurityTax
from MedicareTax import MedicareTax
from CityTax import CityTax
from SalaryPay import SalaryPay
class PaycheckType():
    def __init__(self, payrollType,hourlyWage, hoursWorked,
                 isEmployee, federalAllowances, stateAllowances,
                 cityTaxRate, salaryAmount):
        self.payrollType=payrollType
        self.hourlyWage=hourlyWage
        self.salaryAmount=salaryAmount
        self.hoursWorked=hoursWorked
        self.salaryAmount=salaryAmount
        self.isEmployee=isEmployee
        self.federalAllowances=federalAllowances
        self.stateAllowances=stateAllowances
        self.cityTaxRate=cityTaxRate
        self.listOfReturnValues=[]
        #self.netPayAmount=0.0
        #set up instances for paycheck
        self.FederalInstance=None
        self.StateInstance=None
        self.SSInstance=None
        self.MedicareInstance=None
        self.CityInstance=None
        #Convert to Dictionary at Some point
        #self.listOfReturnValues={"federal":0.0,"state":0.0, "socialSecurity":0.0, "Medicare":0.0,
        #                         "City":0.0}
    def determinePaycheckCalc(self):
        if self.payrollType == "Hourly":
            self.executeHourlyPaycheck()
        elif self.payrollType=="Salaried":
            #print("paycheck Salaried YAY")
            self.executeSalariedPaycheck()
        else:
            #no valid payroll type
            self.listOfReturnValues=[0,0,0,0,0,0,0]
            #warnings.warn("Warning paycheck type not found!")
    def executeHourlyPaycheck(self):
        newHourlyPaycheck=self.createNewHourlyPaycheck()
        self.initializePaycheckInstances(newHourlyPaycheck)
        #store them in an array
        self.listOfReturnValues.append(newHourlyPaycheck.getGross())
        self.FederalInstance.setFederalTax(self.FederalInstance.federalTaxCalc())
        self.listOfReturnValues.append(self.FederalInstance.getFederalTax())
        self.StateInstance.setStateTaxAmount(self.StateInstance.stateTaxCalc())
        self.listOfReturnValues.append(self.StateInstance.getStateTaxAmount())
        self.SSInstance.setSocialSecurityAmount(self.SSInstance.calcSocialSecurityTax())
        self.listOfReturnValues.append(self.SSInstance.getSocialSecurityAmount())
        self.MedicareInstance.setMedicareAmount(self.MedicareInstance.calcMedicareTax())
        self.listOfReturnValues.append(self.MedicareInstance.getMedicareAmount())
        self.CityInstance.setCityTaxAmount(self.CityInstance.calcCityTax())
        self.listOfReturnValues.append(self.CityInstance.getCityTaxAmount())
        #calculate net pay
        self.calcNetAmount(newHourlyPaycheck.getGross())
    def executeSalariedPaycheck(self):
        newSalariedPaycheck=self.createSalaryPaycheck()
        self.initializePaycheckInstances(newSalariedPaycheck)
        #store them in an array
        self.listOfReturnValues.append(newSalariedPaycheck.getGross())
        self.FederalInstance.setFederalTax(self.FederalInstance.federalTaxCalc())
        self.listOfReturnValues.append(self.FederalInstance.getFederalTax())
        self.StateInstance.setStateTaxAmount(self.StateInstance.stateTaxCalc())
        self.listOfReturnValues.append(self.StateInstance.getStateTaxAmount())
        self.SSInstance.setSocialSecurityAmount(self.SSInstance.calcSocialSecurityTax())
        self.listOfReturnValues.append(self.SSInstance.getSocialSecurityAmount())
        self.MedicareInstance.setMedicareAmount(self.MedicareInstance.calcMedicareTax())
        self.listOfReturnValues.append(self.MedicareInstance.getMedicareAmount())
        self.CityInstance.setCityTaxAmount(self.CityInstance.calcCityTax())
        self.listOfReturnValues.append(self.CityInstance.getCityTaxAmount())
        #calculate net pay
        self.calcNetAmount(newSalariedPaycheck.getGross())
    def initializePaycheckInstances(self, newPaycheck):
        #Initialize tax classes
        self.FederalInstance=FederalIncomeTax(newPaycheck.getGross(), self.federalAllowances)
        self.StateInstance=StateIncomeTax(newPaycheck.getGross(), self.stateAllowances)
        self.SSInstance=SocialSecurityTax(newPaycheck.getGross(), self.isEmployee)
        self.MedicareInstance=MedicareTax(newPaycheck.getGross(), self.isEmployee)
        self.CityInstance=CityTax(newPaycheck.getGross(),  self.cityTaxRate)
    #used to create a new hourly paycheck instance
    def createNewHourlyPaycheck(self):
        #print(self.hoursWorked)
        #print(self.hourlyWage)
        HourlyPaycheck=HourlyPayRate(self.hoursWorked, self.hourlyWage)
        HourlyPaycheck.setGross(HourlyPaycheck.calcGross())
        return HourlyPaycheck
    #used to create a new salaried paycheck instance
    def createSalaryPaycheck(self):
        #print(self.salaryAmount)
        SalariedPaycheck=SalaryPay(self.salaryAmount)
        SalariedPaycheck.setGross()
        return SalariedPaycheck
    def calcNetAmount(self, gross):
        netPayAmount=gross
        netPayAmount-=self.FederalInstance.getFederalTax()
        netPayAmount-=self.StateInstance.getStateTaxAmount()
        netPayAmount-=self.SSInstance.getSocialSecurityAmount()
        netPayAmount-=self.MedicareInstance.getMedicareAmount()
        netPayAmount-=self.CityInstance.getCityTaxAmount()
        self.listOfReturnValues.append(netPayAmount)
    def returnArrayValues(self):
        return self.listOfReturnValues
        

