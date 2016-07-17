namespace Dealership.Factories
{
    using Dealership.Contracts;
    using System;
    using Dealership.Models;
    using Dealership.Common;
    using Dealership.Common.Enums;


    public class DealershipFactory : IDealershipFactory
    {
        public IVehicle CreateCar(string make, string model, decimal price, int seats)
        {
            var car = new Car(make, model, price, (int)VehicleType.Car, seats);
            
            Validator.ValidateNull(car, Constants.VehicleCannotBeNull);

            return car;
        }

        public IVehicle CreateMotorcycle(string make, string model, decimal price, string category)
        {
            var motorcycle = new Motorcycle(make, model, price, (int)VehicleType.Motorcycle, category);

            Validator.ValidateNull(motorcycle, Constants.VehicleCannotBeNull);

            return motorcycle;
        }

        public IVehicle CreateTruck(string make, string model, decimal price, int weightCapacity)
        {
            var truck = new Truck(make, model, price, (int)VehicleType.Truck, weightCapacity);

            Validator.ValidateNull(truck, Constants.VehicleCannotBeNull);

            return truck;
        }

        public IUser CreateUser(string username, string firstName, string lastName, string password, string role)
        {
            var user = new User(username, firstName, lastName, password, role);

            Validator.ValidateNull(user, Constants.UserCannotBeNull);

            return user;
        }

        public IComment CreateComment(string content)
        {
            var comment = new Comment(content);

            Validator.ValidateNull(comment, Constants.CommentCannotBeNull);

            return comment;
        }
    }
}
