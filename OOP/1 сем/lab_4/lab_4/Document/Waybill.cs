using System;

namespace lab_4
{
    public sealed class Waybill:Document
    {
        public string ArtOfService {  get; set; }   
        
        public Waybill(DateTime dateTime, string orgname, int id, string art):base(dateTime, orgname, id) 
        {
            ArtOfService = art;
        }

        public override void PrintDocument()
        {
            Console.WriteLine($"Doc id :{Id},\nOrganization: {Name},\nDate: {Date},\ntype of service: {ArtOfService}");
        }
    }
}
