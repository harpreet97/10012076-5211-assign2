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
            timeForArray.Start();// Start Method
            foreach (var fruit in fruitsArray)// Added this foreeach loop within the class to calculate the total time taken by an array.
            {
                Console.WriteLine(fruit);
            }
            timeForArray.Stop();// Stoped the stopwatch
            System.Console.WriteLine(timeForArray.Elapsed.TotalMilliseconds);// It shows the time that it takes to run the array 


        }
    }
}


