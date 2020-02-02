using System;

namespace LessonTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Уравнение 1
            // CalculateSum(14, 5);

            //Уравнение 2
            CalculateSum(14, 5, 4);
            CalculateSum(14, 5, 0);
            CalculateSum(14, 5, -1);
            //Уравнение 3
            PrintResult(-5);
            PrintResult(5);
            PrintResult(0.5);
            PrintResult(0.05);
            PrintResult(0.005);
            PrintResult(0.0005);
        }
        static void PrintResult(double k, double z)
        {

            Console.WriteLine($"Результат уравнения 1 с параметрами k: {k}, z:{z} следующий: ");
            try
            {
                Console.WriteLine(CalculateSum(k, z));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void PrintResult(double k, double z, int l)
        {

            Console.WriteLine($"Результат уравнения 2 с параметрами k: {k}, z:{z}, l:{l}  следующий: ");
            try
            {
                Console.WriteLine(CalculateSum(k, z, l));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void PrintResult(double k)
        {
            Console.WriteLine($"Результат уравнения 3 с заданой точностью k: {k} следующий:  ");
            try
            {
                Console.WriteLine(CalculateSum(k));
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static double CalculateSum(double k, double z)
        {
            if (k < 1 || k >= 15)
            {
                throw new ArgumentOutOfRangeException(nameof(k), k, "Invalid value");
            }
            double sum = 0;
            for (int i = 1; i < k; ++i)
            {
                sum += Mathlib.Equations.EquationFour(i, k, z);
            }
            return sum;
        }
        static double CalculateSum(double k, double z, int l)
        {
            if (l <= 0 )
            {
                throw new ArgumentOutOfRangeException(nameof(k), k, "Invalid value" + k);
            }
            double sum = 0;
            for (int i = 1; i < k; ++i)
            {
                if ((l % 2) == 0)
                    sum += Mathlib.Equations.EquationFiveTwo(z, l);
                else
                    sum += Mathlib.Equations.EquationFiveOne(z, l);
            }
            return sum;
        }
        static double CalculateSum(double k)
        {
            if (k < 0 )
            {
                throw new ArgumentOutOfRangeException(nameof(k), k, "Invalid value");
            }
            double sum = 0;
            double i = 1;
            double iValue = 0;
            while (true)
            {
                iValue = Mathlib.Equations.EquationSix(i);
                if (Math.Abs(iValue) < k)
                {
                    break;
                }
                else
                {
                    sum += iValue;
                    i++;
                }
            }
            return sum;
        }
    }
}
