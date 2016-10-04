using System;
using log4net;
using log4net.Config;

namespace T4Template
{
    public class StatUp
    {
        public static readonly ILog Log = LogManager.GetLogger(typeof(StatUp));
        public static void Main()
        {
            Person person = new Person("Martin", "Dimitov", 56, "Pernik");
            Console.WriteLine(person.FirstName);

            XmlConfigurator.Configure();
            Log.Debug(person.FirstName);
        }
    }
}
