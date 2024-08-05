using System;

namespace lab_4
{
    public sealed class Check : Document
    {
        public int PriceOfCheck { get; set; } = 0;
        public Check(DateTime dateTime, string orgname, int id, int price) : base(dateTime, orgname, id)
        {
            PriceOfCheck = price;
        }
        public override void PrintDocument()
        {
            Console.WriteLine($"Doc id :{Id},\nOrganization: {Name},\nDate: {Date},\nPrice:{PriceOfCheck}$");
        }
    }
}