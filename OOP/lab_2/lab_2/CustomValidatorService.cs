using DocumentFormat.OpenXml.Drawing.Charts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    public class CustomValidatorService:ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            
            if (value is string && !string.IsNullOrEmpty(value as string))
            {
                int valueInt = Convert.ToInt32(value);
                if (valueInt <= 2024 && valueInt >= 2020)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
