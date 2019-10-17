using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricForms
{
    class Triangle : Figure
    {
        public double Side1, Side2, Side3;
        public Triangle(string format, string color, double side1, double side2, double side3)
                    : base(format, color)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
            Area = AreaCalc();
        }

        public override double AreaCalc()
        {
            /* Heron Formule
            * A = sqrt of p*(p-a)*(p-b)*(p-c)
            * 
            * A: triangle area
            * p: semiperimeter
            * a, b e c: triangle sides
            * 
            * Perimeter is the sum of all sides of the figure, so the triangle semiperimeter is half of perimeter:
            * p = (a+b+c)/2
            */
            double p = (Side1 + Side2 + Side3) / 2;
            return Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
        }

        public override void ShowFigure()
        {
            base.ShowFigure();
        }
    }

}
