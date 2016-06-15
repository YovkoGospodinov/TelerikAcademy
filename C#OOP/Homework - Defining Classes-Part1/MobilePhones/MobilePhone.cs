namespace MobilePhones
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class MobilePhone
    {
        #region Fields
        public static MobilePhone iphone4S = new MobilePhone("Iphone4s", "Apple");

        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Call> callHistory;
        #endregion

        #region Constructors
        public MobilePhone(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.callHistory = new List<Call>();
        }

        public MobilePhone(string model, string manufacturer, decimal price) : this(model, manufacturer)
        {
            this.Price = price;
        }

        public MobilePhone(string model, string manufacturer, string owner) : this(model, manufacturer)
        {
            this.Owner = owner;
        }

        public MobilePhone(string model, string manufacturer, decimal price, string owner) : this(model, manufacturer, price)
        {
            this.Owner = owner;
        }

        public MobilePhone(string model, string manufacturer, decimal price, string owner, Battery battery, Display display) : this(model, manufacturer, price, owner)
        {
            this.Battery = battery;
            this.Display = display;
        }
        #endregion

        #region Properties
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (value.Length <= 0 || value.Length >= 25)
                {
                    throw new ArgumentOutOfRangeException("The name of the model must be longer than 0 and shorter than 25 symbols");
                }
                else
                {
                    this.model = value;
                }
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (value.Length <= 0 || value.Length >= 25)
                {
                    throw new ArgumentOutOfRangeException("The name of the manufacturer must be longer than 0 and shorter than 25 symbols");
                }
                else
                {
                    this.manufacturer = value;
                }
            }
        }

        public decimal? Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                if (value.Length <= 0 || value.Length >= 30)
                {
                    throw new ArgumentOutOfRangeException("The name of the owner must be longer than 0 and shorter than 30 symbols");
                }
                else
                {
                    this.owner = value;
                }
            }
        }

        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            set
            {
                this.battery = value;
            }
        }

        public Display Display
        {
            get
            {
                return this.display;
            }
            set
            {
                this.display = value;
            }
        }

        public MobilePhone Iphone4S
        {
            get
            {
                return iphone4S;
            }
        }

        public List<Call> CallHistory
        {
            get
            {
                return this.callHistory;
            }
            set
            {
                this.callHistory.Clear();
                this.callHistory = value;
            }
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(string.Format("{0}", "Mobile Phone"));
            result.AppendLine(new string('-', 12));

            if (this.Model != null)
            {
                result.AppendLine(string.Format("Phone Model: {0}", this.Model));
            }

            if (this.Manufacturer != null)
            {
                result.AppendLine(string.Format("Phone Manufacturer: {0}", this.Manufacturer));
            }

            if (this.Price != null)
            {
                result.AppendLine(string.Format("Phone Price: {0}", this.Price));
            }

            if (this.Owner != null)
            {
                result.AppendLine(string.Format("Phone Owner: {0}", this.Owner));
            }

            result.AppendLine();

            if (this.Battery != null)
            {
                result.AppendLine(string.Format("Phone Battery Info{0}", this.Battery));
            }

            if (this.Display != null)
            {
                result.AppendLine(string.Format("Phone Display Info{0}", this.Display));
            }

            result.Append(new string('-', 80));

            return result.ToString();
        }

        public void AddCalls(string date, string time, string dialledPhone, int duration)
        {
            this.CallHistory.Add(new Call(date, time, dialledPhone, duration));
        }

        public List<Call> DeleteCalls(Call call)
        {
            this.CallHistory.Remove(call);
            return new List<Call>(this.CallHistory);
        }

        public List<Call> ClearCalls()
        {
            this.CallHistory.Clear();
            return new List<Call>(this.CallHistory);
        }

        public decimal CalcCallPrice()
        {
            decimal callPrice = 0M;

            foreach (var call in this.CallHistory)
            {
                callPrice += (decimal)call.Duration / 60M * Call.PricePerMinute;
            }

            return callPrice;
        }

        public static void PrintCallHistory(List<Call> calls)
        {
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Call History");
            for (int i = 0; i < calls.Count; i++)
            {
                Console.WriteLine("Call History{0}: {1}", i + 1, string.Join(" ", calls[i]));
                Console.WriteLine(new string('-', 50));
            }
        }

        public void RemoveLongestCall()
        {
            int maxDurationIndex = 0;
            int maxDuration = 0;

            if (this.callHistory.Count > 0)
            {
                for (int i = 0; i < this.callHistory.Count; i++)
                {
                    if (this.callHistory[i].Duration > maxDuration)
                    {
                        maxDuration = (int)this.callHistory[i].Duration;
                        maxDurationIndex = i;
                    }
                }

                this.callHistory.RemoveAt(maxDurationIndex);
            }
            else
            {
                Console.WriteLine("Call history is empty.");
            }
        }
        #endregion
    }
}
