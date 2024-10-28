using System;
using System.Collections.Generic;

namespace ExerciseTracking
{
    public class Program
    {
        public static void Main()
        {
            // Create instances of each activity type
            var runningActivity = new Running("03 Nov 2022", 30, 5);      // 5 km
            var cyclingActivity = new Cycling("04 Nov 2022", 45, 20);     // 20 kph
            var swimmingActivity = new Swimming("05 Nov 2022", 40, 20);   // 20 laps

            // Add them to a list of Activity type
            List<Activity> activities = new List<Activity>
            {
                runningActivity,
                cyclingActivity,
                swimmingActivity
            };

            // Iterate over each activity and display its summary
            foreach (Activity activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }
    }
}
