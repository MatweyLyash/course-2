using System;

namespace lab_4
{
    public sealed class Receipt:Document
    {
         public string Customer {  get; set; }

        public Receipt(DateTime dateTime, string orgname, ETypeOfDocument type, int id, string buyer): base(dateTime, orgname, id, type) 
        {
            Customer = buyer;   
        }

        public override void PrintDocument()
        {
            Console.WriteLine($"Doc id :{Id},\nOrganization: {DataInfo.Name},\nDate: {DataInfo.Date},Type: {ETypeOfDocument.RECEIPT}\nName of buyer: {Customer}");
        }
    }
}
