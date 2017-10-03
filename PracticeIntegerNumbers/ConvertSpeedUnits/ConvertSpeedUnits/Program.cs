using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanceInMetres = int.Parse(Console.ReadLine());
           int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());
            float time = (float)(hours * 3600 + minutes * 60 + seconds);
            float metresPerSecond=(float)distanceInMetres/time;
            float kilometresPerHours =(float)(distanceInMetres / 1000) /time / 3600;
            float milesPerHour=(float)(distanceInMetres/1609)/time/3600;
            Console.WriteLine(metresPerSecond);
            Console.WriteLine(kilometresPerHours);
            Console.WriteLine(milesPerHour);
        }
    }
}
