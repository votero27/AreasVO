using System;
using System.Collections.Generic;
using System.Text;

namespace AppLoger
{
    public class AreasCalculator
    {
        public static double areaTriangle(double baseT, double height)
        {
            return (1 / 2) * baseT * height;
        }

        public static double areaRectangle(double width, double height)
        {
            return width * height;
        }

        public static double areaTrapezoid(double a, double b, double height)
        {
            return (1 / 2) * (a + b) * height;
        }

        public static double areaEllipse(double a, double b)
        {
            const double PI = 3.1415926535897932384626433832;
            return PI * a * b;
        }

        public static double areaSquare(double a)
        {
            return Math.Pow(a, 2);
        }

        public static double areaParallelogram(double a, double h)
        {
            return a * h;
        }

        public static double areaCricle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public static double areaSector(double radius, double angle)
        {
            return (1 / 2) * Math.Pow(radius, 2) * angle;
        }
    }
}
