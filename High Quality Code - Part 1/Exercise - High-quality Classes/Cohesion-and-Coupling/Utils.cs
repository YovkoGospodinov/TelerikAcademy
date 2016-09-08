using System;
using CohesionAndCoupling.Interfaces;

namespace CohesionAndCoupling
{
    public static class Utils
    {
        public static double CalculateDistance2D(double firstPointX, double firstPointY, double secondPointX, double secondPointY)
        {
            double distanceBetweenXOfPoints = secondPointX - firstPointX;
            double distanceBetweenYOfPoints = secondPointY - firstPointY;

            double distance = Math.Sqrt((distanceBetweenXOfPoints * distanceBetweenXOfPoints) + 
                (distanceBetweenYOfPoints * distanceBetweenYOfPoints));

            return distance;
        }

        public static double CalculateDistance3D(double firstPointX, double firstPointY, double firstPointZ, double secondPointX, double secondPointY, double secondPointZ)
        {
            double distanceBetweenXOfPoints = secondPointX - firstPointX;
            double distanceBetweenYOfPoints = secondPointY - firstPointY;
            double distanceBetweenZOfPoints = secondPointZ - firstPointZ;

            double distance = Math.Sqrt((distanceBetweenXOfPoints * distanceBetweenXOfPoints) + 
                (distanceBetweenYOfPoints * distanceBetweenYOfPoints) + 
                (distanceBetweenZOfPoints * distanceBetweenZOfPoints));

            return distance;
        }

        public static double CalculateDiagonalXYZ(IFigure3D figure)
        {
            double distance = CalculateDistance3D(0, 0, 0, figure.Width, figure.Height, figure.Depth);

            return distance;
        }

        public static double CalcDiagonalXY(IFigure3D figure)
        {
            double distance = CalculateDistance2D(0, 0, figure.Width, figure.Height);

            return distance;
        }

        public static double CalcDiagonalXZ(IFigure3D figure)
        {
            double distance = CalculateDistance2D(0, 0, figure.Width, figure.Depth);

            return distance;
        }

        public static double CalcDiagonalYZ(IFigure3D figure)
        {
            double distance = CalculateDistance2D(0, 0, figure.Height, figure.Depth);

            return distance;
        }
    }
}
