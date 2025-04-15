using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2._2._3
{
    //base class can't be instantiated
    abstract class Shape
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }

        public double CalculateArea(double num1, double num2)
        {
            return num1 * num2;
        }
    }
}
