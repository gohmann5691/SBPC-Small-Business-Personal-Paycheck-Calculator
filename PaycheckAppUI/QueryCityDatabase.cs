using System;
using System.Collections.Generic;
using System.Text;
using CSharpToPythonConfigure;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;
namespace PaycheckAppUI
{
    /// <summary>
    /// This class is used to make the sql query for the city tax database
    /// </summary>
    class QueryCityDatabase
    {
        private string zipCode;
        private CityTaxDataBaseControl newDatabase;
        private List<string> resultStrList;
        public QueryCityDatabase(string zipCodeInput)
        {
            this.zipCode = zipCodeInput;
            this.newDatabase = new CityTaxDataBaseControl(zipCode);

        }
        public void QueryDatabase()
        {
            newDatabase.openDBConnection();
            this.resultStrList = newDatabase.returnQueryResults();
            newDatabase.closeDBConnection();
        }
        public List<string> ResultStrListControl => resultStrList;


    }
}
