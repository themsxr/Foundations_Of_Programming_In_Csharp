using System;

namespace Lesson3
{
    class Program
    {

        private static int age;
        static void Main(string[] args)
        {
            Console.WriteLine("What's your age?: ");
            age = int.Parse(Console.ReadLine());

            string check = age > 18 ? "Adult" : "Teen/Child"; // If is true we assign value after "?" if it's false then value after ":" in example: Age 22 -> true: ? "Adult", Age 12 --> false: : "Teen/Child"
            Console.WriteLine(check);

            if (age < 18)
            {
                Method1();
            }
            else if (age < 30)
            {
                Method2();
            }
            else
            {
                Method3();
            }
        }

        private static void Method3()
        {
            Console.WriteLine("Grandpa is that you?");
        }

        private static void Method2()
        {
            Console.WriteLine("You're under older than 18 and younger than 30 :o");
        }

        private static void Method1()
        {
            Console.WriteLine("You're young!");
        }
    }
}
