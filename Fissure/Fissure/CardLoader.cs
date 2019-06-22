using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fissure.Components;
using Microsoft.Scripting.Hosting;

namespace Fissure
{
    public class CardLoader
    {
        private ScriptEngine _scriptEngine;
        private string _baseDirectory;
        private dynamic _scope;

        public CardLoader(string baseDirectory) // @"C:\Users\Dan\AppData\Local\Programs\Python\Python27\Lib"
        {
            _baseDirectory = baseDirectory;
            _scriptEngine = IronPython.Hosting.Python.CreateEngine();
            _scope = _scriptEngine.CreateScope();

            ICollection<string> searchPaths = _scriptEngine.GetSearchPaths();
            searchPaths.Add(baseDirectory);
            _scriptEngine.SetSearchPaths(searchPaths);
        }

        public Card LoadCard(string cardName)
        {          
            return (Card)_scriptEngine.ExecuteFile($"{_baseDirectory}\\{cardName}.py", _scope).returnVal; // @"..\..\Scripts\TestCard.py"
        }
    }
}
