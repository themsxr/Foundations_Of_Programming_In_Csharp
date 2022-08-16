using System;

namespace Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            // collections 

            int[] collection1 = new int[10]; // We did collection with size of 10 elements
            int[] collection2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; // We did collection with size of 10 elemetns
            int[] collection3 = new int[5];

            // in every collection we start from 0 not from 1 and end with -1 collection size in this example it's 9
            collection1[0] = 1;
            collection1[1] = 2;
            collection1[2] = 3;
            collection1[3] = 4;
            collection1[4] = 5;
            collection1[5] = 6;
            collection1[6] = 7;
            collection1[7] = 8;
            collection1[8] = 9;
            collection1[9] = 10;

            foreach (var element in collection1)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("-----------------------------");

            for (int i = 0; i < collection2.Length; i++)
            {
                Console.WriteLine(collection2[i]);
                // It's better to use foreach than for loop for collection because you can easy get error, for example: You change i < collection2.Length to i <= collection2.Length and you can't display index 10 from collection2 because it doesn't exists!
            }
            Console.WriteLine("-----------------------------");

            // We put element in this 5 size collection

            for (int i = 0; i < collection3.Length; i++)
            {
                collection3[i] = 2 * (i * 5);
            }

            foreach (var item in collection3)
            {
                Console.WriteLine(item);
            }
        }
    }
}
