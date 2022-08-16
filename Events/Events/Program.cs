using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Card card = new Card();
            card.ChangeName += WhenChangingName;
            card.ChangeName += WhenChangingName2;
            card.Name = "Michael Card";
            card.Name = "Another Michael Card";

            Console.WriteLine(card.Name);
        }

        private static void WhenChangingName(object sender, ChangeNameEventArgs args)
        {
            Console.WriteLine($"Change name from {args.ExistsName} to {args.NewName}.");
        }
        private static void WhenChangingName2(object sender, ChangeNameEventArgs args)
        {
            Console.WriteLine("************************************");
        }
    }
}
