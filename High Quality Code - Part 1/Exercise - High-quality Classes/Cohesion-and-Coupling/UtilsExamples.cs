﻿using System;
using CohesionAndCoupling.Interfaces;
using CohesionAndCoupling.Models;

namespace CohesionAndCoupling
{
    public class UtilsExamples
    {
        public static void Main()
        {
            Console.WriteLine(FileStringManipulations.GetFileExtension("example"));
            Console.WriteLine(FileStringManipulations.GetFileExtension("example.pdf"));
            Console.WriteLine(FileStringManipulations.GetFileExtension("example.new.pdf"));

            Console.WriteLine(FileStringManipulations.GetFileNameWithoutExtension("example"));
            Console.WriteLine(FileStringManipulations.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(FileStringManipulations.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}", Utils.CalculateDistance2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}", Utils.CalculateDistance3D(5, 2, -1, 3, -6, 4));

            IFigure3D figure = new Figure3D(3, 4, 5);

            Console.WriteLine("Volume = {0:f2}", figure.Volume);
            Console.WriteLine("Diagonal XYZ = {0:f2}", Utils.CalculateDiagonalXYZ(figure));
            Console.WriteLine("Diagonal XY = {0:f2}", Utils.CalcDiagonalXY(figure));
            Console.WriteLine("Diagonal XZ = {0:f2}", Utils.CalcDiagonalXZ(figure));
            Console.WriteLine("Diagonal YZ = {0:f2}", Utils.CalcDiagonalYZ(figure));
        }
    }
}
