using System;

namespace Lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            // RETURN & FUNCTIONS <-- in every method we can use return to return something, in void method we can use return too!

            int[] numbers = { 1, 4, 6, 68, 15, 77, 122, 85, 194 };
            int add1 = 5, add2 = 10;
            float fadd1 = 20.2f, fadd2 = 25.5f;

            Console.WriteLine("Int method return: " + AddingNumbers(add1, add2));
            var intResult = AddingNumbers(add1, add2);

            Console.WriteLine("Bool method return: " + CheckMethod(intResult));
            Console.WriteLine("Float method return: " + AddingNumbers2(fadd1, fadd2));
            Console.WriteLine("Void method return: ");
            Method(numbers);
            Console.WriteLine("But we stopped execute whole void method");
        }

        private static int AddingNumbers(int add1, int add2)
        {
            var sum = add1 + add2;
            return sum;
        }

        private static bool CheckMethod(int intResult)
        {
            if (intResult < 15)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        
        private static float AddingNumbers2(float fadd1, float fadd2)
        {
            var sum = fadd1 + fadd2;
            return sum;
        }

        private static void Method(int[] numbers)
        {
            foreach (var number in numbers)
            {
                if (number == 77)
                {
                    Console.WriteLine("We got number 77 and we stop here and return: nothing");
                    return;
                }
            }
            Console.WriteLine("test");
        }
    }
}
