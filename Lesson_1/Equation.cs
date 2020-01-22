using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_1
{
    class Equation
    {
        public double EquationFirst(double[] data)
        {
            double[] vars = data;
            double a = vars[0];
            double b = vars[1];
            double c = vars[2];
            double d = vars[3];
            double res = Math.Pow((Convert.ToDouble(4) * Math.Cosh(Math.Sqrt(Math.Abs(a / b)))) + (Convert.ToDouble(3) * Math.Acos(d)), c);
            return res;
        }
    }
}


