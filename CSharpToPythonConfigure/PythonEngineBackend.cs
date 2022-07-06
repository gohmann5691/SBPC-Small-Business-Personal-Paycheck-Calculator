using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using System.Data;
using System.Diagnostics;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using Microsoft.Scripting.Debugging;

namespace CSharpToPythonConfigure
{
    public class PythonEngineBackend
    {
        //create memory stream objects
        private MemoryStream _outputStream;
        private MemoryStream _errorStream;
        private ScriptEngine engine;
        //create variable for scope of python engine
        private ScriptScope scope;
        private string relativePath;
        public PythonEngineBackend()
        {
            this.scope = scope;
            this.relativePath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\"));

        }

        public void setupErrorOutputStream()
        {
            _outputStream = new MemoryStream();
            _errorStream = new MemoryStream();
            EventRaisingStreamWriter _outputWriter;
            EventRaisingStreamWriter _errorWriter;
            _outputWriter = new EventRaisingStreamWriter(_outputStream);
            _errorWriter = new EventRaisingStreamWriter(_errorStream);

        }
        public void initializePythonEngine()
        {
            //create the python path so that the imports work correctly
            List<string> _paths = new List<string>();
            _paths.Add(relativePath + @"pythonBackend");
            bool myDebug = true;
            Dictionary<string, object> options = new Dictionary<string, object>();
            options["Debug"] = myDebug;
            engine = Python.CreateEngine(options);
            //string filePath= @"C:\Users\colin\Desktop\NEWPAYCHECKCALCULATOR\applicationMainSourceCode\pythonBackend\";
            initializeScopeObjectsFiles(_paths);
        }
        private void initializeScopeObjectsFiles(List<string> _myPath)
        {
            engine.SetSearchPaths(_myPath);
            this.scope = engine.CreateScope();
            //Debug.WriteLine(relativePath);
            try
            {
                engine.ExecuteFile(relativePath + @"pythonBackend\CityTax.py");
                engine.ExecuteFile(relativePath + @"pythonBackend\FederalIncomeTax.py");
                engine.ExecuteFile(relativePath + @"pythonBackend\HourlyPayRate.py");
                engine.ExecuteFile(relativePath + @"pythonBackend\CSharpToPython.py", scope);
                engine.ExecuteFile(relativePath + @"pythonBackend\HourlyPayRate.py");
                engine.ExecuteFile(relativePath + @"pythonBackend\MedicareTax.py");
                engine.ExecuteFile(relativePath + @"pythonBackend\SocialSecurityTax.py");
                engine.ExecuteFile(relativePath + @"pythonBackend\StateIncomeTax.py");
                engine.ExecuteFile(relativePath + @"pythonBackend\PaycheckType.py", scope);
                engine.ExecuteFile(relativePath + @"pythonBackend\main.py", scope);
            }
            catch(Exception e)
            {
                this.relativePath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"SBPC\SBPC-Small-Business-Paycheck-Calculator\..\..\..\"));
                engine.ExecuteFile(relativePath + @"pythonBackend\CityTax.py");
                engine.ExecuteFile(relativePath + @"pythonBackend\FederalIncomeTax.py");
                engine.ExecuteFile(relativePath + @"pythonBackend\HourlyPayRate.py");
                engine.ExecuteFile(relativePath + @"pythonBackend\CSharpToPython.py", scope);
                engine.ExecuteFile(relativePath + @"pythonBackend\HourlyPayRate.py");
                engine.ExecuteFile(relativePath + @"pythonBackend\MedicareTax.py");
                engine.ExecuteFile(relativePath + @"pythonBackend\SocialSecurityTax.py");
                engine.ExecuteFile(relativePath + @"pythonBackend\StateIncomeTax.py");
                engine.ExecuteFile(relativePath + @"pythonBackend\PaycheckType.py", scope);
                engine.ExecuteFile(relativePath + @"pythonBackend\main.py", scope);
            }
           
        }
        public ScriptScope ScopeControl
        {
            get { return this.scope; }
        }
    }
}
