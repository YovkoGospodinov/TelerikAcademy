namespace Dealership.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Dealership.Common.Enums;
    using Dealership.Common;
    using Dealership.Contracts;

    public abstract class Vehicle : IVehicle
    {
        private string make;
        private string model;
        private decimal price;
        private int wheels;
        public IList<IComment> comments;

        protected Vehicle(string make, string model, decimal price, int wheels)
        {
            this.Make = make;
            this.Model = model;
            this.Price = price;
            this.Wheels = wheels;
            this.comments = new List<IComment>();
        }

        public string Make
        {
            get { return this.make; }
            protected set
            {
                Validator.ValidateIntRange(value.Length, Constants.MinMakeLength, Constants.MaxMakeLength, string.Format(Constants.StringMustBeBetweenMinAndMax, "Make", Constants.MinMakeLength, Constants.MaxMakeLength));
                this.make = value;
            }
        }

        public string Model
        {
            get { return this.model; }
            protected set
            {
                Validator.ValidateIntRange(value.Length, Constants.MinModelLength, Constants.MaxModelLength, string.Format(Constants.StringMustBeBetweenMinAndMax, "Model", Constants.MinModelLength, Constants.MaxModelLength));
                this.model = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            protected set
            {
                Validator.ValidateDecimalRange(value, Constants.MinPrice, Constants.MaxPrice, string.Format(Constants.NumberMustBeBetweenMinAndMax, "Price", Constants.MinPrice, Constants.MaxPrice));
                this.price = value;
            }
            
        }

        public int Wheels
        {
            get { return this.wheels; }
            protected set
            {
                Validator.ValidateIntRange(value, Constants.MinWheels, Constants.MaxWheels, string.Format(Constants.NumberMustBeBetweenMinAndMax, "Wheels", Constants.MinWheels, Constants.MaxWheels));
                this.wheels = value;
            }
        }

        public VehicleType Type { get; set; }
        public IList<IComment> Comments { get; set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(string.Format("1. {0}:", this.Type));
            result.AppendLine(String.Format("  Make: {0}", this.Make));
            result.AppendLine(string.Format("  Model: {0}", this.Model));
            result.AppendLine(String.Format("  Wheels: {0}", this.Wheels));
            result.AppendLine(string.Format("  Price: ${0}", this.Price));

            return result.ToString();
        }
    }
}
