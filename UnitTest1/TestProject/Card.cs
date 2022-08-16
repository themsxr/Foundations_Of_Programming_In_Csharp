using System;
using System.Collections.Generic;
using System.Linq;

namespace TestProject
{
    public class Card // we need to make class public to use this in our Unit Test
    {
        List<float> opinions = new List<float>();
        public string Test;

        /// <summary>
        /// Adding opinion to opinions
        /// </summary>
        /// <param name="opinion">New opinion</param>
        public void AddOpinion(float opinion)
        {
            opinions.Add(opinion);
        }

        /// <summary>
        /// Calculating the average of the opinions
        /// </summary>
        /// <returns>average of the opinions</returns>
        public float OpinionAverage()
        {
            return opinions.Average();
        }

        /// <summary>
        /// Gives us the highest opinion from opinions
        /// </summary>
        /// <returns>the highest opinion</returns>
        public float HighestOpinion()
        {
            return opinions.Max();
        }

        /// <summary>
        /// Gives us the lowest opinion from opinions
        /// </summary>
        /// <returns>the lowest opinion</returns>
        public float LowestOpinion()
        {
            return opinions.Min();
        }
    }
}
