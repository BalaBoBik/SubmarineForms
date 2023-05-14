using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubmarineForms
{
    internal class Point
    {
        public double y;
        public double z;
        public double t;
        public Point(double t, double y, double z)
        {
            this.y = y;
            this.z = z;
            this.t = t;
        }
        public void PrintPoint()
        {
            Console.WriteLine($"{t}    ;{y}   ,{z}");
        }
    }
}
