using System.Collections.Generic;

namespace DataManipulator.Models
{
    public class JSonSuperheroModel
    {
        public string Name { get; set; }

        public string SecretIdentity { get; set ;}

        public JSonCityModel City { get; set; }

        public string Alignment { get; set; }

        public string Story { get; set; }

        public ICollection<JSonPowerModel> Powers { get; set; }

        public ICollection<JSonFractionModel> Fractions { get; set; }
    }
}
