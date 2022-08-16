using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Card card = new BetterCard();

            card.AddOpinion(9);
            card.AddOpinion(5);
            card.AddOpinion(4);
            card.AddOpinion(2);
            card.AddOpinion(8);
            card.AddOpinion(6);
            card.AddOpinion(8);

            StatisticCard stats = card.AllStatistics();

            Console.WriteLine($"Average: {stats.OpinionsAverage}\nHighest opinion: {stats.HighestOpinion}\nLowest opinion: {stats.LowestOpinion}");
        }
    }
}
