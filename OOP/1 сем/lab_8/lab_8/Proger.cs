using System;
 namespace lab_8 
{
    public class Proger
    {
        public delegate void DeleteHander();
        public event DeleteHander? DeleteEvent;
        public delegate void MutateHandler();
        public event MutateHandler MutateEvent;

        public string Name { get; set; }
        public int Id { get; set; }
        public int Age { get; set; }
        public bool Live { get; set; }
        public Proger(int id, int age, string name, bool live)
        { 
            Id = id;
            Age = age;
            Name = name;
            Live = live;
        }


      
        public void Print()
        {
            Console.WriteLine($"id - {Id}, age - {Age}, name - {Name}, Live - {Live}");
        }
        public void Delete()
        {
            DeleteEvent?.Invoke();
            Live = false;

        }
        public void Mutate()
        {
            MutateEvent?.Invoke();
            Age += 1000;
            if(Live == false)
            {
                Live = true;
            }


        }
    }
   
}
