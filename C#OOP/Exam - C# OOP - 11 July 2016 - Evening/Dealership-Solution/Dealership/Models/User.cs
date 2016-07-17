namespace Dealership.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Dealership.Contracts;
    using Dealership.Common;
    using Dealership.Common.Enums;

    public class User : IUser
    {
        private string userName;
        private string firstName;
        private string lastName;
        private string password;
        private string role;
        public IList<IVehicle> vehicles;

        public User(string userName, string firstName, string lastName, string password, string role)
        {
            this.Username = userName;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Password = password;
            this.role = role;
            this.vehicles = new List<IVehicle>();
        }

        public string Username
        {
            get { return this.userName; }
            private set
            {
                Validator.ValidateIntRange(value.Length, Constants.MinNameLength, Constants.MaxNameLength, string.Format(Constants.StringMustBeBetweenMinAndMax, "Username", Constants.MinNameLength, Constants.MaxNameLength));
                Validator.ValidateSymbols(value, Constants.UsernamePattern, String.Format(Constants.InvalidSymbols, "Username"));
                this.userName = value;
            }
        }

        public string FirstName
        {
            get { return this.firstName; }
            private set
            {
                Validator.ValidateIntRange(value.Length, Constants.MinNameLength, Constants.MaxNameLength, string.Format(Constants.StringMustBeBetweenMinAndMax, "Firstname", Constants.MinNameLength, Constants.MaxNameLength));
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            private set
            {
                Validator.ValidateIntRange(value.Length, Constants.MinNameLength, Constants.MaxNameLength, string.Format(Constants.StringMustBeBetweenMinAndMax, "Lastname", Constants.MinNameLength, Constants.MaxNameLength));
                this.lastName = value;
            }
        }

        public string Password
        {
            get { return this.password; }
            private set
            {
                Validator.ValidateIntRange(value.Length, Constants.MinPasswordLength, Constants.MaxPasswordLength, string.Format(Constants.StringMustBeBetweenMinAndMax, "Password", Constants.MinPasswordLength, Constants.MaxPasswordLength));
                Validator.ValidateSymbols(value, Constants.PasswordPattern, string.Format(Constants.InvalidSymbols, "Password"));
                this.password = value;
            }
        }

        public Role Role { get; private set; }
        
        public IList<IVehicle> Vehicles { get; private set; }


        public void AddVehicle(IVehicle vehicle)
        {
            
            if (this.Role == Role.Admin)
            {
                throw new ArgumentException(Constants.AdminCannotAddVehicles);
            }

            if (this.Role == Role.Normal && vehicles.Count == Constants.MaxVehiclesToAdd)
            {
                throw new ArgumentException(Constants.NotAnVipUserVehiclesAdd);
            }

            vehicles.Add(vehicle);
        }

        public void RemoveVehicle(IVehicle vehicle)
        {
            vehicles.Remove(vehicle);
        }

        public void AddComment(IComment commentToAdd, IVehicle vehicleToAddComment)
        {

            var vehicleToManipulate = vehicles.FirstOrDefault(v => v.Equals(vehicleToAddComment));
            if (vehicleToManipulate != null)
            {
                vehicleToManipulate.Comments.Add(commentToAdd);
            }
        }

        public void RemoveComment(IComment commentToRemove, IVehicle vehicleToRemoveComment)
        {
            if (this.Username != commentToRemove.Author)
            {
                throw new ArgumentException(Constants.YouAreNotTheAuthor);
            }

            var vehicleToManipulate = vehicles.FirstOrDefault(v => v.Equals(vehicleToRemoveComment));
            if (vehicleToManipulate != null)
            {
                vehicleToManipulate.Comments.Remove(commentToRemove);
            }
        }

        public string PrintVehicles()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(string.Format("Username: {0}, FullName: {1} {2}, Role: {3}", this.Username, this.FirstName, this.LastName, this.Role));

            foreach (var vehicle in vehicles)
            {
                result.AppendLine(vehicle.ToString());
            }

            return result.ToString();
        }
    }
}
