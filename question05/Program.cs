using System;

namespace question05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print out the division table for:");

            var number = Convert.ToInt32(Console.ReadLine());

            for(int a = 0; a <= 12; a++) {

                decimal answer=Convert.ToDecimal(Convert.ToDecimal(a) / number);
                Console.WriteLine($"{a} x {number} = {a / number}");
            }
        }
    }
}
