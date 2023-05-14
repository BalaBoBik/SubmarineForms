using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubmarineForms
{
    class QuadraticEquation
    {
        public double a, b, c;
        private double D;
        public double x1, x2;
        public QuadraticEquation(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void FindX()
        {
            D = Math.Pow(b, 2) - 4 * a * c;
            if (D > 0 || D == 0)
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);


            }


            else
            {
                Console.WriteLine("Действительных корней нет");

            }
        }
    }
    internal class TrendLine
    {
        public static double[,] MakeQuadraticMatrixZT(List<Point> points)
        {
            double[,] matrix = new double[3, 4];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 4; j++)
                {
                    if (j != 3)
                    {
                        matrix[i, j] = 0;
                        foreach (Point point in points)
                        {
                            matrix[i, j] += Math.Pow(point.t, 4 - i - j);
                        }
                    }
                    else
                    {
                        matrix[i, j] = 0;
                        foreach (Point point in points)
                        {
                            matrix[i, j] += Math.Pow(point.t, 2 - i) * point.z;
                        }
                        matrix[i, j] = matrix[i, j];
                    }
                }
            return matrix;
        }
        internal static QuadraticEquation MakeQuadraticTrendLineZT(List<Point> points)
        {
            double a1, a2, a3;
            double[,] matrix = MakeQuadraticMatrixZT(points);


            double temp = matrix[1, 0];
            for (int j = 0; j < 4; j++)
                matrix[1, j] = matrix[0, j] - matrix[1, j] * matrix[0, 0] / temp;
            temp = matrix[2, 0];
            for (int j = 0; j < 4; j++)
                matrix[2, j] = matrix[0, j] - matrix[2, j] * matrix[0, 0] / temp;
            temp = matrix[2, 1];
            for (int j = 0; j < 4; j++)
                matrix[2, j] = matrix[1, j] - matrix[2, j] * matrix[1, 1] / temp;

            a3 = matrix[2, 3] / matrix[2, 2];
            a2 = (matrix[1, 3] - a3 * matrix[1, 2]) / matrix[1, 1];
            a1 = (matrix[0, 3] - a3 * matrix[0, 2] - a2 * matrix[0, 1]) / matrix[0, 0];
            Console.WriteLine($"{a1} {a2} {a3}");
            QuadraticEquation result = new QuadraticEquation(a1, a2, a3);
            return result;
        }
        public static double[,] MakeQuadraticMatrixZY(List<Point> points)
        {
            double[,] matrix = new double[3, 4];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 4; j++)
                {
                    if (j != 3)
                    {
                        matrix[i, j] = 0;
                        foreach (Point point in points)
                        {
                            matrix[i, j] += Math.Pow(point.y, 4 - i - j);
                        }
                    }
                    else
                    {
                        matrix[i, j] = 0;
                        foreach (Point point in points)
                        {
                            matrix[i, j] += Math.Pow(point.y, 2 - i) * point.z;
                        }
                        matrix[i, j] = matrix[i, j];
                    }
                }
            return matrix;
        }
        internal static QuadraticEquation MakeQuadraticTrendLineZY(List<Point> points)
        {
            double a1, a2, a3;
            double[,] matrix = MakeQuadraticMatrixZY(points);


            double temp = matrix[1, 0];
            for (int j = 0; j < 4; j++)
                matrix[1, j] = matrix[0, j] - matrix[1, j] * matrix[0, 0] / temp;
            temp = matrix[2, 0];
            for (int j = 0; j < 4; j++)
                matrix[2, j] = matrix[0, j] - matrix[2, j] * matrix[0, 0] / temp;
            temp = matrix[2, 1];
            for (int j = 0; j < 4; j++)
                matrix[2, j] = matrix[1, j] - matrix[2, j] * matrix[1, 1] / temp;

            a3 = matrix[2, 3] / matrix[2, 2];
            a2 = (matrix[1, 3] - a3 * matrix[1, 2]) / matrix[1, 1];
            a1 = (matrix[0, 3] - a3 * matrix[0, 2] - a2 * matrix[0, 1]) / matrix[0, 0];
            Console.WriteLine($"{a1} {a2} {a3}");
            QuadraticEquation result = new QuadraticEquation(a1, a2, a3);
            return result;
        }
    }
}
