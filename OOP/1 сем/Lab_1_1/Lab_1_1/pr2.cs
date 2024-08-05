using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class pr2
    {
        public static void FuncStrings()
        {
            string string1 = "qwerty";
            string string2 = "asdfghjkl";
            if (string1 == string2)
            {
                Console.WriteLine("Строки равны");
            }
            else
            {
                Console.WriteLine("Строки не равны");
            }
        }
        public static void FuncStrings2()
        {
            string string1 = "qwerty";
            string string3 = "How";
            string string4 = " are";
            string string5 = "Wenn die soldaten durch die Stadt maschieren";
            Console.WriteLine($"сцепление  - {string3 + string4}");
            string strCopy = string3;
            Console.WriteLine($"копирование - {strCopy}");
            Console.WriteLine($"выделение подстроки с 2 по 4 - {string1.Substring(2, 4)} ");// с второго символа на 4

            string[] Words = string5.Split(' ');
            foreach (string word in Words)
            {
                Console.WriteLine(word);
            }

            Console.WriteLine($"\nвставка строки в заданную позицию - {string3.Insert(2, string4)}");
            Console.WriteLine($"удаление строки в заданной позиции - {string5.Remove(4, 4)}");


        }
        public static void FuncStrings3()
        {
            string string6 = "";
            string string7 = null;
            if (string.IsNullOrEmpty(string6))
            {
                Console.WriteLine("Строка есть ноль или пуста");
            }
            else
            {
                Console.WriteLine("Строка не ноль или пуста");
            }
            if (string.IsNullOrEmpty(string7))
            {
                Console.WriteLine("Строка есть ноль или пуста");
            }
            else
            {
                Console.WriteLine("Строка не ноль или пуста");
            }


            if (string.IsNullOrWhiteSpace(string6))
            {
                Console.WriteLine("Строка есть ноль или пробел");
            }
            else
            {
                Console.WriteLine("Строка не ноль или пробел");
            }
            if (string.IsNullOrWhiteSpace(string7))
            {
                Console.WriteLine("Строка есть ноль или пробел");
            }
            else
            {
                Console.WriteLine("Строка не ноль или пробел");
            }
        }
        public static void FuncStrings4()
        {
            StringBuilder string8 = new StringBuilder("Builder build ");
            string8.Append("string");
            string8.Remove(8, 5);
            string8.Insert(0, "aboba");
            Console.WriteLine(string8);
        }

    }
}
