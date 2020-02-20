using System;

namespace LessonFive
{
    class Program
    {
        static void Main(string[] args)
        {
            Student vasia = new Student() {FirstName = "ПЕТРО", LastName = "Вуйко" };
            var nae = vasia.LastName.ToString();
            Console.WriteLine(nae);
        }
    }
    class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Human(string FirstName)
        {
        }
    }
    class Student : Human
    {
        public string University { get; set; }
        public string Сourse { get; set;}
        public string Faculty { get; set; }

        public Student() : base
        {
        }
    }
}
