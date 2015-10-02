using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrangeCallCenter
{
    public class GCCAHT
    {
        public double AHTScore { get; private set; }
        public double AHTTimeInSeconds { get; private set; }
        private const double AHT_WEIGHT = 0.30;
        public double AHTWeightedScore { get; private set; }
    }
}
