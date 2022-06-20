class SalaryPay():
    def __init__(self, salary):
        self.salary=salary
        self.gross=None
    def setGross(self):
        self.gross=self.salary
    def getGross(self):
        return self.gross

