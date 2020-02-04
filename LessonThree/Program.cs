using System;

namespace LessonThree
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(FindMaxVal(new int[] {1, 2, -5, 20, 30, -45, 3}));
            Console.WriteLine(FindMaxAbsVal(new double[] { 1, 2, -5, 20, 30, -45, 3 }));
            Console.WriteLine(CreateNewArr(new int[] { 1, 2, -5, 20, 30, -45, 3 }));
        }
        static int FindMaxVal(int[] _arr)
        {
            int[] arr = _arr;
            int maxValue = arr[0];
            foreach(int i in arr)
            {
                if (i > maxValue)
                    maxValue = i;
            }
            return maxValue;
        }
        static double FindMaxAbsVal(double[] _arr)
        {
            double[] arr = _arr;
            double maxValue = arr[0];
            for (int i = 0; i < arr.Length; ++i)
            {
                if (Math.Abs(arr[i]) > Math.Abs(maxValue))
                    maxValue = arr[i];
            }
            return maxValue;
        }
        static double SumOfMaxAbsValAndSecondVal(double[] _arr)
        {
            double[] arr = _arr;
            double sum = arr[1] + FindMaxAbsVal(arr);
            return sum;
        }
        static int[] CreateNewArr(int[] _arr)
        {
            int[] arr = _arr;
            int maxVal = FindMaxVal(arr);
            int[] arrAfterEdit = arr;
            for (int i = 0; i < arr.Length; ++i)
            {
                if (arr[i] < 0)
                {
                    arrAfterEdit[i] = arr[i] + maxVal;
                }
                if (arr[i] == 0)
                {
                    arrAfterEdit[i] = 1;
                }
                if (arr[i] > 0)
                {
                    arrAfterEdit[i] = arr[i] * 2;
                }
            }
            return arrAfterEdit;
        }
        static void PrintResult()
        {
            
        }
    }
}
