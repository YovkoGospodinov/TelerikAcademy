namespace DefiningClasses
{
    using System;
    using System.Linq;

    public struct Point3D
    {
        #region Fields
        private static readonly Point3D point0 = new Point3D(0, 0, 0);
        #endregion

        #region Constructors
        public Point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        #endregion

        #region Properties
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public static Point3D Point0
        {
            get
            {
                return point0;
            }
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return string.Format("Point Coordinates: ({0}, {1}, {2})", this.X, this.Y, this.Z);
        }

        public static Point3D Parse(string text)
        {
            int openBracket = text.IndexOf('(');
            double[] coordinates = text
                .Substring(openBracket + 1, text.Length - openBracket - 2)
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => double.Parse(x))
                .ToArray();
            return new Point3D(coordinates[0], coordinates[1], coordinates[2]);
        }
        #endregion
    }
}
