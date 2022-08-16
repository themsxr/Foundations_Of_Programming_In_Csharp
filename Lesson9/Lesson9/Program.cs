using System;
using System.Collections.Generic;

namespace Lesson9
{
    class Program
    {
        static void Main(string[] args)
        {
            // collections - List

            List<long> ourList = new List<long>(); // We create our list with long type
            // List has no size of elements

            ourList.Add(100);
            ourList.Add(200);// Adding number to our list, every new added element with "Add" will be added to the end of the list as new
            ourList[0] = 5; // Same as with array collection we can add with index number, but using this we change index 0 to 5, in this example we change 100 to 5
            ourList.Insert(0, 300); // Usign "Insert" will add a new element to the specified index we give and it will move the old value from index 0 higher , in this example: Insert(0, 300) <--- 0 mean Index 0 and 300 is our element and old element from index 0 "5" will be moved to index 1, element from index 1 to 2 etc etc.

            foreach (var item in ourList)
            {
                Console.WriteLine("Old numbers: " + item);
            }

            ourList.RemoveAt(1); // "RemoveAt" will remove element from specify index, in this example Index 5 -> number 5
            ourList.RemoveAll(x => x > 200); // "RemoveAll" in this example will remove every number higher than 200
            Console.WriteLine("-----------------------------------");

            foreach (var item in ourList)
            {
                Console.WriteLine("New numbers: " + item);
            }
        }
    }
}
