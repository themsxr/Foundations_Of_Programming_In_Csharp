using System;

namespace Lesson10
{
    class Program
    {
        static void Main(string[] args)
        {
            // ENUM

            Currency curr = Currency.USD;

            Console.WriteLine(curr);
            Console.WriteLine("--------------------------");

            switch (curr)
            {
                case Currency.USD:
                    Console.WriteLine(curr);
                    break;
                case Currency.PLN:
                    Console.WriteLine(curr);
                    break;
                case Currency.GBP:
                    Console.WriteLine(curr);
                    break;
                case Currency.EUR:
                    Console.WriteLine(curr);
                    break;
                default:
                    break;
            }

        }
    }

    enum Currency
    {
        USD,
        PLN,
        GBP,
        EUR
    }
}
