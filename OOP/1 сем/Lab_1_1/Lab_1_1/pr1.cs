using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    public class pr1
    {
        public static void FuncTypes()
        {
            bool let1 = true;
            sbyte let2 = 123;
            short let3 = -12345;
            int let4 = 123456789;
            long let5 = 867857345758348;
            byte let6 = 254;
            ushort let7 = 12345;
            uint let8 = 49537584;
            ulong let9 = 9674556459994;
            float let10 = 12.6738F;
            double let11 = 32213.4523572267667D;
            char let12 = 'Z';
            decimal let13 = 123.12345664323456M;
            string let14 = "How are you?";
            object let15 = 101;
            Console.WriteLine("Вывод значений:");
            Console.WriteLine($"bool - {let1}\n" +
                              $"sbyte - {let2}\n" +
                              $"short - {let3}\n" +
                              $"int - {let4}\n" +
                              $"long - {let5}\n" +
                              $"byte - {let6}\n" +
                              $"ushort - {let7}\n" +
                              $"uint - {let8}\n" +
                              $"ulong - {let9}\n" +
                              $"float - {let10}\n" +
                              $"double - {let11}\n" +
                              $"char - {let12}\n" +
                              $"decimal - {let13}\n" +
                              $"string - {let14}\n" +
                              $"object - {let15}\n"
                );
            Console.WriteLine("Ввод значений переменных: ");
            Console.Write("bool: ");
            let1 = bool.Parse(Console.ReadLine());
            Console.Write("sbyte: ");
            let2 = sbyte.Parse(Console.ReadLine());
            Console.Write("short: ");
            let3 = short.Parse(Console.ReadLine());
            Console.Write("int: ");
            let4 = int.Parse(Console.ReadLine());
            Console.Write("long: ");
            let5 = long.Parse(Console.ReadLine());
            Console.Write("byte: ");
            let6 = byte.Parse(Console.ReadLine());
            Console.Write("ushort: ");
            let7 = ushort.Parse(Console.ReadLine());
            Console.Write("uint: ");
            let8 = uint.Parse(Console.ReadLine());
            Console.Write("ulong: ");
            let9 = ulong.Parse(Console.ReadLine());
            Console.Write("float: ");
            let10 = float.Parse(Console.ReadLine());
            Console.Write("double: ");
            let11 = double.Parse(Console.ReadLine());
            Console.Write("char: ");
            let12 = char.Parse(Console.ReadLine());
            Console.Write("decimal: ");
            let13 = decimal.Parse(Console.ReadLine());
            Console.Write("string: ");
            let14 = (Console.ReadLine());
            Console.Write("object: ");
            let15 = (Console.ReadLine());

            Console.WriteLine("Вывод значений:");
            Console.WriteLine($"bool - {let1}\n" +
                              $"sbyte - {let2}\n" +
                              $"short - {let3}\n" +
                              $"int - {let4}\n" +
                              $"long - {let5}\n" +
                              $"byte - {let6}\n" +
                              $"ushort - {let7}\n" +
                              $"uint - {let8}\n" +
                              $"ulong - {let9}\n" +
                              $"float - {let10}\n" +
                              $"double - {let11}\n" +
                              $"char - {let12}\n" +
                              $"decimal - {let13}\n" +
                              $"string - {let14}\n" +
                              $"object - {let15}\n"
                );
        }

         public static void FuncTypes2()
        {
            byte let16 = 132;
            int let17 = (int)let16;
            short let18 = (short)let16;
            long let19 = (long)let16;
            double let20 = (double)let16;
            char let21 = (char)let16;
            Console.WriteLine("Вывод явно преобразованных переменных");
            Console.WriteLine($"int - {let17}\n" +
                              $"short - {let18} \n" +
                              $"long - {let19}\n" +
                              $"double - {let20}\n" +
                              $"char - {let21}\n"
                              );


            byte let22 = 132;
            short let23 = let22;
            int let24 = let23;
            long let25 = let24;
            float let26 = let25;
            double let27 = let26;
            Console.WriteLine("Вывод неявно преобразованных переменных");
            Console.WriteLine($"short - {let22}\n" +
                              $"int - {let23} \n" +
                              $"long - {let24}\n" +
                              $"float - {let25}\n" +
                              $"double - {let26}\n"
                              );
            Console.WriteLine("Класс Convert: ");
            int let28 = 1893;
            double let29 = Convert.ToDouble(let28);
            Console.WriteLine($"int     - {let28}\n" +
                              $"double  - {let29}\n"
                          );
        }
        public static void FuncTypes3()
        {
            ////1паковка 2паковка
            long let30 = 9875456;
            object let31 = let30;
            let30 = (long)let31;
        }
        public static void FuncTypes4()
        {
            var let32 = "How";
            Console.WriteLine($"{let32} are you?");

        }
        public static void FuncTypes5()
        {
            int? val = null;
            if (val.HasValue)
            {
                Console.WriteLine("теперь это число?");
            }
            else
            {
                Console.WriteLine("null есть null");
            }
        }
        public static void FuncTypes6()
        {
            //var let33 = 4;
            //let33 = 3.5f;
            //Console.WriteLine($"{var36}");
        }

    }
}
