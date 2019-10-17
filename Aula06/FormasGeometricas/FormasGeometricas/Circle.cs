using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricForms
{
    class Circle : Figure
    {
        public double Radius;
        public Circle(string format, string color, double radius)
                    : base(format, color)
        {
            Radius = radius;
            Area = AreaCalc();
        }

        public override double AreaCalc()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override void ShowFigure()
        {
            base.ShowFigure();
        }
    }
}
