using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Fissure.Components;
using Fissure.Components.Permanents;
using Microsoft.Scripting.Hosting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Fissure
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //
            //JObject raw = JObject.Parse(fileContents);
            //Summon mySummon;

            //new JsonCardReader(".").Read("axebanestag");
            //string fileContents = File.ReadAllText("../../Scripts.");

            ScriptEngine engine = IronPython.Hosting.Python.CreateEngine();
            dynamic scope = engine.CreateScope();
            var searchPaths = engine.GetSearchPaths();
            searchPaths.Add(@"C:\Users\Dan\AppData\Local\Programs\Python\Python27\Lib");
            engine.SetSearchPaths(searchPaths);

            TestClass myTest = new TestClass(123);
            scope.SetVariable("passedVariable", myTest);
            TestClass myClass = (TestClass)engine.ExecuteFile(@"..\..\Scripts\TestCard.py", scope).returnVal;

        }
    }
}
