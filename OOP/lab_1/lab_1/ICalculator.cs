using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    public interface ICalculator
    {
        public void Clear(RichTextBox textBox);
        public double Add(double first, double second);
        public double Multi(double first, double second);
        public double Division(double first, double second);
        public double Minus(double first, double second);
        public double Cell(double first, double second);
        public double Rest(double first, double second);
    }
}
