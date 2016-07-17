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
    

    public class Car : Vehicle, ICar
    {

        private int seats;

        public Car(string make, string model, decimal price, int wheels, int seats) 
            : base(make, model, price, (int)VehicleType.Car)
        {
            this.Seats = seats;
        }

        public int Seats
        {
            get { return this.seats; }

            //setter is set as protected in case of the class has inheritors
            protected set
            {
                Validator.ValidateIntRange(value, Constants.MinSeats, Constants.MaxSeats, string.Format(Constants.NumberMustBeBetweenMinAndMax, "Seats", Constants.MinSeats, Constants.MaxSeats));
                this.seats = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("  Category: {0}", this.Seats);
        }
    }
}
