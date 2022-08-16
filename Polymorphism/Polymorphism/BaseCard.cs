using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public abstract class BaseCard
    {
        public abstract void AddOpinion(float opinion);
        public abstract StatisticCard AllStatistics();
    }
}
