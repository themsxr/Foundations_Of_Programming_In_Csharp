using System;

namespace Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            // BREAK <--- We used break in switch to end cases but you can end any loop with break too (for, foreach, while, do while)
            // CONTINUE <--- We can use continue to stop if instruction and do not execute the code below
            // GOTO <--- With this we can end our if instruction and loop, not execute the code below too but not only in our if instruction or loop but we skip whole code to the line where we put our "label" like in example below

            int[] numbers = { 1, 5, 6, 22, 66, 11, 153, 642, 12 };

            foreach (var number in numbers)
            {
                Console.WriteLine("We've number: " + number);
                if (number == 22)
                {
                    Console.WriteLine("Now we got number 22 and we go to line where's our label\n---------------------------------");
                    goto label;
                }
            }

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

        label:
            Console.WriteLine("We're here and skipped loop above us");

            foreach (var number in numbers)
            {
                Console.WriteLine("Now we get number: " + number);

                if (number == 22)
                {
                    Console.WriteLine("We got number 22 but it's not the end.");
                    continue; // with that we stop doing code below, closing if instruction and continue with loop again not ending loop
                    // for example we did console writeline test below
                }

                Console.WriteLine("test");

                if (number == 11)
                {
                    Console.WriteLine("We got number 11!");
                    break; // we end our loop
                }
            }
        }
    }
}
