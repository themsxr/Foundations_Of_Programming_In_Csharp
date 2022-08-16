using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Throw
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("What's your age? : ");
            bool check = int.TryParse(Console.ReadLine(), out age);

            if (!check)
            {
                throw new ArgumentException("Incorrect age number!");
            }

            Console.WriteLine("Tell me your name: ");
            string name = Console.ReadLine();
            addName(name);
        }

        private static void addName(string name)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Name can't be empty.");
            }
        }
    }
}
