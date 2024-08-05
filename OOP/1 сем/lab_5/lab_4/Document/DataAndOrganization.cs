using System;

namespace lab_4
{//как инт чтобы стал в куче
    public abstract class DataAndOrganization
    {
        
        public  struct Info
        {
            public DateTime Date { get; set; }
            public string Name  { get ; set; }
            public Info(DateTime date, string name)
            {
                Date = date;
                Name = name;
            }
        }
        public Info DataInfo { get; set; }
        public DataAndOrganization(DateTime dateTime, string orgName)
        {
            DataInfo = new Info(dateTime, orgName);
        }
    }

}