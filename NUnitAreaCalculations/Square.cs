using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitAreaCalculations
{
    /// <summary>
    /// 正方形
    /// </summary>
    public class Square : IShape
    {
        private double _side;

        public Square(double side)
        {
            this._side = side;
        }
        public double Area =>  _side * _side;
    }
}
