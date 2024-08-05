using System;


namespace lab_4
{
    public static class Program
    {
        public static void Main(string[] args) {
            DateTime currentTime = DateTime.Now;

            Document check = new Check(currentTime, "Google", 44343434, 1500);
            check.PrintDocument();
            Document waybill = new Waybill(currentTime, "BSTU", 228, "education");
            waybill.PrintDocument();
            Document receipt = new Receipt(currentTime, "LupaAndPupa", 1488, "Accountant");
            receipt.PrintDocument();
            Console.WriteLine(); 
            check.PrintDocument();
            Console.WriteLine();
            check.PrintDocument("Yandex");
            if(check is Document)
            {
                Console.WriteLine("чек - документ");
            }
            else
            {
                Console.WriteLine("чек не документ(");
            }
            DataAndOrganization documenting = waybill as Waybill;
            if(documenting != null)
            {
                Console.WriteLine("накладная поддерживает необходимый тип");
            }
            else
            {
                Console.WriteLine("не робе(");
            }



           

        }
        
    }
}