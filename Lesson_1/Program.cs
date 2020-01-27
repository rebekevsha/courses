using System;
using Mathlib;

namespace LessonOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int task = PrepareData.TakeTask();
            double result = 0;
            switch (task)
            {
                case 1:
                    result = Equations.EquationOne(-3.45, 2.34, 1.45, 0.83);
                    break;
                case 2:
                    result = Equations.EquationTwo(0.345, -2.25, 2.65, 3.99);
                    break;
                case 3:
                    result = Equations.EquationThree(-2.98, 5.5, 0.045, 0.129);
                    break;
            }
            Console.WriteLine($"Результаты просчета уровнения {task}: " + result);
        }
    }
}
