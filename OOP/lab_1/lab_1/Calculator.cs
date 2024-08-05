using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    public class Calculator:ICalculator
    {

        public void Clear(RichTextBox textBox)
        {
            textBox.KeyPress += (sender, e) =>
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
                {
                    e.Handled = true;
                }
            };
        }
        public double Add(double first, double second)
        {
            return first + second;
            
        }
        public double Multi(double first, double second)
        {
            return first * second;
        }

        public double Division(double first, double second)
        {
            return first / second;
        }

        public double Minus(double first, double second)
        {
            return first - second;
        }

        public double Cell(double first, double second)
        {
            return Math.Floor(first / second);
        }

        public double Rest(double first, double second)
        {
            return first % second;
        }
    }
}
