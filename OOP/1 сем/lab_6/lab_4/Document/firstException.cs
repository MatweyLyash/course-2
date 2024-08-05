using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    public class NegativeCost:Excetpions
    {
        public int BadCost { get; set; }
        public NegativeCost(int code, string message, int price):base(code, message)
        {
            BadCost = price;
            
        }
        public override string ToString()
        {
            return base.ToString() + $" йор кост ис андефайнед(вэри бэд) - {BadCost}";
        }

    }
}
