using System;

namespace Abstraction
{
    public class Circle : Figure
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get
            {
                return this.radius;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Entered parameter is not valid, the radius of a circle must be greater than 0.");
                }

                this.radius = value;
            }
        }

        public override double CalcPerimeter()
        {
            double perimeter = 2 * Math.PI * this.radius;
            return perimeter;
        }

        public override double CalcSurface()
        {
            double surface = Math.PI * this.radius * this.radius;
            return surface;
        }

        public override string ToString()
        {
            return $"I am a circle. " + base.ToString();
        }
    }
}
