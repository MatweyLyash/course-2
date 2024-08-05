using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartage
{
    internal class Pr4
    {
        public static void FuncCar()
        {
            var pavelPivo = (Name: "Matwa", age: 54, sex: 'm', group: "poit", amount: 6776547656776);
            Console.WriteLine(pavelPivo);
            Console.WriteLine($"Выборочно - {pavelPivo.Name},{pavelPivo.group},{pavelPivo.amount} ");
            (string Name, int age) = (pavelPivo.Name, pavelPivo.age);
            var (sex, group) = (pavelPivo.sex, pavelPivo.group);
            string gr = (pavelPivo.group);
            var (_, _, pu, _, _) = pavelPivo;
            var mag = (1, "ggg");
            var mag2 = (2, "ggg");
            var mag3 = (1, "hhh");
            bool result = mag2 != mag3;
        }
      
    }
}
