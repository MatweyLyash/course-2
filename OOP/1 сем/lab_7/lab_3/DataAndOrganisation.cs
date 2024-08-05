using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    public abstract class DataAndOrganization
    {
        public DateTime Date { get; set; } = DateTime.Now;
        public string Name { get; set; } = "Unnamed";


        public DataAndOrganization(DateTime dateTime, string orgname)
        {
            Date = dateTime;
            Name = orgname;
        }
        public override string ToString()
        {
            return Name;
        }
    }
    public abstract class Document : DataAndOrganization
    {
        public int Id { get; set; } = 0;
        public Document(DateTime dateTime, string orgname, int id) : base(dateTime, orgname)
        {
            Id = id;
        }

    }
    public sealed class Receipt : Document
    {
        public string Customer { get; set; }
        public DateTime DataTime { get; set; }
        public Receipt(DateTime dateTime, string orgname, int id, string buyer) : base(dateTime, orgname, id)
        {
            Customer = buyer;
            DataTime =dateTime;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, {DataTime.ToString()}";
        }
    }
}
