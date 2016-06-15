namespace MobilePhones
{
    using System.Text;

    public class Display
    {
        #region Fields
        private int? size;
        private int? colours;
        #endregion

        #region Constructors
        public Display(int size)
        {
            this.Size = size;
        }

        public Display(int size, int colours) : this(size)
        {
            this.Colours = colours;
        }
        #endregion

        #region Properties
        public int? Size
        {
            get
            {
                return this.size;
            }
            set
            {
                this.size = value;
            }
        }

        public int? Colours
        {
            get
            {
                return this.colours;
            }
            set
            {
                this.colours = value;
            }
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine();
            result.AppendLine(new string('-', 18));

            if (this.Size != null)
            {
                result.AppendLine(string.Format("Display Size: {0}", this.Size));
            }

            if (this.Colours != null)
            {
                result.AppendLine(string.Format("Display Colours: {0}", this.Colours));
            }

            return result.ToString();
        }
        #endregion
    }
}
