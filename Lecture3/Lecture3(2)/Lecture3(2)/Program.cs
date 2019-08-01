using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3_2_
{
    class Program
    {
        static void Main(string[] args)
        {
         Console.WriteLine("Input distance(meters):");
         float meters = float.Parse(Console.ReadLine());

         Console.WriteLine("Input timeSec(hour):");
         float hour = float.Parse(Console.ReadLine());

         Console.WriteLine("Input timeSec(minutes):");
         float minutes = float.Parse(Console.ReadLine());

         Console.WriteLine("Input timeSec(seconds):");
         float seconds = float.Parse(Console.ReadLine());

         float totalTimeInSeconds = hour * 3600 + minutes * 60 + seconds;
         float miles = 1609.344F;

         float speedInMetersSec = meters / totalTimeInSeconds;
         Console.WriteLine($"Your speed in meters / sec is: {speedInMetersSec}");

         float speedInKmH = (meters / 1000) / (totalTimeInSeconds / 3600);
         Console.WriteLine($"Your speed in km / h: {speedInKmH}");

         float speedInMilesH = (meters / miles) / (totalTimeInSeconds / 3600);
         Console.WriteLine($"Your speed in miles / h is: {speedInMilesH}");

         Console.ReadKey();
        }
    }
}
