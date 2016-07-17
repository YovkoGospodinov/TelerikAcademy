using Dealership.Common.Enums;

namespace Dealership.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Dealership.Common;
    using Dealership.Contracts;

    public class Motorcycle : Vehicle, IMotorcycle
    {
        private string category;

        public Motorcycle(string make, string model, decimal price, int wheels, string category) 
            : base(make, model, price, (int)VehicleType.Motorcycle)
        {
            this.Category = category;
        }

        public string Category
        {
            get { return this.category; }
            //setter is set as protected in case of the class has inheritors
            protected set
            {
                Validator.ValidateIntRange(value.Length, Constants.MinCategoryLength, Constants.MaxCategoryLength, string.Format(Constants.StringMustBeBetweenMinAndMax, "Category", Constants.MinCategoryLength, Constants.MaxCategoryLength));
                this.category = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("  Category: {0}", this.Category);
        }
    }
}
