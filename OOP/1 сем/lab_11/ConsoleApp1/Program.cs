using System.Reflection;
using System;
using ConsoleApp1;

namespace lab_11
{
    public class Program
    {
       
        public static void Main(string[] args)
        {
            IEnumerable<string> publicMethdos = Reflector<TestClass>.GetPublicMethods();
            var FieldsAndPropetrys = Reflector<TestClass>.GetFieldAndProperty();
            IEnumerable<string> allInterfaces = Reflector<TestClass>.GetInterface();
            Console.WriteLine(Reflector<TestClass>.GetAssembly());
            Console.WriteLine(Reflector<TestClass>.IsHasPublicCtors());
            foreach (var item in publicMethdos)
            {
                Console.WriteLine(item);
            }
            foreach(var item in FieldsAndPropetrys.Item1)
            {
                Console.WriteLine(item);
            }
            foreach(var item in FieldsAndPropetrys.Item2)
            {
                Console.WriteLine(item);
            }
            foreach (var item in allInterfaces)
            {
                Console.WriteLine(item);
            }



        }
    }
}