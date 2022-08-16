using System;

namespace Interfaces
{
    public class BetterCard : Card
    {
        public override StatisticCard AllStatistics()
        {
            Console.WriteLine("BetterCard::AllStatistics");
            float lowest = float.MaxValue;

            foreach (var opinion in opinions)
            {
                lowest = Math.Min(opinion, lowest);
            }

            opinions.Remove(lowest);

            return base.AllStatistics();
        }
    }
}
