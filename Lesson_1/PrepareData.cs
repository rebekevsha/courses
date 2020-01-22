using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_1
{
    class PrepareData
    {
        public double[] GetData()
        {
            double[] variables = new double[4];
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Введите число {i + 1}");
                variables[i] = double.Parse(Console.ReadLine());
            }
            return variables;
        }

        //public double[] GetData()
        //{
        //    double[] variables = new double[4];
        //    for (int i = 0; i < 4; i++)
        //    {
        //        Console.WriteLine($"Введите число {i+1}");
        //        variables[i] = double.Parse(Console.ReadLine());
        //    }
        //    return variables;
        //}
    }
}
