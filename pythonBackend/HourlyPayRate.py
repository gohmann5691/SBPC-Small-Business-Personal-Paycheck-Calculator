#This class is used to calculate the gross amount for an hourly pay rate
class HourlyPayRate():
    def __init__(self, hours, payrate):
        self.hours=hours
        self.payrate=payrate

    def calcGross(self):
        gross=self.hours*self.payrate
        return gross
    def setGross(self, calculatedGrossAmount):
        self.gross=round(calculatedGrossAmount,2)
    def getGross(self):
        return self.gross
    def getPayRate(self):
        return self.payrate
    def getHours(self):
        return self.hours
        


    

