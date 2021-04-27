using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitAreaCalculations
{
    /// <summary>
    /// 三角形
    /// </summary>
    public class Triangle : IShape
    {
        private double _width, _height;
        public Triangle(double width, double height)
        {
            this._width = width;
            this._height = height;
        }
        public double Area => this._width * this._height / 2;
    }
}
