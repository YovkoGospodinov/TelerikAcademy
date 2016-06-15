namespace MobilePhones
{
    using System.Text;

    public class Battery
    {
        #region Fields
        private string model;
        private int? hoursIdle;
        private int? hoursTalk;
        private BatteryType batteryType;
        #endregion

        #region Constructors
        public Battery(string model)
        {
            this.Model = model;
        }

        public Battery(string model, int hoursIdle, int hoursTalk) : this(model)
        {
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }

        public Battery(string model, int hoursIdle, int hoursTalk, BatteryType batteryType) : this(model, hoursIdle, hoursTalk)
        {
            this.BatteryType = batteryType;
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
                this.model = value;
            }
        }

        public int? HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                this.hoursIdle = value;
            }
        }

        public int? HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                this.hoursTalk = value;
            }
        }

        public BatteryType BatteryType
        {
            get
            {
                return this.batteryType;
            }
            set
            {
                this.batteryType = value;
            }
        }
        #endregion

        #region Method
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine();
            result.AppendLine(new string('-', 18));

            if (this.Model != null)
            {
                result.AppendLine(string.Format("Battery Model: {0}", this.Model));
            }

            if (this.HoursIdle != null)
            {
                result.AppendLine(string.Format("Battery Idle Capacity: {0}", this.HoursIdle));
            }

            if (this.HoursTalk != null)
            {
                result.AppendLine(string.Format("Battery Talk Capacity: {0}", this.HoursTalk));
            }

            result.AppendLine(string.Format("Battery Type: {0}", this.BatteryType));

            return result.ToString();
        }
        #endregion
    }
}
