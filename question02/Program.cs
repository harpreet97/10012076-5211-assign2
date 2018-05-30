using System;

namespace question02
{
    class Program
    {
        

        static void Main(string[] args)
        {
            string[] fruits = new string[5] {"Apple", "Banana", "Coconut", "Mandarin", "Mango" };

            foreach(var fruit in fruits) {
                Console.Write(fruit);
            }
        }
    }
}
