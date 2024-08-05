using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    public class PositionValidation:ValidationAttribute
    {
        public override bool IsValid(object? value)
        {

            string[] mas = { "Стюард", "Диспетчер", "Пилот" };
            if (value != null && value is string && !string.IsNullOrEmpty(value as string))
            {
                for (int i = 0; i < mas.Length; i++)
                {
                    if (mas[i] == value as string)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
