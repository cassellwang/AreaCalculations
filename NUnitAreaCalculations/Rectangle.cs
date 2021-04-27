using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitAreaCalculations
{
    /// <summary>
    /// 長方形
    /// </summary>
    public class Rectangle : IShape
    {
        private double _width, _height;
        public Rectangle(double width, double height)
        {
            this._width = width;
            this._height = height;
        }
        public double Area => this._width * this._height;
    }
}
