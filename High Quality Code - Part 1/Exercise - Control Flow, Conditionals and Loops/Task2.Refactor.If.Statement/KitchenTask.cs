using Task1.Class.Chef.Interfaces;

namespace Task2.Refactor.If.Statement
{
    public class KitchenTask
    {
        public static bool CheckWhetherVegetableIsReadyForCooking(IVegetable vegetable)
        {
            bool result = false;

            if (vegetable != null && vegetable.IsCut && vegetable.IsFreesh)
            {
                result = true;
            }

            return result;
        }
    }
}
