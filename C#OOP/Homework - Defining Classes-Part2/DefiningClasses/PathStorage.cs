namespace DefiningClasses
{
    using System.IO;

    public static class PathStorage
    {
        public static void SavePath(Path path, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                foreach (var point in path)
                {
                    writer.WriteLine(point);
                }
            };
        }

        public static Path LoadPath(string filePath)
        {
            var path = new Path();
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Point3D point = Point3D.Parse(line);
                    path.AddPoints(point);
                }
            }
            return path;
        }
    }
}
