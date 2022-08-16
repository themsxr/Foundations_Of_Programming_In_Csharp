using System;

namespace Try_Catch
{
    class Program
    {
        static void Main(string[] args)
        {
            label:
            try
            {
                Console.WriteLine($"Your name is: {UserName()}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                goto label;
            }
            /*catch (Exception)
            {
                Console.WriteLine("General error.");
            }*/

            Console.WriteLine("Works!");
        }

        private static string UserName()
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name can't be empty.");
            }

            return name;
        }
    }
}
