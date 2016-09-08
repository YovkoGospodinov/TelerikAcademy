using System;

namespace Abstraction
{
    public class Rectangle : Figure
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Entered parameter is not valid, the width of a rectangle must be greater than 0.");
                }

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Entered parameter is not valid, the height of a rectangle must be greater than 0.");
                }

                this.height = value;
            }
        }

        public override double CalcPerimeter()
        {
            double perimeter = 2 * (this.width + this.height);
            return perimeter;
        }

        public override double CalcSurface()
        {
            double surface = this.width * this.height;
            return surface;
        }

        public override string ToString()
        {
            return $"I am a rectangle. " + base.ToString();
        }
    }
}
