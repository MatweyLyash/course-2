using DocumentFormat.OpenXml.Bibliography;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    public class CustomValidation : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            string[] mas = { "1984","1996","2004","2007","2021"};
            if (value != null && value is string)
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
