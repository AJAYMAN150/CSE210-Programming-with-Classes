using System;
using System.Collections.Generic;

namespace ExerciseTracking
{
    public class Activity
    {
        // Private fields to ensure encapsulation
        private string _date;
        private int _minutes;

        public Activity(string date, int minutes)
        {
            _date = date;
            _minutes = minutes;
        }

        // Properties to access the encapsulated fields
        public string Date => _date;
        public int Minutes => _minutes;

        // Virtual methods for polymorphism, to be overridden in derived classes
        public virtual double GetDistance() => 0;
        public virtual double GetSpeed() => 0;
        public virtual double GetPace() => 0;

        // Summary method that utilizes polymorphic methods
        public virtual string GetSummary()
        {
            return $"{Date} ({Minutes} min): Distance {GetDistance():0.0} km, Speed {GetSpeed():0.0} kph, Pace {GetPace():0.0} min per km";
        }
    }

    public class Running : Activity
    {
        private double _distance;

        public Running(string date, int minutes, double distance) : base(date, minutes)
        {
            _distance = distance;
        }

        public override double GetDistance() => _distance;
        public override double GetSpeed() => (_distance / Minutes) * 60;
        public override double GetPace() => Minutes / _distance;
    }

    public class Cycling : Activity
    {
        private double _speed;

        public Cycling(string date, int minutes, double speed) : base(date, minutes)
        {
            _speed = speed;
        }

        public override double GetDistance() => (_speed * Minutes) / 60;
        public override double GetSpeed() => _speed;
        public override double GetPace() => 60 / _speed;
    }

    public class Swimming : Activity
    {
        private int _laps;

        public Swimming(string date, int minutes, int laps) : base(date, minutes)
        {
            _laps = laps;
        }

        public override double GetDistance() => (_laps * 50) / 1000.0;
        public override double GetSpeed() => (GetDistance() / Minutes) * 60;
        public override double GetPace() => Minutes / GetDistance();
    }

    public class Program
    {
        public static void Main()
        {
            var activities = new List<Activity>
            {
                new Running("03 Nov 2022", 30, 4.8),
                new Cycling("03 Nov 2022", 40, 20),
                new Swimming("03 Nov 2022", 25, 30)
            };

            foreach (var activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }
    }
}
