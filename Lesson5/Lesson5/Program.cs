using System;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            // loops

            int length = 10;
            int wlength = 0;
            int dwlength = 6;
            int[] numbers = { 1, 22, 12, 54, 8, 163, 37, 99 };

            for (int i = 0; i <= length; i++) // the first value increments only once so we make i = 0, second do while i is smaller or same as lenght variable and last one add one number to i every time a loop is made
            {
                Console.WriteLine("Number: " + i);
            }
            Console.WriteLine("---------------------");
            while (wlength < 5) // do while wlength is smaller than 5
            {
                Console.WriteLine("WNumber: " + wlength);
                wlength++;
            }
            Console.WriteLine("---------------------");
            do // in a do while loop, the code after do is executed first and then the condition is tested so we know that this loop will always do at least once
            {
                Console.WriteLine("DWNumber: " + dwlength);
                dwlength++;
            } while (dwlength < 5);
            Console.WriteLine("---------------------");
            foreach (var number in numbers)
            {
                Console.WriteLine("Our variable number has number: " + number);
            }
        }
    }
}
