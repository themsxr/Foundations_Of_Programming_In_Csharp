using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IBaseCard card = CreateCard();

            card.AddOpinion(9);
            card.AddOpinion(5);
            card.AddOpinion(4);
            card.AddOpinion(2);
            card.AddOpinion(8);
            card.AddOpinion(6);
            card.AddOpinion(8);

            StatisticCard stats = card.AllStatistics();

            Console.WriteLine($"Average: {stats.OpinionsAverage}\nHighest opinion: {stats.HighestOpinion}\nLowest opinion: {stats.LowestOpinion}");

            // Polymorphism & Abstract classes
        }

        private static IBaseCard CreateCard()
        {
            //return new Card();
            return new BetterCard();
        }
    }
}
