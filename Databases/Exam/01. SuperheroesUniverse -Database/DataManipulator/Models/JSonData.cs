using System.Collections.Generic;

namespace DataManipulator.Models
{
    public class JSonData
    {
        public Dictionary<string, ICollection<JSonSuperheroModel>> Data { get; set; }
    }
}
