using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitAreaCalculations
{
    public class Shapes<T> where T : IShape
    {
        private List<T> shapes = new List<T>();
        public double GetTotalArea()
        {
            double acc = 0;
            foreach (T shape in shapes)
            {
                acc += Math.Round(shape.Area, 2);
            }
            return acc;
        }

        public void Add(T shape)
        {
            this.shapes.Add(shape);
        }

        public void Clear()
        {
            this.shapes.Clear();
        }
    }
}
