using System;

namespace LessonTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateSum(15, 5);
        }
        static void CalculateSum(double k, double z)
        {
            const int max = 15;
            if (k < 1 || k >= 15)
            {
                throw new ArgumentOutOfRangeException(nameof(k), k, "Invalid value");
            }
            double sum = 0;
            for (int i = 1; i < k; ++i)
            {
                sum = Mathlib.Equations.EquationFour(i, k, z); 
            }
            Console.WriteLine($"k:{k} z:{z} sum: ");
        }
    }
}
