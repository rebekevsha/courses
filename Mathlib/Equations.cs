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
        public static double EquationFour(double i, double k, double z)
        {
            double res = (1 / Math.Sqrt(z * i)) + (Math.Tan(k / i));
            return res;
        }
        public static double EquationFiveOne(double t, double l)
        {
            double res = (1 / t) * l;
            return res;
        }
        public static double EquationFiveTwo(double t, double l)
        {
            double res = (1 / Math.Sqrt(t)) * l;
            return res;
        }
        public static double EquationSix(double i)
        {
            double res = Math.Pow((-1), i) / FactNaive(i);
            return res;
        }
        static double FactNaive(double n)
        {
            int r = 1;
            for (int i = 2; i <= n; ++i)
                r *= i;
            return r;
        }
    }
}
