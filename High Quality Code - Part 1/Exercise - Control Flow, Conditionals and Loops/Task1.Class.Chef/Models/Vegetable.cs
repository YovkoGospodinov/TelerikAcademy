using Task1.Class.Chef.Interfaces;

namespace Task1.Class.Chef.Models
{
    public abstract class Vegetable : IVegetable
    {
        private bool isCut;
        private bool isPeeled;
        private bool isRooten;

        protected Vegetable()
        {
            this.isCut = false;
            this.isPeeled = false;
        }

        public bool IsCut { get; set; }

        public bool IsPeeled { get; set; }

        public bool IsFreesh { get; set; }
    }
}
