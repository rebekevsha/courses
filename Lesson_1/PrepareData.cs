using System;
using System.Collections.Generic;
using System.Text;

namespace LessonOne
{
    class PrepareData
    {
        public static int TakeTask()
        {
            int task;
            Console.WriteLine("Введите номер задания(от 1 до 3):");
            while (true)
            {
                var isInt = int.TryParse(Console.ReadLine(), out task);
                if (!isInt)
                {
                    Console.WriteLine("Ошибка ввода. Введите Число.");
                    continue;
                }
                if (!(0 < task && task < 4))
                {
                    Console.WriteLine("Введите значение существующего варианта.");
                    continue;
                }
                break;
            }
            return task;
        }
    }
}
