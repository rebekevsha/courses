using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathlib
{
    public static class Equations
    {
        public static double EquationOne(double a, double b, double c, double d)
        {
            double res = Math.Pow((4 * Math.Cosh(Math.Sqrt(Math.Abs(a / b)))) + (3 * Math.Acos(d)), c);
            return res;
        }
        public static double EquationTwo(double a, double b, double c, double d)
        {
            double res = ((5 * a) / Math.Sin(a)) + Math.Sqrt((Math.Tanh(Math.Abs(b) * c)) / Math.Log(d));
            return res;
        }
        public static double EquationThree(double a, double b, double c, double d)
        {
            double res = (Math.Sin(Math.Abs(a)) + Math.Cos(Math.Sqrt(b))) / (2 * Math.Tan(c) + Math.Pow(Math.E, d));
            return res;
        }
    }
}
