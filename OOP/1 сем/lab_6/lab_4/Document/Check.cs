using System;

namespace lab_4
{
    public sealed class Check : Document
    {
        public int PriceOfCheck { get; set; } = 0;
        public Check(DateTime dateTime, string orgname, ETypeOfDocument type, int id, int price) : base(dateTime, orgname, id, type)
        {
            PriceOfCheck = price;
        }
        public override void PrintDocument()
        {
            Console.WriteLine($"Doc id :{Id},\nOrganization: {DataInfo.Name},\nDate: {DataInfo.Date},\nPrice:{PriceOfCheck}$");
        }
    }
}