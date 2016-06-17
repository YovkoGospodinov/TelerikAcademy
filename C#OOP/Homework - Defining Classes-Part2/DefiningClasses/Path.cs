namespace DefiningClasses
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class Path : IEnumerable<Point3D>
    {
        #region Fields
        private ICollection<Point3D> points;
        #endregion

        #region Constructors
        public Path()
        {
            this.points = new List<Point3D>();
        }
        #endregion

        #region Methods
        public void AddPoints(Point3D point)
        {
            points.Add(point);
        }

        public void RemovePoints(Point3D point)
        {
            points.Remove(point);
        }

        public IEnumerator<Point3D> GetEnumerator()
        {
            return this.points.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        #endregion
    }
}
