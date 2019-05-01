using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fissure
{
    public class TestClass
    {
        public int _myInt;
        public TestClass(int myInt)
        {
            _myInt = myInt;
        }

        public override string ToString()
        {
            return _myInt.ToString() + "!";
        }
    }
}
