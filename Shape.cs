using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2._2._3
{
    abstract class Shape
    {
        public string id { get; set; }
        public string name { get; set; }
        public string color { get; set; }
        public double num1 { get; set; }
        public double num2 { get; set; }

        public virtual double CalculateArea(double num1, double num2)
        {
            return num1 * num2;
        }
    }
}
