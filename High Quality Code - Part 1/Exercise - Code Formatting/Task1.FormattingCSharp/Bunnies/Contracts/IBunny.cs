namespace Bunnies.Contracts
{
    using Bunnies.Enums;

    public interface IBunny
    {
        int Age { get; }

        string Name { get; }

        FurType FurType { get; }

        void Introduce(IWriter writer);
    }
}
