using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IClass { }
    internal class TestClass : IClass
    {
      

        public int testfield;
        public int TestProperty {  get; set; }

        public TestClass()
        {
            
        }

        public TestClass(int testvalue)
        {
            testfield = testvalue;
        }

        public void TestMethod()
        {
            int test = 6;
        }

    }
}
