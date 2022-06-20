#class calculates city tax of a given tax rate
class CityTax():
    def __init__(self, gross, cityRate):
        self.gross=gross
        self.cityRate=cityRate
        self.cityTaxAmount=None
    def calcCityTax(self):
        cityTaxAmount= round(self.gross * self.cityRate, 2)
        return cityTaxAmount
    def setCityTaxAmount(self, calculatedCityTaxAmount):
        self.cityTaxAmount=calculatedCityTaxAmount
    def getCityTaxAmount(self):
        return self.cityTaxAmount
    def getCityRate(self):
        return self.cityRate
