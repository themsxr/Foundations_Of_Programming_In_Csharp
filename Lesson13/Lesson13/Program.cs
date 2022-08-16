using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson13
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1;
            book1.Author = "Adam Green";
            book1.Name = "Yellow and Red";
            book1.Id = 1;

            Console.WriteLine("Book name: " + book1.Name + "\nBook Author: " + book1.Author + "\nBook ID: " + book1.Id);

            DateTime data = new DateTime(2022, 8, 4);
            // adding 2 days
            // data = data.AddDays(2);

            string testname = "      Our Test      ";
            Console.WriteLine("\n------------------\n" + testname + "\n------------------\n");
            // cutting spaces from the beginning of the first word and the end of the last
            testname = testname.Trim();

            Console.WriteLine(testname + "\n" + data);

        }
    }
}
