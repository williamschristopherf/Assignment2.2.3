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
        public double Side2 { get; set; }

        public Square(double side1, double side2)
        {
            Side1 = side1;
            Side2 = side2;
        }

        public override double CalculateArea(double side1, double side2)
        {
            return side1 * side2;
        }
    }
}
