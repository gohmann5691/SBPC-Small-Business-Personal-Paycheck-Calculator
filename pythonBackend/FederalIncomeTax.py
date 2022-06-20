#Class used to calculate federal wages
#tax tables are from 2019
class FederalIncomeTax():
    def __init__(self, gross, fedAllowance):
        #HourlyPayRate.__init__(self, hours, payrate, fedAllowance)
        self.gross=gross
        self.fedAllowance=fedAllowance
        self.federalTax=None
    #calculateFederalTaxDeduction
    def federalTaxCalc(self):
        #zero allowances
        if self.fedAllowance == 0:
            if self.gross < 73.00:
                federalCalc=0
            if self.gross>=73.00 and self.gross<260.00:
                federalCalc=(self.gross)*.10
            elif self.gross>=260.00 and self.gross<832.00:
                federalCalc=(self.gross-260.00)*0.120+18.70
            elif self.gross>=832.00 and self.gross<1692:
                federalCalc=(self.gross-832.00)*0.220+87.34
            elif self.gross>=1692.00 and self.gross<3164.00:
                federalCalc=(self.gross-1692.00)*0.240+276.54
            elif self.gross>=3164.00 and self.gross<3998.00:
                federalCalc=(self.gross-3164.00)*0.320+629.82
            elif self.gross>=3998.00 and self.gross<9887.00:
                federalCalc=(self.gross-3998.00)*0.350+896.70
            elif self.gross>=9887.00:
                federalCalc=(self.gross-9887.00)*0.370+2957.85
        #one allwance    
        elif self.fedAllowance == 1:
            allowance=80.80
            witholdingamount=self.gross-allowance*self.fedAllowance            
            if witholdingamount < 73:
                federalCalc=0
            if witholdingamount>=73 and witholdingamount<260.00:
                federalCalc=(witholdingamount)*.10
            elif witholdingamount>=260 and witholdingamount<832.00:
                federalCalc=(witholdingamount-260.00)*.12+18.70
            elif witholdingamount>=832.00 and witholdingamount<1692:
                federalCalc=(witholdingamount-832.00)*.22+87.34
            elif witholdingamount>=1692.00 and witholdingamount<3164.00:
                federalCalc=(witholdingamount-1692.00)*.24+276.54
            elif witholdingamount>=3164.00 and witholdingamount<3998.00:
                federalCalc=(self.gross-3164.00)*.32+629.82
            elif witholdingamount>=3998.00 and witholdingamount<9887.00:
                federalCalc=(witholdingamount-3998.00)*.35+896.70
            elif witholdingamount>=9887.00:
                federalCalc=(witholdingamount-9887.00)*.37+2957.85
        #two allowances
        elif self.fedAllowance == 2:
            allowance=80.80
            witholdingamount=self.gross-allowance*self.fedAllowance            
            if witholdingamount < 73:
                federalCalc=0
            if witholdingamount>=73 and witholdingamount<260.00:
                federalCalc=(witholdingamount)*.10
            elif witholdingamount>=260 and witholdingamount<832.00:
                federalCalc=(witholdingamount-260.00)*.12+18.70
            elif witholdingamount>=832.00 and witholdingamount<1692:
                federalCalc=(witholdingamount-832.00)*.22+87.34
            elif witholdingamount>=1692.00 and witholdingamount<3164.00:
                federalCalc=(witholdingamount-1692.00)*.24+276.54
            elif witholdingamount>=3164.00 and witholdingamount<3998.00:
                federalCalc=(self.gross-3164.00)*.32+629.82
            elif witholdingamount>=3998.00 and witholdingamount<9887.00:
                federalCalc=(witholdingamount-3998.00)*.35+896.70
            elif witholdingamount>=9887.00:
                federalCalc=(witholdingamount-9887.00)*.37+2957.85
        #three allowances
        elif self.fedAllowance == 3:
            allowance=80.80
            witholdingamount=self.gross-allowance*self.fedAllowance            
            if witholdingamount < 73:
                federalCalc=0
            if witholdingamount>=73 and witholdingamount<260.00:
                federalCalc=(witholdingamount)*.10
            elif witholdingamount>=260 and witholdingamount<832.00:
                federalCalc=(witholdingamount-260.00)*.12+18.70
            elif witholdingamount>=832.00 and witholdingamount<1692:
                federalCalc=(witholdingamount-832.00)*.22+87.34
            elif witholdingamount>=1692.00 and witholdingamount<3164.00:
                federalCalc=(witholdingamount-1692.00)*.24+276.54
            elif witholdingamount>=3164.00 and witholdingamount<3998.00:
                federalCalc=(self.gross-3164.00)*.32+629.82
            elif witholdingamount>=3998.00 and witholdingamount<9887.00:
                federalCalc=(witholdingamount-3998.00)*.35+896.70
            elif witholdingamount>=9887.00:
                federalCalc=(witholdingamount-9887.00)*.37+2957.85
        #four allowances
        elif self.fedAllowance == 4:
            allowance=80.80
            witholdingamount=self.gross-allowance*self.fedAllowance            
            if witholdingamount < 73:
                federalCalc=0
            if witholdingamount>=73 and witholdingamount<260.00:
                federalCalc=(witholdingamount)*.10
            elif witholdingamount>=260 and witholdingamount<832.00:
                federalCalc=(witholdingamount-260.00)*.12+18.70
            elif witholdingamount>=832.00 and witholdingamount<1692:
                federalCalc=(witholdingamount-832.00)*.22+87.34
            elif witholdingamount>=1692.00 and witholdingamount<3164.00:
                federalCalc=(witholdingamount-1692.00)*.24+276.54
            elif witholdingamount>=3164.00 and witholdingamount<3998.00:
                federalCalc=(self.gross-3164.00)*.32+629.82
            elif witholdingamount>=3998.00 and witholdingamount<9887.00:
                federalCalc=(witholdingamount-3998.00)*.35+896.70
            elif witholdingamount>=9887.00:
                federalCalc=(witholdingamount-9887.00)*.37+2957.85
        #five allowances
        elif self.fedAllowance == 5:
            allowance=80.80
            witholdingamount=self.gross-allowance*self.fedAllowance            
            if witholdingamount < 73:
                federalCalc=0
            if witholdingamount>=73 and witholdingamount<260.00:
                federalCalc=(witholdingamount)*.10
            elif witholdingamount>=260 and witholdingamount<832.00:
                federalCalc=(witholdingamount-260.00)*.12+18.70
            elif witholdingamount>=832.00 and witholdingamount<1692:
                federalCalc=(witholdingamount-832.00)*.22+87.34
            elif witholdingamount>=1692.00 and witholdingamount<3164.00:
                federalCalc=(witholdingamount-1692.00)*.24+276.54
            elif witholdingamount>=3164.00 and witholdingamount<3998.00:
                federalCalc=(self.gross-3164.00)*.32+629.82
            elif witholdingamount>=3998.00 and witholdingamount<9887.00:
                federalCalc=(witholdingamount-3998.00)*.35+896.70
            elif witholdingamount>=9887.00:
                federalCalc=(witholdingamount-9887.00)*.37+2957.85
        #in case a bad parameter is passed
        else:
            federalTax=0.0
        #Round the federal tax amount to the nearest cent
        federalTax=round(federalCalc,2)
        return federalTax
    def getFederalTax(self):
        return self.federalTax
    def setFederalTax(self, calculatedFedAmount):
        self.federalTax=calculatedFedAmount
    def getFederalAllowance(self):
        return self.fedAllowance
