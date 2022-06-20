#calculate social security class for employer or employee
class SocialSecurityTax():
    def __init__(self, gross, isEmployee=True):
        #HourlyPayRate.__init__(self, hours, payrate)
        self.gross=gross
        self.isEmployee=isEmployee
        self.socialSecurityAmount=None
    def calcSocialSecurityTax(self):
        if self.isEmployee ==True:
            socialSecurityAmount= self.gross * .062
        else:
            socialSecurityAmount = self.gross * .124
        socialSecurityAmount=round(socialSecurityAmount,2)
        return socialSecurityAmount
    def setSocialSecurityAmount(self, calculatedSSAmount):
        self.socialSecurityAmount= calculatedSSAmount
    def getSocialSecurityAmount(self):
        return self.socialSecurityAmount
    def getIsEmployee(self):
        return self.isEmployee
