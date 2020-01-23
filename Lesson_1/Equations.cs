using System;
using System.Collections.Generic;
using System.Text;

namespace LessonOne
{
    class Equations
    {     
        public double Equation(double[] data, int cwcase)
        {
            double[] vars = data;
            double a = vars[0];
            double b = vars[1];
            double c = vars[2];
            double d = vars[3];
            double res = 0;
            switch(cwcase)
            {
                case 1:
                    res = Math.Pow((4 * Math.Cosh(Math.Sqrt(Math.Abs(a / b)))) + (3 * Math.Acos(d)), c);
                    break;
                case 2:
                    res = ((5 * a) / Math.Sin(a)) + Math.Sqrt(( Math.Tanh(Math.Abs(b) * c)) / Math.Log(d));
                    break;
                case 3:
                    res = (Math.Sin(Math.Abs(a)) + Math.Cos(Math.Sqrt(b))) / (2 * Math.Tan(c) + Math.Pow(Math.E, d));
                    break;
            }
            return res;
        }
    }
}