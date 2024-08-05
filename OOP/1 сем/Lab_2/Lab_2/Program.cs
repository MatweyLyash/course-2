using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab_2
{
    public class Program
    {
        

        public static void Main(string[] args)
        {
            var h = new { number = 2, area = 50, floor = 4 };


            
            var blockOfFlet = new House(228,144,6,2,"pershamaiskaya", "belorusskaya");
            House blockOf  = new House();
            House block = new House();

            blockOfFlet.Vyvod();
           Console.WriteLine( blockOfFlet.Equals(blockOf));
            blockOf.SetGetArea = 228;
            blockOf.SetGetRooms = 1;
            blockOf.SetGetNumber = 2;
            blockOf.SetGetRegion = "aboba";
            blockOf.SetGetStreet = "bibaIboba";
            block.SetGetFloor = 1;

            Console.WriteLine(blockOfFlet.GetType());
            block.SetGetRegion ="Soviet";
            block.SetGetNumber = 3; ;
            block.SetGetStreet ="Stasikauskaya" ;
            block.SetGetRooms = 2;
            block.SetGetArea = 45;
            block.SetGetFloor = 4;
            object[] arrObj = new House[] {blockOfFlet, blockOf, block};
            int kiu =Convert.ToInt32( Console.ReadLine());
            
            foreach (House house in arrObj)
            {
                if (house.Find(kiu))
                {
                    house.Vyvod();
                } 
            }
            int intervalA = Convert.ToInt32( Console.ReadLine());
            int intervalB = Convert.ToInt32( Console.ReadLine());
            foreach (House house in arrObj)
            {
                if (house.Find(kiu) && house.Choise(intervalA, intervalB))
                    house.Vyvod ();
            }






        }
    }
}
