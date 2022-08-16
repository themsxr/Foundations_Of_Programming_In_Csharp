using System;
using System.Collections.Generic;
using System.Linq;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Card card = new Card();
            card.AddOpinion(4.9f);
            card.AddOpinion(2);
            card.AddOpinion(6.1f);
            card.AddOpinion(4);
            card.AddOpinion(3.5f);
            card.AddOpinion(9);
            card.AddOpinion(8.2f);

            StatisticCard cardstats = card.AllStatistics();

            CardResults("Opinions average", cardstats.OpinionsAverage);
            CardResults("Highest opinion", (int)cardstats.HighestOpinion);
            CardResults("Lowest opinion", (long)cardstats.LowestOpinion);

            CardResults("Params", 5, 8, 5, 2, 4, 0, 1);
        }

        private static void CardResults(string description, float result)
        {
            Console.WriteLine(description + " = " + result);
        }

        private static void CardResults(string description, int result)
        {
            Console.WriteLine(description + " = " + result);
        }

        private static void CardResults(string description, long result)
        {
            Console.WriteLine(description + " = " + result);
        }

        private static void CardResults(string description, params float[] result)
        {
            string numbers = null;

            foreach (var n in result)
            {
                numbers += " " + n; 
            }
            Console.WriteLine(description + " = " + numbers);
        }
    }
}
