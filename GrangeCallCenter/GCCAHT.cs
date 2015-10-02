using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrangeCallCenter
{
    public class GCCAHT
    {
        // property AHTScore will be persisted
        public double AHTScore { get; } // TODO: - add calculation in accessor's get method
        // property AHTTimeInSeconds will be persisted
        public double AHTTimeInSeconds { get; private set; }
        // constant, not persisted
        private const double AHT_WEIGHT = 0.30;
        // computed property, not persisted
        public double AHTWeightedScore { get { return AHTScore * AHT_WEIGHT; } }
    }
}
