using System;

namespace LessonFour
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] numbers1 = { 10, 20, 15, 45, 78, 62, 42, 52, 20, 24, 25, 46, 2, 1, 2, -5, 20, 30, -45, 3 };
            long[] numbers2 = { 5, 98, 54, 20, 1, 65, 53, 52, 41, 2, 6, 7, 5, 15, 2, 47, 95, 2, 78 ,24, 14};

            //Lab - 6, Task - 2
            Console.WriteLine("Array 1 Before Sort : [{0}]", string.Join(", ", numbers1));
            InsertionSort(numbers1);
            Console.WriteLine("Insertion Sort : [{0}]", string.Join(", ", numbers1));

            //Lab - 6, Task - 1
            Console.WriteLine("Array 2 Before Sort : [{0}]", string.Join(", ", numbers2));
            BubbleSort(numbers2);
            Console.WriteLine("Bubble Sort : [{0}]", string.Join(", ", numbers2));
        }
        static void InsertionSort(long[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; ++i)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (numbers[j - 1] > numbers[j])
                    {
                        SwapNumbers(numbers, j, j - 1);
                    }
                }
            }
        }
        static void BubbleSort(long[] numbers)
        {
            bool swapped = true;
            while (swapped == true)
            {
                swapped = false;
                for (int i = 1; i < numbers.Length; ++i)
                {
                    if (numbers[i - 1] > numbers[i])
                    {
                        SwapNumbers(numbers, i - 1, i);
                        swapped = true;
                    }
                }
            }
        }
        static void SwapNumbers(long[] mass, int num1, int num2)
        {
            long temp = mass[num1];
            mass[num1] = mass[num2];
            mass[num2] = temp;
        }
    }
}
