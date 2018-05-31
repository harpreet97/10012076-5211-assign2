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

            List<string> fruitsList = new List<string> { "Banana", "Grapefruit", "Tomato", "Oranges" };

            Stopwatch timeForArray = new Stopwatch();
            timeForArray.Start();// Start Method
            foreach (var fruit in fruitsArray)// Added this foreach loop within the class to calculate the total time taken by an array.
            {
                Console.WriteLine(fruit);
            }
            timeForArray.Stop();// Stopped the stopwatch
            System.Console.WriteLine($"Total time taken by an array {timeForArray.Elapsed.TotalMilliseconds} ms");// It shows the exact time that it takes to run the array 

            Stopwatch timeForList = new Stopwatch();
            timeForList.Start();// Start Method for a list.
            foreach (var fruit in fruitsList)
            {
                Console.WriteLine(fruit);
            }
            timeForList.Stop();
            System.Console.WriteLine(timeForList.Elapsed.TotalMilliseconds);
        }
    }
}


