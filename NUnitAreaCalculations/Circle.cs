using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitAreaCalculations
{
    /// <summary>
    /// 圓形
    /// </summary>
    public class Circle : IShape
    {
        private double _radius;

        public Circle(double radius)
        {
            this._radius = radius;
        }

        public double Area => 3.14 * this._radius * this._radius; 

    }
}
