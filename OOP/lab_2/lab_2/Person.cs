using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    public class Person
    {
        [Required(ErrorMessage = "ФИО обязательно для заполнения")]
        [RegularExpression(@"^[а-яА-ЯёЁa-zA-Z]+$", ErrorMessage = "Некорректное ФИО")]
        public string Name { get; set; }
        [Range(18, 100, ErrorMessage = "Некорректный возраст")]
        public int Age { get; set; }
        [Range(0, 82, ErrorMessage = "Некорректный стаж")]
        public int Seniority { get; set; }
        [PositionValidation(ErrorMessage = "Выбрана не верная должнасть")]
        public string Position { get; set; }
        
    }
}
