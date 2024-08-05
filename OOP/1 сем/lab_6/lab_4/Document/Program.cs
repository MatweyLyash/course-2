using System;



namespace lab_4
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            DateTime time1 = new DateTime(2023, 02, 01);
            DateTime time2 = new DateTime(2022, 02, 02);
            DateTime time3 = new DateTime(2022, 02, 03);
            DateTime time4 = new DateTime(2023, 02, 02);
            DateTime time5 = new DateTime(2023, 02, 03);
            bool isCodeValid = true;
            try
            {
                Document check = new Check(time1, "Google", Document.ETypeOfDocument.CHECK, 44343434, 1500);
                Document check2 = new Check(time5, "GitHub", Document.ETypeOfDocument.CHECK, 123456, 1488);

                Document waybillOfBadNigger = new Waybill(time2, "BSTU", Document.ETypeOfDocument.WAYBILL, 228, -5, "негр");
                Document waybillOfCoolNigger = new Waybill(time3, "BSTU", Document.ETypeOfDocument.WAYBILL, 229, 1, "негр");
                Document waybillOfGoodNigger = new Waybill(time4, "BSTU", Document.ETypeOfDocument.WAYBILL, 230, 7, "негр");

                Controller<Document> controller = new Controller<Document>();
                controller.AddDocument(check);
                controller.AddDocument(check2);
                controller.AddDocument(waybillOfGoodNigger);
                controller.AddDocument(waybillOfCoolNigger);
                controller.AddDocument(waybillOfBadNigger);
                controller.PrintDocument();
                controller.SumCostDoc("негр");
                controller.AmountOfCheck();
            }
            catch(NegativeCost huy)
            {
                Console.WriteLine(huy);
                throw;//переброска по стеку
            }
            catch (Exception e) {
                Console.WriteLine("");
            }
            finally
            {
                Console.WriteLine("end");
            }
      



        }

    }
}