using System;
using System.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;


namespace Lab_2
{
    partial class House
    {

        public static int staticVar = 0;
        const int myVariant = 7;
        public readonly Guid id = new Guid();
        static int housesAmount = 0;
        private int number;
        private int area;
        private int floor;
        private int amountRoom;
        private string region;
        public string street;
        public House()
        {
            housesAmount++;
        }
        public House(int number, int area, int floor, int amountRoom, string region, string street)
        {
            this.number = number;
            this.area = area;
            this.floor = floor;
            this.amountRoom = amountRoom;
            this.region = region;
            this.street = street;

        }
        public House(string street = "Beloruskaya")
        {
            this.street = street;
        }
        static House()
        {
            staticVar=0;
        }


      


        
    }

  

}