using System;

namespace ConsoleApp1
{
    public class Task1
    {
        public static void Main(String[] args)
        {
            PrintResults(0, 0);
            PrintResults(0, 1);
            PrintResults(1, 0);
            PrintResults(1, 1);
            PrintResults(2, 1);
            PrintResults(1, 2);
            PrintResults(2, -10);
            PrintResults(20, 20);
            PrintResults(21, 21);
            PrintResults(1, 10);
            PrintResults(-1, 10);
            PrintResults(0, Double.MaxValue);
            PrintResults(1, Double.MaxValue);
            PrintResults(1, Double.NaN);
        }
        public static double Axx(double a, double x)
        {
            if (a < 0 || a > 20)
            {
                throw new ArgumentOutOfRangeException(nameof(a), a, "Invalid value");
            }
            return a * x * x;
        }
        static void PrintResults(double a, double x)
        {
            Console.Write($"a:{a} x:{x} result:");
            try
            {
                Console.WriteLine(Axx(a, x));
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("EXCEPTION! {0}", e.Message);
            }
        }
    }
}
