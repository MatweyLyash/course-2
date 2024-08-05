using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab_3
{
    public class Production
    {
        private readonly Guid id = Guid.NewGuid();
        private string nameOrganis { get; set; }
        public Production(string nameOrganis) {
        this.nameOrganis = nameOrganis;
        }
        public void Print()
        {
            Console.WriteLine($"name - {nameOrganis}, id - {id}");
        }
        static private int getRand()
        {
            Random rand = new Random();
            return rand.Next();
        }
        public class Developer
        {
            
            private string devName { get; set; }
            private int devId = getRand();
            private int groupNum { get; set; }
            public Developer(string devName, int groupNum) 
            {
                this.devName = devName;
                this.groupNum = groupNum;
            }
            
            public void DevPrint()
            {
                Console.WriteLine($"devName - {devName}, devId - {devId}, groupName - {groupNum}");
            }

        }



    }
}
