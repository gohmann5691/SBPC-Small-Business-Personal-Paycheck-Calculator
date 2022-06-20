using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpToPythonConfigure
{
    /// <summary>
    /// Use this class to the store the output that will be passed back to the UI 
    /// The Input class variables are inherited
    /// </summary>
    public class OutputToUI : PaycheckClassInput
    {
        private double federalResult;
        private double stateResult;
        private double medicareResult;
        private double sSREsult;
        private double cityTaxResult;
        private double netPay;
        private double grossPay;

        public double FederalResultControl
        {
            get { return federalResult; }
            set { federalResult = value; }
        }
        public double StateResultControl
        {
            get { return stateResult; }
            set { stateResult = value; }
        }
        public double MedicareResultControl
        {
            get { return medicareResult; }
            set { medicareResult = value; }
        }
        public double SSResultControl
        {
            get { return sSREsult; }
            set { sSREsult = value; }
        }
        public double CityResultControl
        {
            get { return cityTaxResult; }
            set { cityTaxResult = value; }
        }
        public double NetPayControl
        {
            get { return netPay; }
            set { netPay = value; }
        }
        public double GrossControl
        {
            get { return grossPay; }
            set { grossPay = value; }
        }
    }
}
