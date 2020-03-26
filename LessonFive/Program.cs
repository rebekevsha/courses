using System;
using System.Text;

namespace LessonFive
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car(12, "Red", 2017);

            car.ChangeYear(2016);

            foreach (Vehicle item in GetCatalog())
            {
                item.Move();
            }

            Console.ReadLine();
        }

        private static Vehicle[] GetCatalog()
        {
            return new Vehicle[] {
                new Boat(6),
                new Car(5),
                new Bicycle(1),
                new Bicycle(2),
                new Tank(4),
            };
        }
    }

    public abstract class Vehicle
    {
        public Vehicle(int numberOfSeats)
        {
            NumberOfSeats = numberOfSeats;
        }

        public Vehicle(int numberOfSeats, string color) : this(numberOfSeats)
        {
            Color = color;
        }

        public Vehicle(int numberOfSeats, string color, int yearOfIssue) : this(numberOfSeats)
        {
            Color = color;
            YearOfIssue = yearOfIssue;
        }

        public void ChangeYear(int year)
        {
            Console.WriteLine("DANGER: year is changing");
            YearOfIssue = year;
        }

        public int YearOfIssue { get; private set; }

        public string Color { get; set; }

        public int NumberOfSeats { get; private set; }

        public int Vin { get; set; }

        public virtual void Move()
        {
            Console.WriteLine($"General vehicle just moving");
        }

        public void Do()
        {
            Console.WriteLine("Do");
        }

        public override string ToString()
        {
            var str = new StringBuilder();
            str.AppendFormat("Vehicle have {0} number of seats.", NumberOfSeats);

            if (YearOfIssue != 0)
            {
                str.AppendFormat(" Year of issue - {0}.", YearOfIssue);
            }

            if (Color != string.Empty)
            {
                str.AppendFormat(" Color - {0}", Color);
            }

            return str.ToString();
        }
    }


    public class Tank : Vehicle
    {
        public Tank(int numberOfSeats) : base(numberOfSeats)
        {
        }

        public Tank(int numberOfSeats, string color) : base(numberOfSeats, color)
        {
        }

        public override void Move()
        {
            base.Move();

            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return $"Tank: {YearOfIssue} {Color}";
        }
    }

    public class Person
    {
        private readonly SalaryCalculator _salaryCalculator;

        public Person(SalaryCalculator salaryCalculator)
        {
            _salaryCalculator = salaryCalculator;
        }

        public decimal Calculate()
        {
            return _salaryCalculator.Calculate();
        }
    }

    public sealed class SalaryCalculator
    {
        public decimal Calculate() => 0m;
    }

    public class Boat : Vehicle
    {
        public Boat(int numberOfSeats) : base(numberOfSeats)
        {
        }

        public Boat(int numberOfSeats, string color) : base(numberOfSeats, color)
        {
        }

        public override void Move()
        {
            Console.WriteLine($"Хлюп-хлюп x{NumberOfSeats}");
        }

        public string OceanBoat { get; set; }
    }

    public class Car : Vehicle
    {
        public Car(int numberOfSeats) : base(numberOfSeats)
        {
        }

        public Car(int numberOfSeats, string color, int year) : base(numberOfSeats, color)
        {
        }

        public override void Move()
        {
            Console.WriteLine($"Врум-врум x{NumberOfSeats}");
        }

        public string Engine { get; set; }
    }

    public class Bicycle : Vehicle
    {
        public Bicycle(int numberOfSeats) : base(numberOfSeats)
        {
        }
        public Bicycle(int numberOfSeats, string color) : base(numberOfSeats, color)
        {
        }
        public override void Move()
        {
            Console.WriteLine($"Ой-бля x{NumberOfSeats}");
        }
    }
}