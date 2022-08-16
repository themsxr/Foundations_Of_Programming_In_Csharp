using System;

namespace Polymorphism
{
    public class BetterCard : Card
    {
        public override StatisticCard AllStatistics()
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
