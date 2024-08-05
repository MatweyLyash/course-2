using lab_10.Lab_2;
using System;
using System.Numerics;


namespace lab_10
{

    public class Program
    {
        public static void Main(string[] args)
        {
            string[] month = { "Студзень", "Люты", "Сакавік", "Красавік", "Травень", "Чэрвень", "Ліпень", "Жнівень", "Верасень", "Кастрычнык", "Лістапад", "Снежань" };
            int n = int.Parse(Console.ReadLine());
            var selectedMonth = new List<string>();
            foreach (var item in month)
            {
                if (item.Length == n)
                {
                    selectedMonth.Add(item);
                }
            }
            foreach (var item in selectedMonth)
            {
                Console.WriteLine(item);
            }
            var summerWinter = new List<string>();
            foreach (var item in month)
            {
                if (item == "Снежань" || item == "Студзень" || item == "Люты" || item == "Чэрвень" || item == "Ліпень" || item == "Жнівень")
                {
                    summerWinter.Add(item);
                }
            }
            foreach (var item in summerWinter)
            {
                Console.WriteLine(item);
            }
            var AlphabetOrder = new List<string>();
            for (int aCode = 1040; aCode < 1072; aCode++)
            {
                foreach (var item in month)
                {
                    if (item.ToUpper().StartsWith((char)aCode))
                    {
                        AlphabetOrder.Add(item);
                    }

                }
            }
            Console.WriteLine("алфавитный порядок");
            foreach (var item in AlphabetOrder)
            {
                Console.WriteLine(item);
            }


            List<House> houses = new List<House>();
            houses.Add(new House(1, 24, 3, 2, "Minsk", "BB", 3));
            houses.Add(new House(2, 26, 2, 3, "Grodno", "AA", 3));
            houses.Add(new House(3, 28, 7, 4, "Grodno", "BB", 3));
            houses.Add(new House(4, 30, 2, 1, "Minsk", "DD", 3));
            houses.Add(new House(5, 32, 5, 3, "Minsk", "BB", 3));
            houses.Add(new House(6, 34, 4, 2, "Grodno", "AA", 3));
            houses.Add(new House(7, 36, 1, 2, "Minsk", "BB", 3));
            houses.Add(new House(8, 38, 8, 3, "Grodno", "CC", 3));
            houses.Add(new House(9, 40, 3, 5, "Minsk", "BB", 3));
            houses.Add(new House(9, 40, 3, 5, "Minsk", "BB", 3));
            List<Compa> companies = new List<Compa>();
            companies.Add(new Compa("Minsk", "DD", "ZVZVZVZ"));
            companies.Add(new Compa("Moghilev", "AA", "BAM-BAM"));

            var givenAmountRoom = houses.Where(h => h.amountRoom == 5);
            foreach (var item in givenAmountRoom)
            {
                item.Vyvod();
            }
            Console.WriteLine("second");
            var givenStreetAndHousesAmount = houses.Where(h => h.street == "BB" && h.housesAmount == 3).Take(5);
            foreach (var item in givenStreetAndHousesAmount)
            {
                item.Vyvod();
            }
            Console.WriteLine("third");
            var givenStreet = houses.Where(h => h.street == "AA");
            Console.WriteLine(givenStreet.Count());
            var givenGap = houses.Where(h => h.amountRoom == 2 && h.floor < 8 && h.floor > 2);
            foreach (var item in givenGap)
            {
                item.Vyvod();
            }
            //var forthTask = houses.Where(h=>h.number>=1).OrderBy(h=> h.street).GroupBy(h=>h.region);
            //foreach (var item in forthTask) {
            //    item.Vyvod();
            //}
            var joined = houses.Join(
                companies,
                house => house.region,
                company => company.region,
                (house, company) => house
                );
           


        }
    }
}