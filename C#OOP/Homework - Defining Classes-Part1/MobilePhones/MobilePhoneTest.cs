namespace MobilePhones
{
    using System;
    using System.Collections.Generic;

    public class MobilePhoneTest
    {

        public static List<MobilePhone> GeneratePhones()
        {
            List<MobilePhone> phones = new List<MobilePhone>()
            {
                new MobilePhone("A500", "Lenovo", 100M, "Ivan", new Battery("N540", 360, 10, BatteryType.LiIon), new Display(10, 16000)),
                new MobilePhone("P8", "Huawei", 800M, "Kalin", new Battery("G50", 680, 24, BatteryType.Other), new Display(15, 32000)),
                new MobilePhone("S6", "Samsung", 1200M, "Koko", new Battery("D8", 440, 36, BatteryType.NiCD), new Display(20, 48000)),
                new MobilePhone("Iphone 6", "Apple", 1500M, "Mitko"),
            };

            return phones;
        }

        public static void PrintMobilePhoneInfo(List<MobilePhone> phones)
        {
            for (int i = 0; i < phones.Count; i++)
            {
                Console.WriteLine(string.Join(" ", phones[i]));
            }

            Console.WriteLine("{0}", MobilePhone.iphone4S);
        }
    }
}
