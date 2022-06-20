#calculate meicare tax for employer or employee
class MedicareTax():
    def __init__(self, gross, isEmployee=True):
        #HourlyPayRate.__init__(self, hours, payrate)
        self.gross=gross
        self.isEmployee=isEmployee
        self.medicareTaxAmount=None
    def calcMedicareTax(self):
        if self.isEmployee ==True:
            medicareTaxAmount= self.gross * .0145
        else:
            medicareTaxAmount = self.gross * .029
        medicareTaxAmount=round(medicareTaxAmount,2)
        return medicareTaxAmount
    def setMedicareAmount(self, calculatedMedicareAmount):
        self.medicareTaxAmount= calculatedMedicareAmount
    def getMedicareAmount(self):
        return self.medicareTaxAmount
    def getIsEmployee(self):
        return self.isEmployee
