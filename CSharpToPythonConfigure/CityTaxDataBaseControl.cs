using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
namespace CSharpToPythonConfigure
{

    public class CityTaxDataBaseControl
    {
        private static string relativePath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\"));
        //TODO: replace with application path upon implmenting the UI
        //it may be necessary to swap between jet and ace. Maybe add a try catch statement here?
        private static string constr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " + relativePath + @"cityTaxDatabase\cityTaxDatabase.mdb";
        private OleDbConnection dbcon;
        private List<string> db_outputList;
        private string zipCodeInput;

        public CityTaxDataBaseControl(string zipCodeInput)
        {
            this.db_outputList = new List<string> { };
            if (checkDBPath() == false)
            {
                this.dbcon = new OleDbConnection(constr);
            }
            this.zipCodeInput = zipCodeInput;

        }
        private bool checkDBPath()
        {
            //change the relative path if the program is installed
            if (Path.GetFileName(Path.GetDirectoryName(relativePath)) == "Program Files (x86)" || Path.GetFileName(Path.GetDirectoryName(relativePath)) == "Program Files(x86)")
            {
                relativePath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"SBPC\SBPC-Small-Business-Paycheck-Calculator\..\..\..\"));
                constr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " + relativePath + @"cityTaxDatabase\cityTaxDatabase.mdb";
                this.dbcon = new OleDbConnection(constr);
                return true;
            }
            else
            {
                return false;
            }
        }
        public void openDBConnection()
        {
            this.dbcon.Open();
        }
        public void closeDBConnection()
        {
            this.dbcon.Close();
        }
        public bool executeSQLStatement(string zipCode)
        {

            OleDbCommand cmd = this.dbcon.CreateCommand();
            cmd.CommandText = "SELECT zipCodes.zipCodeLookup, TaxRatesByCounty.TaxRate, zipCodes.County" + '\n' +
                "FROM TaxRatesByCounty INNER JOIN zipCodes ON TaxRatesByCounty.CountyName = zipCodes.County" + '\n' +
                "WHERE zipCodes.zipCodeLookup = " + zipCode + ";";
            //dynamic rowsAff=cmd.ExecuteNonQuery()
            if (zipCode.Length != 5 || int.TryParse(zipCode, out _) == false)
            {
                return false;
            }
            try
            {
                OleDbDataReader dr = cmd.ExecuteReader();
                dr.Read();
                for (int i = 0; i < 3; i++)
                {
                    this.db_outputList.Add(dr[i].ToString());
                }
                dr.Close();
                return true;
            }
            catch (System.Data.OleDb.OleDbException oError)
            {
                return false;
            }
        }
        public dynamic returnQueryResults()
        {
            if (executeSQLStatement(this.zipCodeInput) != false)
            {
                return db_outputList;
            }
            else
            {
                return 0.0;
            }
        }
    }
}