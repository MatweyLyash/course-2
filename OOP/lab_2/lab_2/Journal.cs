using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;


namespace lab_2
{
    public class Journal
    {
        [Required(ErrorMessage = "Имя модели обязательно для заполнения")]
        public string modelName {  get; set; }
        [Required(ErrorMessage = "ID обязательно для заполнения")]
        public string IdMask    { get; set; }
        [Required(ErrorMessage = "Тип модели обязательно для заполнения")]

        public string TypeOfAir { get; set; }
        [Required(ErrorMessage = "Количество пассажиров обязательно для заполнения")]

        public int AmountPassajer{ get; set; }
        [Required(ErrorMessage = "Грузоподъёмность обязательна для заполнения")]

        public int Capacity  { get; set; }
        [@CustomValidation(ErrorMessage = "Выбран не верный год выпуска")]
        public string Year      { get; set; }
        [CustomValidatorService(ErrorMessage ="Некорректная дата тех.обслуживания")]
        public string DateService{ get; set; }
        

        public Person person = new Person();

        
    
        public Journal(string modelName, 
            string idMask,
            string typeOfAir,
            int amount,
            int capacity,
            string year,
            string data,
            string fio,
            string position,
            int age,
            int seniority
            )
        {
            this.IdMask = idMask;
            this.modelName = modelName;
            this.TypeOfAir = typeOfAir;
            this.AmountPassajer = amount;
            this.Capacity = capacity;
            this.Year = year;
            person.Name = fio;
            this.person.Position = position;
            this.person.Age = age;
            this.person.Seniority = seniority;
            this.DateService = data;
        }
    
        public  void  Save ()
        {
            string json = JsonConvert.SerializeObject(this);
            File.WriteAllText("journal.json", json);
        }

        public override string ToString()
        {
            return $"id: {IdMask}, model: {modelName}," +
                    $" type of air: {TypeOfAir}, amount of passajer: {AmountPassajer}, capacity: {Capacity}, " +
                    $"release year: {Year}, data of last service: {DateService}, FIO: {person.Name}, " +
                    $"position: {person.Position}, seniority: {person.Seniority}, age: {person.Age}, " + '\n';
        }


    }
}
