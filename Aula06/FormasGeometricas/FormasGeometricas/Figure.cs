using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricForms
{
    abstract class Figure
    {
        public string Format { get; set; }
        public string Color { get; set; }
        public double Area { get; set; }

        public Figure() { }

        public Figure(string format, string color)
        {
            Format  = format;
            Color   = color;
        }

        public virtual void ShowFigure()
        {
            Console.WriteLine("Forma: " + Format);
            Console.WriteLine("Cor:   " + Color);
            Console.WriteLine("Area:  " + Area);
        }

        // How to implement this method with diferent signatures (VIRTUAL + ABSTRACT)
        public abstract double AreaCalc();
    }
}
