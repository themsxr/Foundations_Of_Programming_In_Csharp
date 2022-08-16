using System;
using System.Collections.Generic;
using System.Linq;

namespace Events
{
    class Card
    {
        public Card()
        {
            opinions = new List<float>();
            UseCounter++;
        }

        private List<float> opinions;
        public static float MinOpinion = 1;
        public static float MaxOpinion = 10;
        public static long UseCounter = 0;
        private string _name;

        /// <summary>
        /// Adding opinion to opinions
        /// </summary>
        /// <param name="opinion">New opinion</param>
        public void AddOpinion(float opinion)
        {
            if (opinion >= 1 && opinion <= 10)
            {
                opinions.Add(opinion);
            }
            else
            {
                Console.WriteLine("Opionion need to be between 1 and 10");
            }
        }

        /// <summary>
        /// Calculating the average of the opinions
        /// </summary>
        /// <returns>average of the opinions</returns>
        //public float OpinionAverage()
        //{
        //    return opinions.Average();
        //}

        /// <summary>
        /// Gives us the highest opinion from opinions
        /// </summary>
        /// <returns>the highest opinion</returns>
        //public float HighestOpinion()
        //{
        //    return opinions.Max();
        //}

        /// <summary>
        /// Gives us the lowest opinion from opinions
        /// </summary>
        /// <returns>the lowest opinion</returns>
        //public float LowestOpinion()
        //{
        //    return opinions.Min();
        //}

        internal StatisticCard AllStatistics()
        {
            StatisticCard stats = new StatisticCard();

            stats.OpinionsAverage = opinions.Average();
            stats.HighestOpinion = opinions.Max();
            stats.LowestOpinion = opinions.Min();

            return stats;
        }

        public string Name
        {
            get { return _name.ToUpper(); }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    if (_name != value)
                    {
                        ChangeNameEventArgs args = new ChangeNameEventArgs();
                        args.ExistsName = _name;
                        args.NewName = value;

                        ChangeName(this, args);
                    }

                    _name = value;
                }
            }
        }

        // Event
        public event ChangeNameDelegate ChangeName;
    }
}
