using System;

namespace Lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            PrepareData data = new PrepareData();
            double result = new Equation().EquationFirst(data.GetData());
            Console.WriteLine(result);
        }
    }
}
