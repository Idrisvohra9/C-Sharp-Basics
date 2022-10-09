using System;
using System.Collections.Generic;
using System.Text;
//using System.Linq.;
namespace Shape_Calculations
{
    abstract class AbstractMethods
    {
        // Basic number arithmatic methods:

        public double Sum(double n1, double n2) => n1 + n2;

        public double Mul(double n1, double n2) => n1 * n2;

        public double Div(double n1, double n2) => n1 / n2;

        public double Sub(double n1, double n2) => n1 - n2;

        public const double pi = 3.14;

        // Methods to calculate Area of 2d shapes:

        public double Area_Circle(double r) => pi * (r * r);

        public double Area_Square(double x) => x * x;

        public double Area_Rectangle(double l, double b) => l * b;

        public double Area_RightAngledTriangle(double b, double h) => 1 / 2 * (b*h);

        public double Area_EquilateralTriangle(double s) => (Math.Sqrt(3) / 4) * (Math.Pow(s, 2));

        public double Area_IsoscelesTriangle(double b, double h) => (b*h)/2;


    }
}
