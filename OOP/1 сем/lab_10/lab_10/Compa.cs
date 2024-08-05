using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_10
{
    internal class Compa
    {
        public string region;
        public string street;
        public string name;
        public Compa(string region, string street, string name)
        {
            this.name = name;
            this.region = region;   
            this.street = street;
        }
    }
}
