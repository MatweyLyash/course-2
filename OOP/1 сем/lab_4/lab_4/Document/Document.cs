using System;

namespace lab_4
{
    public interface IDocument
    {
        public void PrintDocument();
        //public int D {  get; set; }//можно задать не5которые условия

        //{
        //    Console.WriteLine("sdfgh");
        //}
    }
        public abstract class Document : DataAndOrganization, IDocument
        {
        public int Id { get; set; } = 0;
        public Document(DateTime dateTime, string orgname, int id) : base(dateTime, orgname)
        {
            Id = id;
        }


        public override string ToString()
        {
            return $"ID: {Id}, Organization: {Name} , Date: {Date} ";
        }

        public void PrintDocument(string newOrg)
        {
            Console.WriteLine($"ID: {Id}, Organization: {newOrg} , Date: {Date} ");
        }
        public abstract void PrintDocument();

    }
}