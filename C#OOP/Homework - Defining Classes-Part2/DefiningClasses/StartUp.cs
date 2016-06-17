namespace DefiningClasses
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            //Initializing 3D points
            var firstPoint = new Point3D(1, 2, 3);
            var secondPoint = new Point3D(2, 2, 3);
            Console.WriteLine(firstPoint);
            Console.WriteLine(secondPoint);

            //Printing distance between two points
            Console.WriteLine("Distance between points: {0}", Distance.CalculateDistance(firstPoint, secondPoint));
            //Console.WriteLine("Distance between points: {0}", Distance.CalculateDistance(firstPoint, Point3D.Point0));

            //Initializing points
            var path = new Path();

            for (int i = 0; i < 5; i++)
            {
                path.AddPoints(new Point3D(i + 2, i + 2, i + 2));
            }

            //Saving points in file
            PathStorage.SavePath(path, "pathstorage.txt");
            //Loading point from file
            var print = PathStorage.LoadPath("pathstorage.txt");
            //And printing it on the console
            foreach (var item in print)
            {
                Console.WriteLine(item);
            }
            
            var list = new GenericList<int>(3);

            //Adding elements
            list.AddElement(5);
            list.AddElement(18);
            list.AddElement(100);

            //Removing element by index
            list.RemoveElement(1);

            list.AddElement(90);

            //Inserting element at given index
            list.InsertElement(1, 10000);

            list.AddElement(123);

            Console.WriteLine(list);

            //Get element at index
            Console.WriteLine(list.GetElement(1));

            //Get min element
            Console.WriteLine(list.GetMinEl());

            //Get max element
            Console.WriteLine(list.GetMaxEl());

            //Clear the list
            list.ClearElements();

            Console.WriteLine(list);

        }
    }
}
