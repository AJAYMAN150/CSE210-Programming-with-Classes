namespace ExerciseTracking
{
    public class Activity
    {
        private string _date;
        private int _minutes;

        public Activity(string date, int minutes)
        {
            _date = date;
            _minutes = minutes;
        }

        public string Date => _date;
        public int Minutes => _minutes;

        public virtual double GetDistance() => 0;
        public virtual double GetSpeed() => 0;
        public virtual double GetPace() => 0;

        public virtual string GetSummary()
        {
            return $"{Date} ({Minutes} min): Distance {GetDistance():0.0} km, Speed {GetSpeed():0.0} kph, Pace {GetPace():0.0} min per km";
        }
    }
}
