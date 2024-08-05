using System;

namespace lab_4
{
     sealed partial  class Waybill:Document
    {
        
        public Waybill(DateTime dateTime, string orgname, ETypeOfDocument type, int id, int price, string nameOfProduct):base(dateTime, orgname, id , type) 
        {
            if (price < 0)
            {
                throw new NegativeCost(1,". lfey", price);
            }
            Price = price;
            NameOfProduct = nameOfProduct;

        }

        public override void PrintDocument()
        {
            Console.WriteLine($"Doc id :{Id},\nOrganization: {DataInfo.Name},\nDate: {DataInfo.Date},\ntype of service: {Price}");
        }
    }
}
