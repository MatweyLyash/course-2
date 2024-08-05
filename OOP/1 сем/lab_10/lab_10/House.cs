using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_10
{
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
            public int housesAmount;
            public int number;
            public int area;
            public int floor;
            public int amountRoom;
            public string region;
            public string street;
            public House()
            {
                housesAmount++;
            }
            public House(int number, int area, int floor, int amountRoom, string region, string street, int housesAmount)
            {
                this.number = number;
                this.area = area;
                this.floor = floor;
                this.amountRoom = amountRoom;
                this.region = region;
                this.street = street;
                this.housesAmount = housesAmount;

            }
            public House(string street = "Beloruskaya")
            {
                this.street = street;
            }
            static House()
            {
                staticVar = 0;
            }
            public void Vyvod()
            {
                Console.WriteLine($"номер {number} , площадь {area} , этаж {floor}, кол-во комнат {amountRoom}, область {region}, улица {street}, номер дома {housesAmount}");
            }
        }



    }
}
