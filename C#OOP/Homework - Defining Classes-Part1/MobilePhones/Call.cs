namespace MobilePhones
{
    using System.Text;

    public class Call
    {
        #region Fields
        public const decimal PricePerMinute = 0.37M;

        private string date;
        private string time;
        private string dialledPhone;
        private int? duration;
        #endregion

        #region Constructors
        public Call(string date, string time, string dialledPhone, int duration)
        {
            this.Date = date;
            this.Time = time;
            this.DialledPhone = dialledPhone;
            this.Duration = duration;
        }
        #endregion

        #region Properties
        public string Date
        {
            get
            {
                return this.date;
            }
            set
            {
                this.date = value;
            }
        }

        public string Time
        {
            get
            {
                return this.time;
            }
            set
            {
                this.time = value;
            }
        }

        public string DialledPhone
        {
            get
            {
                return this.dialledPhone;
            }
            set
            {
                this.dialledPhone = value;
            }
        }

        public int? Duration
        {
            get
            {
                return this.duration;
            }
            set
            {
                this.duration = value;
            }
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine("Call History");
            result.AppendLine(new string('-', 12));
            result.AppendLine(string.Format("Dialed number: {0}", this.DialledPhone));
            result.AppendLine(string.Format("Duration is seconds: {0}", this.Duration));
            result.AppendLine(string.Format("On date: {0}", this.Date));
            result.AppendLine(string.Format("At time: {0}", this.Time));
            result.AppendLine(new string('-', 80));

            return result.ToString();
            //return string.Format("Call History\nDialed number: {0}\nDuration: {1}\nOn date: {2}\nAt time: {3}\n{4}", this.DialledPhone, this.Duration, this.Date, this.Time, new string('-', 80));
        }
        #endregion
    }
}
