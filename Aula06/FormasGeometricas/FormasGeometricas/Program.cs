using System;

namespace GeometricForms
{
    class Program
    {
        static void Main(string[] args)
        {
            Square      s = new Square("Square", "Blue", 2.2);
            s.ShowFigure();
            Circle      c = new Circle("Circle", "Yellow", 2);
            c.ShowFigure();
            Triangle    t = new Triangle("Triangle", "Grey", 34, 23, 24);
            t.ShowFigure();
        }
    }
}
