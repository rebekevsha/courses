using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_1
{
    class PrepareData
    {
        public double[] GetData(int a)
        {
            double[,] data = new double[,] {{ -3.45, 2.34, 1.45, 0.83 }, { 0.345, -2.25, 2.65, 3.99 }, { -2.98, 5.5, 0.045, 0.129 }};
            double[] variables = new double[4];
            switch (a)
            {
                case 1:
                    variables = CreateArr(data, a);
                    break;
                case 2:
                    variables = CreateArr(data, a);
                    break;
                case 3:
                    variables = CreateArr(data, a);
                    break;
            }
            return variables;
        }
        public double[] CreateArr(double[,] arr, int a)
        {
            double[] mass = new double[4];
            for (int i = 0; i < 4; i++)
            {
                mass[i] = arr[a - 1, i];
            }
            return mass;
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
