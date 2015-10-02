using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrangeCallCenter
{
    public class GCCAdherence
    {
        // computed property, not persisted
        public double AdherenceScore { get { return (MinutesInAdherence / ScheduledTimeInSeconds) * 60; } }
        // property MinutesInAdherence will be persisted
        public int MinutesInAdherence { get; }
        // property ScheduledTimeInSeconds will be persisted
        public int ScheduledTimeInSeconds { get; }
    }
}
