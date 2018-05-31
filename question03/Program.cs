using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace question03
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruitsArray = new string[] { "Banana", "Grapefruit", "Tomato", "Oranges" };

            // List<string> fruitsList = new List<string> { "Banana", "Grapefruit", "Tomato", "Oranges" };

            Stopwatch timeForArray = new Stopwatch();
            timeForArray.Start();
            foreach (var fruit in fruitsArray)
            {
                Console.WriteLine(fruit);
            }
            timeForArray.Stop();
            System.Console.WriteLine(timeForArray.Elapsed.TotalMilliseconds);

        }
    }
}


