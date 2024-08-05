using System;
using System.Collections;

namespace lab_4
{
    public interface IDocument
    {
        public void PrintDocument();
    }
    public abstract class Document : DataAndOrganization, IDocument
    {
        public enum ETypeOfDocument
        { 
                 CHECK = 323423432 ,WAYBILL = 423423342 , RECEIPT = 12323245 
        };

        public ETypeOfDocument typeOfDocument {  get; set; }     
        
        public int Id { get; set; }
        

        public Document(DateTime dateTime, string orgname, int id, ETypeOfDocument type) : base(dateTime, orgname)
        {
            Id = id;
            typeOfDocument = type;

        }
        public override string ToString()
        {
            return $"ID: {Id}, Organization: {DataInfo.Name} , Date: {DataInfo.Date} ";
        }

        public void PrintDocument(string newOrg)
        {
            Console.WriteLine($"ID: {Id}, Organization: {newOrg} , Date: {DataInfo.Date} ");
        }
        public abstract void PrintDocument();

    }
}