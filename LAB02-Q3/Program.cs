using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB02_Q3
{


    class TemperatureTracker
    {
        private double[] weeklyTemperatures;


        public TemperatureTracker(int daysOfWeek)
        {
            weeklyTemperatures = new double[daysOfWeek];
        }


        public void InputTemperatures()
        {
            for (int i = 0; i < weeklyTemperatures.Length; i++)
            {
                Console.Write($"Enter temperature for day {i + 1}: ");
                weeklyTemperatures[i] = Convert.ToDouble(Console.ReadLine());
            }
        }


        public void DisplayWeeklyTemperatureReport()
        {
            Console.WriteLine("\nWeekly Temperature Report:");
            for (int i = 0; i < weeklyTemperatures.Length; i++)
            {
                Console.WriteLine($"Day {i + 1}: {weeklyTemperatures[i]}");
                Console.ReadLine();

            }
        }
    }

    class Program
    {
        static void Main()
        {

            int daysOfWeek = 7;


            TemperatureTracker tracker = new TemperatureTracker(daysOfWeek);


            tracker.InputTemperatures();


            tracker.DisplayWeeklyTemperatureReport();
        }
    }

}
