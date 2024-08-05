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
        public static void Main(string[] args)
        {
            try
            {
                CollectionType<int> set1 = new CollectionType<int>(1,2,3,4);
                set1.Show();
                Console.WriteLine();
                CollectionType<double> set2 = new CollectionType<double>(2.34, 345.1212);
                set2.Show();
                Console.WriteLine();
                CollectionType<DataAndOrganization> set3 = new CollectionType<DataAndOrganization>();
                DateTime dateTime = DateTime.Now;
                set3.AddElement(new Receipt(dateTime, "BSTU", 24, "Nigger"));
                set3.Show();
                try
                {
                    int negativeNumber = -8;
                    if (negativeNumber < 0)
                    {
                        throw new Errors();
                    }
                    set1.AddElement(negativeNumber);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex);
                }
                

                set1.WriteToFile("file.txt");
                set1.ReadFromFile("file.txt");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("end");
            }
           
            
        }
    }
}
