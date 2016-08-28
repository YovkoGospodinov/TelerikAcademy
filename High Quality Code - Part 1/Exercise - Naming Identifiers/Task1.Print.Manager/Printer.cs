namespace Task1.Print.Manager
{
    using System;

    public class Printer
    {
        public void BooleanPrint(bool booleanValue)
        {
            string booleanValueAsString = booleanValue.ToString();

            Console.WriteLine(booleanValueAsString);
        }
    }
}
