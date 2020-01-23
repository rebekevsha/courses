using System;

namespace LessonOne
{
    class Program
    {
        static void Main(string[] args)
        {
            PrepareData data = new PrepareData();

            for(int i = 1; i < 4; i++)
            {
                Console.WriteLine($"Значения переменных уровнения {i}:  a = {(data.GetData(i)[0])}    b = {(data.GetData(i)[1])}    c = {(data.GetData(i)[2])}    d = {(data.GetData(i)[3])}");
                double result = new Equations().Equation(data.GetData(i), i);
                Console.WriteLine($"Результаты просчета уровнения {i}: " + result);
                Console.WriteLine("Eah!!");
            }
            Console.ReadKey(); 
        }
    }
}
