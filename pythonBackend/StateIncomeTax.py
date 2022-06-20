#class used to calculate state tax
#tax tables are from 2021
class StateIncomeTax():
    def __init__(self, gross, stateAllowance):
        #HourlyPayRate.__init__(self, gross, stateAllowance)
        self.gross=gross
        self.stateAllowance=stateAllowance
        self.stateIncomeTax=None
    #state income tax
    def stateTaxCalc(self):
        #brackets without allowances
        if self.stateAllowance == 0:
            #bracket 1
            if self.gross >= 0 and self.gross < 96.15:
                stateCalc=self.gross*.00538
             #bracket 2
            elif self.gross >= 96.15 and self.gross<192.31:
                stateCalc=(self.gross-96.15)*.01032+.52
            #bracket 3
            elif self.gross >= 192.31 and self.gross<288.46:
                stateCalc=(self.gross-192.31)*.02067+1.55
            #bracket 4
            elif self.gross >=288.46 and self.gross<384.62:
                stateCalc=(self.gross-288.46)*.02582+3.62
            #bracket 5
            elif self.gross >=384.62 and self.gross<769.23:
                stateCalc=(self.gross-384.62)*.03099+6.21
            #bracket 6
            elif self.gross >= 769.23 and self.gross < 1538.46:
                stateCalc=(self.gross-769.23)*.03614+18.63
            #bracket 7
            elif self.gross >= 1538.46 and self.gross < 1923.08:
                stateCalc= (self.gross-1538.46)*.04132+47.59
            #bracket 8
            elif self.gross >= 1923.08:
                stateCalc= (self.gross-1923.08)*.05164+64.14
            else:
                stateCalc=0
        #brackets
        if self.stateAllowance == 1:
            allowanceState=12.50
            withholdAmount= self.gross- allowanceState*self.stateAllowance
            #bracket 1
            if withholdAmount >= 0 and withholdAmount < 96.15:
                stateCalc=withholdAmount*.00538
             #bracket 2
            elif withholdAmount >= 96.15 and withholdAmount<192.31:
                stateCalc=(withholdAmount-96.15)*.01032+.52
            #bracket 3
            elif withholdAmount >= 192.31 and withholdAmount<288.46:
                stateCalc=(withholdAmount-192.31)*.02067+1.55
            #bracket 4
            elif withholdAmount >=288.46 and withholdAmount<384.62:
                stateCalc=(withholdAmount-288.46)*.02582+3.62
            #bracket 5
            elif withholdAmount >=384.62 and withholdAmount<769.23:
                stateCalc=(withholdAmount-384.62)*.03099+6.21
            #bracket 6
            elif withholdAmount >= 769.23 and withholdAmount < 1538.46:
                stateCalc=(withholdAmount-769.23)*.03614+18.63
            #bracket 7
            elif withholdAmount >= 1538.46 and withholdAmount < 1923.08:
                stateCalc= (withholdAmount-1538.46)*.04132+47.59
            #bracket 8
            elif withholdAmount >= 1923.08:
                stateCalc= (withholdAmount-1923.08)*.05164+64.14
            else:
                stateCalc=0
        #brackets
        if self.stateAllowance == 2:
            allowanceState=12.50
            withholdAmount= self.gross- allowanceState*self.stateAllowance
            #bracket 1
            if withholdAmount >= 0 and withholdAmount < 96.15:
                stateCalc=withholdAmount*.00538
             #bracket 2
            elif withholdAmount >= 96.15 and withholdAmount<192.31:
                stateCalc=(withholdAmount-96.15)*.01032+.52
            #bracket 3
            elif withholdAmount >= 192.31 and withholdAmount<288.46:
                stateCalc=(withholdAmount-192.31)*.02067+1.55
            #bracket 4
            elif withholdAmount >=288.46 and withholdAmount<384.62:
                stateCalc=(withholdAmount-288.46)*.02582+3.62
            #bracket 5
            elif withholdAmount >=384.62 and withholdAmount<769.23:
                stateCalc=(withholdAmount-384.62)*.03099+6.21
            #bracket 6
            elif withholdAmount >= 769.23 and withholdAmount < 1538.46:
                stateCalc=(withholdAmount-769.23)*.03614+18.63
            #bracket 7
            elif withholdAmount >= 1538.46 and withholdAmount < 1923.08:
                stateCalc= (withholdAmount-1538.46)*.04132+47.59
            #bracket 8
            elif withholdAmount >= 1923.08:
                stateCalc= (withholdAmount-1923.08)*.05164+64.14
            else:
                stateCalc=0
        #brackets
        if self.stateAllowance == 3:
            allowanceState=12.50
            withholdAmount= self.gross- allowanceState*self.stateAllowance
            #bracket 1
            if withholdAmount >= 0 and withholdAmount < 96.15:
                stateCalc=withholdAmount*.00538
             #bracket 2
            elif withholdAmount >= 96.15 and withholdAmount<192.31:
                stateCalc=(withholdAmount-96.15)*.01032+.52
            #bracket 3
            elif withholdAmount >= 192.31 and withholdAmount<288.46:
                stateCalc=(withholdAmount-192.31)*.02067+1.55
            #bracket 4
            elif withholdAmount >=288.46 and withholdAmount<384.62:
                stateCalc=(withholdAmount-288.46)*.02582+3.62
            #bracket 5
            elif withholdAmount >=384.62 and withholdAmount<769.23:
                stateCalc=(withholdAmount-384.62)*.03099+6.21
            #bracket 6
            elif withholdAmount >= 769.23 and withholdAmount < 1538.46:
                stateCalc=(withholdAmount-769.23)*.03614+18.63
            #bracket 7
            elif withholdAmount >= 1538.46 and withholdAmount < 1923.08:
                stateCalc= (withholdAmount-1538.46)*.04132+47.59
            #bracket 8
            elif withholdAmount >= 1923.08:
                stateCalc= (withholdAmount-1923.08)*.05164+64.14
            else:
                stateCalc=0
        #brackets
        if self.stateAllowance == 4:
            allowanceState=12.50
            withholdAmount= self.gross- allowanceState*self.stateAllowance
            #bracket 1
            if withholdAmount >= 0 and withholdAmount < 96.15:
                stateCalc=withholdAmount*.00538
             #bracket 2
            elif withholdAmount >= 96.15 and withholdAmount<192.31:
                stateCalc=(withholdAmount-96.15)*.01032+.52
            #bracket 3
            elif withholdAmount >= 192.31 and withholdAmount<288.46:
                stateCalc=(withholdAmount-192.31)*.02067+1.55
            #bracket 4
            elif withholdAmount >=288.46 and withholdAmount<384.62:
                stateCalc=(withholdAmount-288.46)*.02582+3.62
            #bracket 5
            elif withholdAmount >=384.62 and withholdAmount<769.23:
                stateCalc=(withholdAmount-384.62)*.03099+6.21
            #bracket 6
            elif withholdAmount >= 769.23 and withholdAmount < 1538.46:
                stateCalc=(withholdAmount-769.23)*.03614+18.63
            #bracket 7
            elif withholdAmount >= 1538.46 and withholdAmount < 1923.08:
                stateCalc= (withholdAmount-1538.46)*.04132+47.59
            #bracket 8
            elif withholdAmount >= 1923.08:
                stateCalc= (withholdAmount-1923.08)*.05164+64.14
            else:
                stateCalc=0
        #brackets
        if self.stateAllowance == 5:
            allowanceState=12.50
            withholdAmount= self.gross- allowanceState*self.stateAllowance
            #bracket 1
            if withholdAmount >= 0 and withholdAmount < 96.15:
                stateCalc=withholdAmount*.00538
             #bracket 2
            elif withholdAmount >= 96.15 and withholdAmount<192.31:
                stateCalc=(withholdAmount-96.15)*.01032+.52
            #bracket 3
            elif withholdAmount >= 192.31 and withholdAmount<288.46:
                stateCalc=(withholdAmount-192.31)*.02067+1.55
            #bracket 4
            elif withholdAmount >=288.46 and withholdAmount<384.62:
                stateCalc=(withholdAmount-288.46)*.02582+3.62
            #bracket 5
            elif withholdAmount >=384.62 and withholdAmount<769.23:
                stateCalc=(withholdAmount-384.62)*.03099+6.21
            #bracket 6
            elif withholdAmount >= 769.23 and withholdAmount < 1538.46:
                stateCalc=(withholdAmount-769.23)*.03614+18.63
            #bracket 7
            elif withholdAmount >= 1538.46 and withholdAmount < 1923.08:
                stateCalc= (withholdAmount-1538.46)*.04132+47.59
            #bracket 8
            elif withholdAmount >= 1923.08:
                stateCalc= (withholdAmount-1923.08)*.05164+64.14
            else:
                stateCalc=0
        stateIncomeTax=round(stateCalc,2)
        return stateIncomeTax
    def setStateTaxAmount(self, calculatedStateAmount):
        self.stateIncomeTax=calculatedStateAmount
    def getStateTaxAmount(self):
        return self.stateIncomeTax
    def getStateAllowance(Self):
        return self.stateAllowance
