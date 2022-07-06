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
            //change the relative path if the program is installed
            if (Path.GetFileName(Path.GetDirectoryName(this.relativePath)) == "Program Files (x86)" || Path.GetFileName(Path.GetDirectoryName(this.relativePath)) == "Program Files(x86)")
            {
                this.relativePath= Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"SBPC\SBPC-Small-Business-Paycheck-Calculator\..\..\..\"));
            }
            //create the python path so that the imports work correctly
            List<string> _paths = new List<string>();
            _paths.Add(this.relativePath + @"pythonBackend");
            bool myDebug = true;
            Dictionary<string, object> options = new Dictionary<string, object>();
            options["Debug"] = myDebug;
            engine = Python.CreateEngine(options);
            initializeScopeObjectsFiles(_paths);
        }
        private void initializeScopeObjectsFiles(List<string> _myPath)
        {
            engine.SetSearchPaths(_myPath);
            this.scope = engine.CreateScope();
            engine.ExecuteFile(this.relativePath + @"pythonBackend\CityTax.py");
            engine.ExecuteFile(this.relativePath + @"pythonBackend\FederalIncomeTax.py");
            engine.ExecuteFile(this.relativePath + @"pythonBackend\HourlyPayRate.py");
            engine.ExecuteFile(this.relativePath + @"pythonBackend\CSharpToPython.py", scope);
            engine.ExecuteFile(this.relativePath + @"pythonBackend\HourlyPayRate.py");
            engine.ExecuteFile(this.relativePath + @"pythonBackend\MedicareTax.py");
            engine.ExecuteFile(this.relativePath + @"pythonBackend\SocialSecurityTax.py");
            engine.ExecuteFile(this.relativePath + @"pythonBackend\StateIncomeTax.py");
            engine.ExecuteFile(this.relativePath + @"pythonBackend\PaycheckType.py", scope);
            engine.ExecuteFile(this.relativePath + @"pythonBackend\main.py", scope);
        }
        public ScriptScope ScopeControl
        {
            get { return this.scope; }
        }
    }
}
