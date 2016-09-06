using System.Collections.Generic;
using Task1.Class.Chef.Interfaces;

namespace Task1.Class.Chef.Models
{
    public class Bowl
    {
        private IList<IVegetable> vegetables;

        public Bowl()
        {
            this.vegetables = new List<IVegetable>();
        }

        public IList<IVegetable> Vegetables => this.vegetables;
        
        public void AddVegetable(IVegetable vegetable)
        {
            this.vegetables.Add(vegetable);
        }
    }
}
