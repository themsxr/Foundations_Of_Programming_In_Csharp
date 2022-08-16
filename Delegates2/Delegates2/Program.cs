using System;

namespace Delegates2
{
    class Program
    {
        static void Main(string[] args)
        {
            Card card = new Card();
            card.ChangeName += new ChangeNameDelegate(WhenChangingName);
            card.ChangeName += new ChangeNameDelegate(WhenChangingName2);
            card.Name = "Michael Card";
            card.Name = "Another Michael Card";

            Console.WriteLine(card.Name);
        }

        private static void WhenChangingName(string existsName, string newName)
        {
            Console.WriteLine($"Change name from {existsName} to {newName}.");
        }
        private static void WhenChangingName2(string existsName, string newName)
        {
            Console.WriteLine("************************************");
        }

    }
}
