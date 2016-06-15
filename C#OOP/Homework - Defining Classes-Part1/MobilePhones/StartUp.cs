namespace MobilePhones
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        static void Main()
        {
            //All fields, constructor and methods are collapsed with regeion!
            
            //Printing info for static field  iphone4S problem 6
            Console.WriteLine(MobilePhone.iphone4S.ToString());

            //Printing info for all mobile phones including iphone4S problem 7
            var phones = MobilePhoneTest.GeneratePhones();
            MobilePhoneTest.PrintMobilePhoneInfo(phones);
            
            //Printing info for all calls problem 12
            CallHistoryTest.PrintCallHistory();
        }
    }
}
