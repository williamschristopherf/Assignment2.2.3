using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2._2._3
{
    internal class Square : Shape
    {
        public double Side1 { get; set; }

        public Square(double side1)
        {
            Side1 = side1;
        }

        public double CalculateArea(double side1)
        {
            return side1 * side1;
        }
    }
}
