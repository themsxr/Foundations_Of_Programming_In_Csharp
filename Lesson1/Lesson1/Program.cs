using System;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables

            int someNumber;

            // Int variable, only integers (like 1, 2, 10, 5235, etc.)
            int IntMax = int.MaxValue; // MaxValue gives us maximum value of variable
            int IntMin = int.MinValue; // MinValue gives us minimum value of variable

            /*
             * Hover on Min or MaxValue to display information about it
             */

            sbyte variable1_0 = sbyte.MaxValue; // only integers
            byte variable1 = byte.MaxValue; 
            // ^ 1 byte

            ushort variable2_0 = ushort.MaxValue; // only integers
            short variable2 = short.MaxValue;
            // ^ 2 bytes

            uint variable0 = uint.MaxValue; // only integers
            int variable = int.MaxValue;
            // ^ 4 bytes

            ulong variable3_0 = ulong.MaxValue; // only integers
            long variable3 = long.MaxValue;
            // ^ 8 bytes

            float variable4 = float.MaxValue; // decimal numbers
            // ^ 4 bytes

            double variable5 = double.MaxValue; // decimal numbers
            // ^ 8 bytes

            bool variable6 = true; // false or true
            // ^ 1 byte

            decimal variable7 = decimal.MaxValue; // largest integers
            // ^ 16 bytes

            char variable8 = 'A'; // declare letter only in '...' not in "..."
            // ^ 2 bytes

            string sometext = "cpp"; // Variable for text 
            // ^ 2 bytes * number of characters (in ex. 6 bytes)

            // variable "var" takes the type as we specify the value for example:
            var anyint = 2; // int
            var anybool = true; // bool
            var anydouble = 2.514; // double
            var anytext = "cpp"; // string
            var anyletter = 'A'; // char
            // Later you can't change type of variable var for example
            // anyint = false; <--- anyint is int so we can't change it to bool

            const string variable99 = "My Name"; // <--- nothing can change constant variable, you can't modify it
            const string variable98 = "Michael";

            // Operators

            var num1 = 4;
            var num2 = 5;

            var sum1 = num1 + num2; // Adding numbers
            var sum2 = num1 - num2; // subtraction of numbers
            var sum3 = num1 * num2; // multiplication of numbers
            var sum4 = num1 / num2; // dividing numbers
            var sum5 = num1 % num2; // division with remainder

            var sum6 = variable99 + variable98; // Adding strings, output: My Name Michael


        }
    }
}
