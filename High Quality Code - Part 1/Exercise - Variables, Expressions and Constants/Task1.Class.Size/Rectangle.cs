using System;

namespace Task1.Class.Size
{
    public class Rectangle
    {
        private double width;
        private double height;
        
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double Width => this.width;

        public double Height => this.height;

        public static Rectangle GetRotatedRectangle(
            Rectangle rectangle, double angleOfRotation)
        {
            double cosineAngleOfRotation = Math.Abs(Math.Cos(angleOfRotation));
            double sineAngleOfRotation = Math.Abs(Math.Sin(angleOfRotation));
            double rectangleWidth = rectangle.width;
            double rectangleHeight = rectangle.height;

            double widthOfRotatedRectangle = (cosineAngleOfRotation * rectangleWidth) + (sineAngleOfRotation * rectangleHeight);
            double heightOfRotatedRectangle = (sineAngleOfRotation * rectangleWidth) + (cosineAngleOfRotation * rectangleHeight);

            Rectangle rotatedRectangle = new Rectangle(widthOfRotatedRectangle, heightOfRotatedRectangle);

            return rotatedRectangle;
        }
    }
}
