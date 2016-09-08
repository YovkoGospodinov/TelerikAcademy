namespace Abstraction
{
    public abstract class Figure
    {
        public abstract double CalcPerimeter();

        public abstract double CalcSurface();

        public override string ToString()
        {
            return $"My perimeter is {this.CalcPerimeter():F2}. My surface is {this.CalcSurface():F2}.";
        }
    }
}
