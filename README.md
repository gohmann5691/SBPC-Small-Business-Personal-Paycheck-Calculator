# SBPC-Small_Business_Paycheck_Calculator-DotNetFrameworkVersion
A paycheck Calculator designed for use by small businesses or for individuals who do not get deductions automatically from thier paycheck

This software is a windows form application designed for the creation and organizations for paychecks along with predicted deductions for
federal, state, social security, medicare, and city. The program is inteded to be used with small business orders or for people who need to
kkeep track of their paycheck duductions on their own.

The program utilizes a database to accurate calculate city tax based on the zip code entered. However, the database currently only contains 
codes for the state of Ohio. Adding more compability between states a topic of future work. 
*To avoid any ambiguities beween the AGPLv3 license and how it applies to data, you are free to reuse and distribute the database created 
however you wish.

The frontend is written in c# using winforms. The startup project is PaycheckAppUI(the debug and release folders are stored in the respective
folder as well).
The backend of the program is written in python and utilizes ironpython 2.7 in order to run in the .NET framework
The database is and .mdb file and uses oleDB in order to execute the zip code query

The project was written in visual studio 2019
TODO:
~Add search suggestions from previous paycheck inputs for convenience and to save time for users.
~implement the execution for quick print in the mainform.cs in a more efficient way(many code clones are being used for the same buttons)
~Make the software fulling compatible with any state in the United States by add to the python code and city tax database
~add overtime compatiblity and other payroll periods such as biweekly, bimonthly, and monthly(currently only supports weekly)
