using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    partial class House
    {
        public static int HowOldBuild(DateTime exploitation)
        {
            DateTime CurrentDate = DateTime.Now;
            TimeSpan dataExploitation = CurrentDate - exploitation;
            return dataExploitation.Days / 365;
        }

        public override int GetHashCode()
        {
            return number.GetHashCode() + area.GetHashCode() * (int)'z';
        }
        public override string ToString()
        {
            return region.ToString()+street.ToString();
        }
        public override bool Equals(object? obj)
        {
            if(obj == null) return false;
            House bgtu = (House) obj;
            return bgtu.number == number;
        }


        public int SetGetArea
        {
            set { area = value; }
            get { return area; }
        }
        public int SetGetRooms
        {
            set { amountRoom = value; }
            get { return amountRoom; }
        }
        public int SetGetNumber
        {
            set {  number = value; }
            get { return number; }
        }
        public string SetGetRegion
        {
            set { region = value; }
            get { return region;  }
        }
        public string SetGetStreet
        {
            set { street = value; }
            get { return street; }
        }
        public int SetGetFloor
        {
            set { floor = value; }
            get { return floor; }
        }
        public int Refaction(ref int number, ref int area, out int result) 
        {
            result = number * area;
            return result;
        }

        public void Vyvod()
        {
            Console.WriteLine($"номер {number} , площадь {area} , этаж {floor}, кол-во комнат {amountRoom}, область {region}, улица {street}");
        }
        public bool Find(int kiu)
        {
            if (amountRoom == kiu)
            {
                return true;

            }
            else
            {
                return false;
            }

        }
        public bool Choise(int intervalA, int intervalB)
        {
            if(floor>intervalA&&floor<intervalB)
            {
                return true;
            }
            else
            {
                return false; 
            }
        }
        




    }
}
