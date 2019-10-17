using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricForms
{
    class Square : Figure
    {
        public double Side;
        public Square(string format, string color, double side)
                    : base(format, color)
        {
            Side = side;
            Area = AreaCalc();
        }

        public override double AreaCalc()
        {
            return Side * Side;
        }

        public override void ShowFigure()
        {
            base.ShowFigure();
        }
    }
}
