namespace MobilePhones
{
    using System;

    public static class CallHistoryTest
    {
        public static void PrintCallHistory()
        {
            MobilePhone phone = new MobilePhone("S6", "Samsung", 1200M, "Koko", new Battery("D8", 440, 36, BatteryType.NiCD), new Display(20, 48000));

            phone.AddCalls("21 February 2016", "16:54", "+40 3454 5454 65", 350);
            phone.AddCalls("13 June 2016", "9:35", "+359 789 965 480", 50);
            phone.AddCalls("01 May 2016", "22:06", "+35 543 5435 456", 240);
            phone.AddCalls("28 April 2016", "01:09", "+359 112", 50);
            phone.AddCalls("03 May 2016", "10:16", "+359 888 888 222", 48);

            foreach (var item in phone.CallHistory)
            {
                Console.WriteLine(item);
            }

            //printing calls price
            Console.WriteLine("Price for all calls: {0:F2}", phone.CalcCallPrice());
            Console.WriteLine(new string('-', 80));

            //removing longest call
            phone.RemoveLongestCall();

            Console.WriteLine("Price after removing the longest call: {0:F2}", phone.CalcCallPrice());

            //clear calls history
            phone.ClearCalls();

            ////trying to print empty callHistory list
            foreach (var item in phone.CallHistory)
            {
                Console.WriteLine(item);
            }
        }
    }
}
