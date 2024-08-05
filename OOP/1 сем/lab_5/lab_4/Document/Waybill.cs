using System;

namespace lab_4
{
     sealed partial  class Waybill:Document
    {
        
        public Waybill(DateTime dateTime, string orgname, ETypeOfDocument type, int id, int price, string nameOfProduct):base(dateTime, orgname, id , type) 
        {
            Price = price;
            NameOfProduct = nameOfProduct;

        }

        public override void PrintDocument()
        {
            Console.WriteLine($"Doc id :{Id},\nOrganization: {DataInfo.Name},\nDate: {DataInfo.Date},\ntype of service: {Price}");
        }
    }
}
