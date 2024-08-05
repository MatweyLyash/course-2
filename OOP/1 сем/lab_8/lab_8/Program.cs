using System.Text;
namespace lab_8
{
    public class Program
    {

        public delegate bool Predicate(string Str);//если у строки есть загланая, она изменит на строчную и вернёт 1 

        public static void Main(string[] args)
        {
            Proger proger = new Proger(123, 20, "Котик", true);

            proger.DeleteEvent += () => { Console.WriteLine($"Программист удалён"); };
            proger.Delete();
            proger.Print();
            proger.MutateEvent += () => { Console.WriteLine("Программист мутировал, время переработок увеличино вдвое"); };
            proger.Mutate();
            proger.Print();
            Action<StringBuilder> deleteMarks = Str =>
            {

                Str.Replace(".", "")
                .Replace(",", "")
                .Replace("?", "")
                .Replace("!", "")
                .Replace(":", "");
            };
            StringBuilder builder = new StringBuilder("gj?sa,sdfh.sdj:");
            deleteMarks(builder);
            Console.WriteLine(builder.ToString());
            Func<string, string> func = Str =>
            {
                return Str.ToUpper() + "[UPPER]";
            };
            Console.WriteLine(func(builder.ToString()));
            Predicate<string> lower = Str =>
            {
                bool flag = false;
                for (int i = 0; i < Str.Length; i++)
                {
                    if ((int)Str[i] < 91 && (int)Str[i] > 64)
                    {
                        flag = true;
                    }
                }
                return flag;
            };
            Console.WriteLine(lower("sdfgHjkl"));
        }
    }
}