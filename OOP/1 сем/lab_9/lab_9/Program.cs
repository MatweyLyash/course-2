using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace lab_9 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PO<Software> softwares = new PO<Software>();
            Software draw  = new Software("Paint");
            softwares.Add(draw);
            SortedList sortedList = new SortedList();
            sortedList.Add(1, draw);
            foreach (var item in sortedList)
            {
                Console.WriteLine(item);
            }
            Software doc = new Software("MS Word");
            Software calc = new Software("MS Calc");
            sortedList.Add(2,doc);
            sortedList.Add(3,calc);
            int []valueDel = {1,2};
            foreach(var item in valueDel) 
            {
                sortedList.Remove(item);
            }
            foreach (var item in sortedList)
            {
                Console.WriteLine(item);
            }
            List<Dictionary<int,int>> list = new List<Dictionary<int,int>>();

            var dict_1 = new Dictionary<int,int>();
            var dict_2 = new Dictionary<int,int>();
            list.Add(dict_1);
            list.Add(dict_2);   

            ObservableCollection<int> collec = new ObservableCollection<int>();
            collec.CollectionChanged += (sender, e) =>
            {
                Console.WriteLine("hello niger!");
            };
            collec.Add(1);





        }
    }
   
}
