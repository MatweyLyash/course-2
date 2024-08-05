using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalFunc
{
    internal class Pr6
    {
        public static void t_Main()
        {

            static (int max, int min, int result, char firstLetter) Message(int[] arr, string str)
            {
                int min = arr[0];
                int max = arr[0];
                int result = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] < min)
                    {

                        min = arr[i];
                    }
                }
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > max)
                    {

                        max = arr[i];
                    }
                }
                result = min + max;
                char firstLetter = str[0];
                return (max, min, result, firstLetter);



            }
            int[] arr = { 2, 1, 4, 5, 3 };
            string str = "qwerty";
            var total = Message(arr, str);
            Console.WriteLine(total);
        }
        public static void chech()
        {
            void Check()
            {
                checked
                {
                
                        //int a = int.MaxValue+1;
                        //Console.WriteLine(a);
                }


            }
            void Uncheck()
            {

                unchecked
                {
                    int a = int.MaxValue + 1;
                    Console.WriteLine(a);
                }

            }
            Check();
            Uncheck();
        }

    }
}
