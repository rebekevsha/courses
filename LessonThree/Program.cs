using System;

namespace LessonThree
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lab 5 - Task 1
            Console.WriteLine("Lab 5 - Task 1 - Найти столбцы с мин и макс елементами и заменить местами(при повторении мин или макс для мин берем первый для макс берем последний)");
            int[,] matrix = new int[,] { { 1, 1, 0, 4, 5 }, { 3, 4, 5, 6, 7 }, { 5, 6, 7, 8, 9 }, { 7, 8, 9, 10, 11 } };
            PrintMatrix(matrix);

            Console.WriteLine("Матрица после преобразования");
            PrintMatrix(SwapColumn(matrix));

            //Lab 4 - Task 1
            Console.WriteLine("Lab 4 - Task 1 - Найти максимальный елемент массива");
            Console.WriteLine(FindMaxVal(new int[] { 1, 2, -5, 20, 30, -45, 3 }));

            //Lab 4 - Task 2
            Console.WriteLine("Lab 4 - Task 2 - Найти сумму максимального по модулю значения и второго значения в массиве ");
            Console.WriteLine(SumOfMaxAbsValAndSecondVal(new double[] { 1, 2, -5, 20, 30, -45, 3 }));

            //Lab 4 - Task 3
            Console.WriteLine("Lab 4 - Task 3 - До всех отрицательных додать максимальный елемент, всем что = 0 присвоить 1, все положительные умножить на 2");
            CreateNewArr(new int[] { 1, 2, -5, 20, 30, -45, 3 });
            Console.ReadKey();
        }

        //Lab 4 - Task 1--------------------------------------------------------------------------------------------------------
        static int FindMaxVal(int[] arr)
        {
            int maxValue = arr[0];
            foreach(int i in arr)
            {
                if (i > maxValue)
                    maxValue = i;
            }
            return maxValue;
        }

        //Lab 4 - Task 2--------------------------------------------------------------------------------------------------------
        static double FindMaxAbsVal(double[] arr)
        {
            double maxValue = arr[0];
            for (int i = 0; i < arr.Length; ++i)
            {
                if (Math.Abs(arr[i]) > Math.Abs(maxValue))
                    maxValue = arr[i];
            }
            return maxValue;
        }
        static double SumOfMaxAbsValAndSecondVal(double[] arr)
        {
            double sum = arr[1] + FindMaxAbsVal(arr);
            return sum;
        }

        //Lab 4 - Task 3--------------------------------------------------------------------------------------------------------
        static void CreateNewArr(int[] arr)
        {
            int maxVal = FindMaxVal(arr);
            int[] arrAfterEdit = arr;
            for (int i = 0; i < arr.Length; ++i)
            {
                if (arr[i] < 0)
                {
                    arrAfterEdit[i] = arr[i] + maxVal;
                }
                else if (arr[i] == 0)
                {
                    arrAfterEdit[i] = 1;
                }
                else if (arr[i] > 0)
                {
                    arrAfterEdit[i] = arr[i] * 2;
                }
            }
            foreach (int i in arrAfterEdit)
            {
                Console.Write(i + " ");
            }
        }

        //Lab 5 - Task 1--------------------------------------------------------------------------------------------------------
        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); ++i)
            {
                Console.Write("{ ");
                for (int j = 0; j < matrix.GetLength(1); ++j)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine("}");
            }
        }
        static int[,] SwapColumn(int[,] matrix)
        {
            int[] minValColumn = new int[0];
            int[] maxValColumn = new int[0];
            int minVal = matrix[0, 0];
            int maxVal = matrix[0, 0];
            int tempVal = 0;
            for (int j = 0; j < matrix.GetLength(1); ++j)
            {
                for (int i = 0; i < matrix.GetLength(0); ++i)
                {
                    if (matrix[i, j] < minVal)
                    {
                        Array.Resize(ref minValColumn, 1);
                        minValColumn[0] = j;
                        minVal = matrix[i, j];
                    }
                    if (matrix[i, j] == minVal)
                    {
                        Array.Resize(ref minValColumn, minValColumn.Length + 1);
                        minValColumn[minValColumn.Length - 1] = j;
                    }
                    if (matrix[i, j] > maxVal)
                    {
                        Array.Resize(ref maxValColumn, 1);
                        maxValColumn[0] = j;
                        maxVal = matrix[i, j];
                    }
                    if (matrix[i, j] == maxVal)
                    {
                        Array.Resize(ref maxValColumn, maxValColumn.Length + 1);
                        maxValColumn[maxValColumn.Length - 1] = j;
                    }
                }
            }
            for (int i = 0; i < matrix.GetLength(0); ++i)
            {
                tempVal = matrix[i, minValColumn[0]];
                matrix[i, minValColumn[0]] = matrix[i, maxValColumn[maxValColumn.Length - 1]];
                matrix[i, maxValColumn[maxValColumn.Length - 1]] = tempVal;
            }
            return matrix;
        }
    }
}
