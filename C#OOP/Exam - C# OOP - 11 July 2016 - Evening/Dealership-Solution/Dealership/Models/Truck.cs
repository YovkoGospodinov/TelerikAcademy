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

    public class Truck : Vehicle, ITruck
    {
        private int weightCapacity;

        public Truck(string make, string model, decimal price, int wheels, int weightCapacity) 
            : base(make, model, price, (int)VehicleType.Truck)
        {
            this.WeightCapacity = weightCapacity;
        }

        public int WeightCapacity
        {
            get { return this.weightCapacity; }
            protected set
            {
                Validator.ValidateIntRange(value, Constants.MinCapacity, Constants.MaxCapacity, string.Format(Constants.NumberMustBeBetweenMinAndMax, "Weight capacity", Constants.MinCapacity, Constants.MaxCapacity));
                this.weightCapacity = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("  Category: {0}", this.WeightCapacity);
        }
    }
}
