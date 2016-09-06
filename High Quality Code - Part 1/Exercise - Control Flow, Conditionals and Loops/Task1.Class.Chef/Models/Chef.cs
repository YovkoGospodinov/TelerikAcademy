using Task1.Class.Chef.Interfaces;

namespace Task1.Class.Chef.Models
{
    public class Chef : IChef
    {
        public void Cook()
        {
            var bowl = new Bowl();
            var potato = new Potato();
            var carrot = new Carrot();

            Peel(potato);
            Cut(potato);
            bowl.AddVegetable(potato);

            Peel(carrot);
            Cut(carrot);
            bowl.AddVegetable(carrot);
        }

        private Bowl GetBowl()
        {
            return new Bowl();
        }

        private IVegetable GetCarrot()
        {
            var carrot = new Carrot();

            return carrot;
        }

        private IVegetable GetPotato()
        {
            var potato = new Potato();

            return potato;
        }

        private void Peel(IVegetable vegetable)
        {
            vegetable.IsPeeled = true;
        }

        private void Cut(IVegetable vegetable)
        {
            vegetable.IsCut = true;
        }
    }
}
