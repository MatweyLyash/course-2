using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            //bool let1 = true;
            //sbyte let2 = 123;
            //short let3 = -12345;
            //int let4 = 123456789;
            //long let5 = 867857345758348;
            //byte let6 = 254;
            //ushort let7 = 12345;
            //uint let8 = 49537584;
            //ulong let9 = 9674556459994;
            //float let10 = 12.6738F;
            //double let11 = 32213.4523572267667D;
            //char let12 = 'Z';
            //decimal let13 = 123.12345664323456M;
            //string let14 = "How are you?";
            //object let15 = 101;
            //Console.WriteLine("Вывод значений:");
            //Console.WriteLine($"bool - {let1}\n" +
            //                  $"sbyte - {let2}\n" +
            //                  $"short - {let3}\n" +
            //                  $"int - {let4}\n" +
            //                  $"long - {let5}\n" +
            //                  $"byte - {let6}\n" +
            //                  $"ushort - {let7}\n" +
            //                  $"uint - {let8}\n" +
            //                  $"ulong - {let9}\n" +
            //                  $"float - {let10}\n" +
            //                  $"double - {let11}\n" +
            //                  $"char - {let12}\n" +
            //                  $"decimal - {let13}\n" +
            //                  $"string - {let14}\n" +
            //                  $"object - {let15}\n"
            //    );
            //Console.WriteLine("Ввод значений переменных: ");
            //Console.Write("bool: ");
            //let1 = bool.Parse(Console.ReadLine());
            //Console.Write("sbyte: ");
            //let2 = sbyte.Parse(Console.ReadLine());
            //Console.Write("short: ");
            //let3 = short.Parse(Console.ReadLine());
            //Console.Write("int: ");
            //let4 = int.Parse(Console.ReadLine());
            //Console.Write("long: ");
            //let5 = long.Parse(Console.ReadLine());
            //Console.Write("byte: ");
            //let6 = byte.Parse(Console.ReadLine());
            //Console.Write("ushort: ");
            //let7 = ushort.Parse(Console.ReadLine());
            //Console.Write("uint: ");
            //let8 = uint.Parse(Console.ReadLine());
            //Console.Write("ulong: ");
            //let9 = ulong.Parse(Console.ReadLine());
            //Console.Write("float: ");
            //let10 = float.Parse(Console.ReadLine());
            //Console.Write("double: ");
            //let11 = double.Parse(Console.ReadLine());
            //Console.Write("char: ");
            //let12 = char.Parse(Console.ReadLine());
            //Console.Write("decimal: ");
            //let13 = decimal.Parse(Console.ReadLine());
            //Console.Write("string: ");
            //let14 = (Console.ReadLine());
            //Console.Write("object: ");
            //let15 = (Console.ReadLine());

            //Console.WriteLine("Вывод значений:");
            //Console.WriteLine($"bool - {let1}\n" +
            //                  $"sbyte - {let2}\n" +
            //                  $"short - {let3}\n" +
            //                  $"int - {let4}\n" +
            //                  $"long - {let5}\n" +
            //                  $"byte - {let6}\n" +
            //                  $"ushort - {let7}\n" +
            //                  $"uint - {let8}\n" +
            //                  $"ulong - {let9}\n" +
            //                  $"float - {let10}\n" +
            //                  $"double - {let11}\n" +
            //                  $"char - {let12}\n" +
            //                  $"decimal - {let13}\n" +
            //                  $"string - {let14}\n" +
            //                  $"object - {let15}\n"
            //    );

            ////2

            //byte let16 = 132;
            //int let17 = (int)let16;
            //short let18 = (short)let16;
            //long let19 = (long)let16;
            //double let20 = (double)let16;
            //char let21 = (char)let16;
            //Console.WriteLine("Вывод явно преобразованных переменных");
            //Console.WriteLine($"int - {let17}\n" +
            //                  $"short - {let18} \n" +
            //                  $"long - {let19}\n" +
            //                  $"double - {let20}\n" +
            //                  $"char - {let21}\n"
            //                  );


            //byte let22 = 132;
            //short let23 = let22;
            //int let24 = let23;
            //long let25 = let24;
            //float let26 = let25;
            //double let27 = let26;
            //Console.WriteLine("Вывод неявно преобразованных переменных");
            //Console.WriteLine($"short - {let22}\n" +
            //                  $"int - {let23} \n" +
            //                  $"long - {let24}\n" +
            //                  $"float - {let25}\n" +
            //                  $"double - {let26}\n"
            //                  );
            //Console.WriteLine("Класс Convert: ");
            //int let28 = 1893;
            //double let29 = Convert.ToDouble(let28);
            //Console.WriteLine($"int     - {let28}\n" +
            //                  $"double  - {let29}\n"
            //              );
            ////1паковка 2паковка
            //long let30 = 9875456;
            //object let31 = let30;
            //let30 = (long)let31;

            //var let32 = "How";
            //Console.WriteLine($"{let32} are you?");


            //int? val = null;
            //if (val.HasValue)
            //{
            //    Console.WriteLine("теперь это число?");
            //}
            //else
            //{
            //    Console.WriteLine("null есть null");
            //}

            //var let33 = 4;
            ////let33 = 3.5f;
            ////Console.WriteLine($"{var36}");


            ////3
            //string string1 = "qwerty";
            //string string2 = "asdfghjkl";
            //if (string1 == string2)
            //{
            //    Console.WriteLine("Строки равны");
            //}
            //else
            //{
            //    Console.WriteLine("Строки не равны");
            //}
            //string string3 = "How";
            //string string4 = " are";
            //string string5 = "Wenn die soldaten durch die Stadt maschieren";
            //Console.WriteLine($"сцепление  - {string3 + string4}");
            //string strCopy = string3;
            //Console.WriteLine($"копирование - {strCopy}");
            //Console.WriteLine($"выделение подстроки с 2 по 4 - {string1.Substring(2, 4)} ");// с второго символа на 4

            //string[] Words = string5.Split(' ');
            //foreach (string word in Words)
            //{
            //    Console.WriteLine(word);
            //}

            //Console.WriteLine($"\nвставка строки в заданную позицию - {string3.Insert(2, string4)}");
            //Console.WriteLine($"удаление строки в заданной позиции - {string5.Remove(4, 4)}");


            //string string6 = "";
            //string string7 = null;
            //if (string.IsNullOrEmpty(string6))
            //{
            //    Console.WriteLine("Строка есть ноль или пуста");
            //}
            //else
            //{
            //    Console.WriteLine("Строка не ноль или пуста");
            //}
            //if (string.IsNullOrEmpty(string7))
            //{
            //    Console.WriteLine("Строка есть ноль или пуста");
            //}
            //else
            //{
            //    Console.WriteLine("Строка не ноль или пуста");
            //}


            //if (string.IsNullOrWhiteSpace(string6))
            //{
            //    Console.WriteLine("Строка есть ноль или пробел");
            //}
            //else
            //{
            //    Console.WriteLine("Строка не ноль или пробел");
            //}
            //if (string.IsNullOrWhiteSpace(string7))
            //{
            //    Console.WriteLine("Строка есть ноль или пробел");
            //}
            //else
            //{
            //    Console.WriteLine("Строка не ноль или пробел");
            //}

            //StringBuilder string8 = new StringBuilder("Builder build ");
            //string8.Append("string");
            //string8.Remove(8, 5);
            //string8.Insert(0, "aboba");
            //Console.WriteLine(string8);

            ////3

            //int[,] arr1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            //int rows = arr1.GetUpperBound(0) + 1;    // количество строк
            //int columns = arr1.Length / rows;
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        Console.Write(arr1[i, j]);
            //    }
            //    Console.Write("\n");
            //}
            //string[] arr2 = { "qwerty", "asdfgh", "zxcvbn" };
            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    Console.Write($" {arr2[i]}");
            //}
            //Console.WriteLine($"\n {arr2.Length}");
            //Console.WriteLine("Введите номер строки, которая будет перемещена");
            //int pos1;
            //pos1 = int.Parse(Console.ReadLine());



            //pos1 = pos1 - 1;
            //Console.WriteLine("Введите номер позиции, куда будет перемещена строка");
            //int pos2;
            //pos2 = int.Parse(Console.ReadLine());
            //pos2 -= 1;
            //string string10 = arr2[pos1];
            //arr2[pos1] = arr2[pos2];
            //arr2[pos2] = string10;
            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    Console.Write($"{arr2[i]} ");
            //}

            //double[][] jaggedArray = new double[3][];

           
            //for (int i = 0; i < jaggedArray.Length; i++)
            //{
            //    Console.WriteLine($"Введите {i + 1}-ую строку (количество столбцов): ");
            //    int columnsCount = int.Parse(Console.ReadLine());

            //    jaggedArray[i] = new double[columnsCount];

            //    Console.WriteLine($"Введите {columnsCount} числа для {i + 1}-ой строки:");
            //    for (int j = 0; j < columnsCount; j++)
            //    {
            //        jaggedArray[i][j] = double.Parse(Console.ReadLine());
            //    }
            //}

            
            //Console.WriteLine(" ступенчатый массив:");
            //for (int i = 0; i < jaggedArray.Length; i++)
            //{
            //    for (int j = 0; j < jaggedArray[i].Length; j++)
            //    {
            //        Console.Write(jaggedArray[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //var arr4 = new double[] { 1, 2, 3, 4, 5.5 };
            //var string11 = new string[] { "qwertyu" };


        }
         



    }
}
