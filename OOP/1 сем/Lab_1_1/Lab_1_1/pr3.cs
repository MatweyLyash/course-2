using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Pr3
    {
        public static void FuncArrys()
        {
            int[,] arr1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int rows = arr1.GetUpperBound(0) + 1;    // количество строк
            int columns = arr1.Length / rows;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(arr1[i, j]);
                }
                Console.Write("\n");
            }
        }
        public static void FuncArrys2()
        {
            string[] arr2 = { "qwerty", "asdfgh", "zxcvbn" };
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write($" {arr2[i]}");
            }
            Console.WriteLine($"\n {arr2.Length}");
            Console.WriteLine("Введите номер строки, которая будет перемещена");
           
        }
        public static void FuncArrys3()
        {
            string[] arr2 = { "qwerty", "asdfgh", "zxcvbn" };
            int pos1;
            pos1 = int.Parse(Console.ReadLine());
            pos1 = pos1 - 1;
            Console.WriteLine("Введите номер позиции, куда будет перемещена строка");
            int pos2;
            pos2 = int.Parse(Console.ReadLine());
            pos2 -= 1;
            string string10 = arr2[pos1];
            arr2[pos1] = arr2[pos2];
            arr2[pos2] = string10;
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write($"{arr2[i]} ");
            }

        }
        public static void FuncArrys4()
        {
            double[][] jaggedArray = new double[3][];


            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.WriteLine($"Введите {i + 1}-ую строку (количество столбцов): ");
                int columnsCount = int.Parse(Console.ReadLine());

                jaggedArray[i] = new double[columnsCount];

                Console.WriteLine($"Введите {columnsCount} числа для {i + 1}-ой строки:");
                for (int j = 0; j < columnsCount; j++)
                {
                    jaggedArray[i][j] = double.Parse(Console.ReadLine());
                }
            }


            Console.WriteLine(" ступенчатый массив:");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }

        }
        public static void FuncArrys5()
        {
            var arr4 = new double[] { 1, 2, 3, 4, 5.5 };
            var string11 = "qwertyu"; 
        }
    }
}
