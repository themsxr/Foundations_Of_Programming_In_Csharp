using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Card card = new Card();
            Card card2 = new Card();
            //Card usercard = new Card();

            //using static
            Console.WriteLine("Min opinion: " + Card.MinOpinion);
            Console.WriteLine("Max opinion: " + Card.MaxOpinion);

            card.AddOpinion(2);
            card.AddOpinion(3.5f);
            card.AddOpinion(8);
            card.AddOpinion(2.5f);
            card.AddOpinion(3);
            card.AddOpinion(5.3f);

            card2.AddOpinion(3);
            card2.AddOpinion(6.5f);
            card2.AddOpinion(1);
            card2.AddOpinion(6.5f);
            card2.AddOpinion(9);
            card2.AddOpinion(8.3f);

            //float average = card.OpinionAverage();
            //float highestopinion = card.HighestOpinion();
            //float lowestopinion = card.LowestOpinion();

            //for (; ; )
            //{
            //    Console.WriteLine("Insert opinion from 1 to 10 (11 If you want to stop)");
            //    float useropinion;
            //    bool checknum = float.TryParse(Console.ReadLine(), out useropinion);

            //    if (checknum)
            //    {
            //        if (useropinion == 11)
            //        {
            //            break;
            //        }

            //        if (useropinion >= 1 && useropinion <= 10)
            //        {
            //            usercard.AddOpinion(useropinion);
            //        }
            //        else
            //        {
            //            Console.WriteLine("The number was out of range.");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("It's not a number!");
            //    }
            //}

            //Console.WriteLine("User opinions average: " + usercard.OpinionAverage() + "\n" + "User highest opinon: " + usercard.HighestOpinion() + "\n" + "User lowest opinion: " + usercard.LowestOpinion());
            //Console.WriteLine("-----------------");

            StatisticCard statistics = card.AllStatistics();

            Console.WriteLine("Average: " + statistics.OpinionsAverage);
            Console.WriteLine("Highest opinion: " + statistics.HighestOpinion);
            Console.WriteLine("Lowest opinion: " + statistics.LowestOpinion);
            Console.WriteLine("-----------------------");

            statistics = card2.AllStatistics();

            Console.WriteLine("Average: " + statistics.OpinionsAverage);
            Console.WriteLine("Highest opinion: " + statistics.HighestOpinion);
            Console.WriteLine("Lowest opinion: " + statistics.LowestOpinion);
            Console.WriteLine("----------------------");

            Console.WriteLine("Used: " + Card.UseCounter + " Times");

            Console.ReadKey();

        }
    }
}
