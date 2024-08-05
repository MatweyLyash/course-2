using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    public class Accountant<T> where T : Document
    {
        List<T> list = new List<T>() ;
      
        public Accountant(params Document[] documents)
        {
            foreach (T document in documents)
            {
                list.Add(document);
            }
        }

        public void AddDoc(T document)
        {
            list.Add(document);
        }
        public void RemoveDoc(T document)
        {
            list.Remove(document);
        }

     
        public void PrintDoc()
        {
            foreach (T item in list)
            {
                Console.WriteLine($"{item}");

            }
            
        }

        public int SumCost(string productName)
        {
            int sum = 0;
            foreach (T item in list)
            {
                if (item.typeOfDocument == Document.ETypeOfDocument.WAYBILL)
                {
                   if(((Waybill)((object)item)).NameOfProduct == productName)
                    {
                        sum += ((Waybill)((object)item)).Price;
                    }
                }
            }
            return sum;
        }

        
        public int AmountCheck()
        {
            int amount = 0;
            foreach (T item in list)
            {
                if (item.typeOfDocument == Document.ETypeOfDocument.CHECK)
                {
                    amount++;
                }

            }
            return amount;

        }

    }

    public class Controller<T> : Accountant<T> where T : Document
    {
        public  Accountant<T> container = new Accountant<T>();
            
        public void AddDocument(T document)
        {
            container.AddDoc(document);
        }
        public void RemoveDocumnet(T document)
        {
            container.RemoveDoc(document);
        }
        public void PrintDocument()
        {
            container.PrintDoc();
        }
        public int SumCostDoc(string productName)
        {
            Console.WriteLine(container.SumCost(productName)); 
            return 0;
        }
        public int AmountOfCheck()
        {
            Console.WriteLine(container.AmountCheck());
            
            return 0; 
        }


    }

}
