using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    public class Errors : Exception
    {
        private int Id {get;set;}
        private string ErrorName { get;set;}
        private string Couse { get;set;}
        
        public Errors()
        {
            Couse = "нельзя добавить отрицательное число";

        }
        public override string ToString()
        {
            return Couse;
        }


    }
}
