using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public abstract class BaseCard : IBaseCard
    {
        public abstract void AddOpinion(float opinion);
        public abstract StatisticCard AllStatistics();
    }
}
