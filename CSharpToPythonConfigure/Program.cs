using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Scripting.Utils;
//
using System.IO;
using System.Reflection;
using System.Data;
using System.Diagnostics;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using Microsoft.Scripting.Debugging;
using System.Globalization;
//using System.Data;
using System.Data.OleDb;
namespace CSharpToPythonConfigure
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //if (false)
            //{
                string PayrollType = "Hourly";
                double HourlyWage = 201.09;
                double HoursWorked = 6.0;
                bool Is_Employee = true;
                int Federal_Allowances = 1;
                int State_Allowances = 1;
                double CityTaxRate = .09;
                double Salary = 1500.00;
                PythonEngineBackend NewPythonInstance = new PythonEngineBackend();
                NewPythonInstance.initializePythonEngine();
                ScriptScope scope = NewPythonInstance.getScope();
                Paycheck NewPayCheck = new Paycheck();
                NewPayCheck.copyInputsFromUIToPython(PayrollType, HourlyWage, HoursWorked, Is_Employee, Federal_Allowances,
                State_Allowances, CityTaxRate, Salary);
                NewPayCheck.executePythonMain(scope);
                dynamic PaycheckResults = NewPayCheck.getTaxResults();
                NewPayCheck.copyOutputsFromPython();
                OutputToUI backToUI = NewPayCheck.getResults();
                printParameters(backToUI);
            //}
            string str = "45440";
            CityTaxDataBaseControl newDatabase = new CityTaxDataBaseControl(str);
            newDatabase.openDBConnection();
            List<string> resultStr= newDatabase.returnQueryResults();
            newDatabase.closeDBConnection();
            //printParameters(newDatabase);
            //string myString = "hello world";

            //DataTable importData=GetDataTableFromCsv(@"C:\Users\colin\Desktop\NEWPAYCHECKCALCULATOR\products.csv", true);
            //Console.WriteLine(importData.Rows[10][0]);
            //Console.WriteLine(importData.Rows[10][1]);
            //Console.WriteLine(importData.Rows[10][2]);
            //Console.WriteLine(importData.Rows[10][3]);
            //print_results(importData);
            */
        }
        /*
        static DataTable GetDataTableFromCsv(string path, bool isFirstRowHeader)
        {
            string header = isFirstRowHeader ? "Yes" : "No";

            string pathOnly = Path.GetDirectoryName(path);
            string fileName = Path.GetFileName(path);

            string sql = @"SELECT * FROM [" + fileName + "]";

            using (OleDbConnection connection = new OleDbConnection(
                      @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + pathOnly +
                      ";Extended Properties=\"Text;HDR=" + header + "\""))
            using (OleDbCommand command = new OleDbCommand(sql, connection))
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
            {
                DataTable dataTable = new DataTable();
                dataTable.Locale = CultureInfo.CurrentCulture;
                adapter.Fill(dataTable);
                return dataTable;
            }
        }
        static void print_results(DataTable data)
        {
            Console.WriteLine();
            Dictionary<string, int> colWidths = new Dictionary<string, int>();

            foreach (DataColumn col in data.Columns)
            {
                Console.Write(col.ColumnName);
                var maxLabelSize = data.Rows.OfType<DataRow>()
                        .Select(m => (m.Field<object>(col.ColumnName)?.ToString() ?? "").Length)
                        .OrderByDescending(m => m).FirstOrDefault();

                colWidths.Add(col.ColumnName, maxLabelSize);
                for (int i = 0; i < maxLabelSize - col.ColumnName.Length + 10; i++) Console.Write(" ");
            }

            Console.WriteLine();

            foreach (DataRow dataRow in data.Rows)
            {
                for (int j = 0; j < dataRow.ItemArray.Length; j++)
                {
                    Console.Write(dataRow.ItemArray[j]);
                    for (int i = 0; i < colWidths[data.Columns[j].ColumnName] - dataRow.ItemArray[j].ToString().Length + 10; i++) Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        public static void printParameters(OutputToUI printPaycheckConsole)
        {
            Console.WriteLine(printPaycheckConsole.PayrollTypeControl);
            Console.WriteLine(printPaycheckConsole.HourlyWageControl);
            Console.WriteLine(printPaycheckConsole.HoursWorkedControl);
            Console.WriteLine(printPaycheckConsole.Is_EmployeeControl);
            Console.WriteLine(printPaycheckConsole.SalaryControl);
            Console.WriteLine(printPaycheckConsole.Federal_AllowancesControl);
            Console.WriteLine(printPaycheckConsole.State_AllowancesControl);
            Console.WriteLine(printPaycheckConsole.CityTaxRateControl);
            //
            Console.WriteLine(printPaycheckConsole.FederalResultControl);
            Console.WriteLine(printPaycheckConsole.StateResultControl);
            Console.WriteLine(printPaycheckConsole.MedicareResultControl);
            Console.WriteLine(printPaycheckConsole.SSResultControl);
            Console.WriteLine(printPaycheckConsole.CityResultControl);
            Console.WriteLine(printPaycheckConsole.NetPayControl);
        }*/
    }
}
