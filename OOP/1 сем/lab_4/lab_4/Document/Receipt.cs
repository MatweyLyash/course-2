using System;

namespace lab_4
{
    public sealed class Receipt:Document
    {
         public string Customer {  get; set; }

        public Receipt(DateTime dateTime, string orgname, int id, string buyer): base(dateTime, orgname, id) 
        {
            Customer = buyer;   
        }

        public override void PrintDocument()
        {
            Console.WriteLine($"Doc id :{Id},\nOrganization: {Name},\nDate: {Date},\nName of buyer: {Customer}");
        }
    }
}
