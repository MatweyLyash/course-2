using System;

namespace lab_4
{
    public abstract  class DataAndOrganization
    {
        public DateTime Date { get; set; } = DateTime.Now;
        public string Name { get; set; } = "Unnamed";


        public DataAndOrganization(DateTime dateTime, string orgname)
        {
            Date = dateTime;
            Name = orgname;
        }


    }
}