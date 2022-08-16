using System;

namespace Inheritance
{
    public class BetterCard : Card
    {
        public StatisticCard AllStatistics()
        {
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
