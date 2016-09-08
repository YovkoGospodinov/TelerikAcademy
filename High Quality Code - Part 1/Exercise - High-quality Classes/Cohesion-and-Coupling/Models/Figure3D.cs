using System;
using CohesionAndCoupling.Interfaces;

namespace CohesionAndCoupling.Models
{
    public class Figure3D : IFigure3D
    {
        private double width;

        private double height;

        private double depth;

        public Figure3D(double width, double height, double depth)
        {
            this.Width = width;
            this.Height = height;
            this.Depth = depth;
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
                    throw new ArgumentException("Entered parameter is not valid, the width of a figure must be greater than 0.");
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
                    throw new ArgumentException("Entered parameter is not valid, the height of a figure must be greater than 0.");
                }

                this.height = value;
            }
        }

        public double Depth
        {
            get
            {
                return this.depth;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Entered parameter is not valid, the depth of a figure must be greater than 0.");
                }

                this.depth = value;
            }
        }

        public double Volume
        {
            get
            {
                return this.Width * this.Height * this.Depth;
            }
        }
    }
}
