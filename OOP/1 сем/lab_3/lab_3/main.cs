using Lab_3;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
     class Program
    {
        public static void Main(string[] argv)
        {
            Set<int> set1 = new Set<int>(4, 1,2,3,4);
            Set<int> set2 = new Set<int>(3, 1,5,4);
            foreach (int item in set1)
            {
                Console.WriteLine(item);
            }
            set1.Add(10);

            set1.Print();
            set1++;
            set1.Print();
            set1 = set1 + set2;
            set1.Print();
            Console.WriteLine(set1<=set2);
            Console.WriteLine((int)set1);
            Console.WriteLine(set1%3);

            Set<string> strSet = new Set<string>(4, "bstu", "github", "bс", "абоба");
            Console.WriteLine(strSet.EncryptString());


            Production production = new Production("pavelPivo.Interteiment");
            production.Print();
            Production.Developer matwa = new Production.Developer("pasha",6);
            matwa.DevPrint();
            set2.Sorted(set2);
            
        }
    }
}
