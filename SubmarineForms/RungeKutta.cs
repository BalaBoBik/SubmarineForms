using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubmarineForms
{
     internal class RungeKutta
    {
        public double n = 0.001, p0 = 1000, g = 9.8, a = 0.01;     //Уже заданы
        public double V, S, H, p1, v;         //Задаем сами
        public RungeKutta(double V, double S, double H, double p1, double v)
        {
            this.V = V;
            this.S = S;
            this.H = H;
            this.p1 = p1;
            this.v = v;
        }
        private double F(double z)
        {
            double result = 0;
            result = z;
            return result;
        }
        private double G(double t, double y, double z)
        {
            double result = 0;
            result = -(n * S) / (V * p1) * (1 + a * (y / H)) * z + g * (p0 / p1 - 1);
            return result;
        }

        public  List<Point> RungeKuttaCalculations()
        {
            double h = Math.Abs(0.001 * H);
            double k1, k2, k3, k4;
            double l1, l2, l3, l4;
            double z = H, y = 0, t = 0;
            List <Point> result = new List<Point>();
            result.Add(new Point(t, y, z));
            while(z<0)
            {
                k1 = F(z);
                l1 = G(t, y, z);

                k2 = F(z + l1 * h / 2);
                l2 = G(t + h / 2, y + k1 * h / 2, z + l1 * h / 2);

                k3 = F(z + l2 * h / 2);
                l3 = G(t + h / 2, y + k2 * h / 2, z + l2 * h / 2);

                k4 = F(z + l3 * h);
                l4 = G(t + h, y + k3 * h, z + l3 * h);

                t = t + h;
                y = y - h / 6 * (k1 + 2*k2 + 2*k3 + k4);
                z = z - h / 6 * (l1 + 2*l2 + 2 * l3 + l4);
                result.Add(new Point(t, y, z));
                
            }
            return result;
        }
    }
}
