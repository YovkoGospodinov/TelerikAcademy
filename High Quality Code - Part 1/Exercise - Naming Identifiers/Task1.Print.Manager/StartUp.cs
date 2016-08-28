namespace Task1.Print.Manager
{
    public class StartUp
    {
        private const int MaxCount = 6;

        public static void Main()
        {
            var printer = new Printer();

            printer.BooleanPrint(true);
        }
    }
}
