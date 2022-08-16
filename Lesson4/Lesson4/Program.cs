using System;

namespace Lesson4
{
    class Program
    {
        private static string name;

        static void Main(string[] args)
        {
            Console.WriteLine("Enter you name: ");
            name = Console.ReadLine();

            switch (name)
            {
                case "John":
                    Method();
                    break; // ending case
                case "Ben":
                    Method();
                    break;
                case "Tommy":
                    Method();
                    break;

                default: // If doesn't match to any of cases
                    Console.WriteLine("Your name is not on our list.");
                    break;
            }
        }

        private static void Method()
        {
            Console.WriteLine("You're on our list.");
        }
    }
}
