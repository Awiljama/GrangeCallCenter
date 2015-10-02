using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrangeCallCenter
{
    public class GCCAgent
    {
        // property AgentNumber will be persisted
        public string AgentNumber { get; private set; }
        // property HireDate will be persisted
        public DateTime HireDate { get; private set; }
        // computed property, will not be persisted
        public TimeSpan Tenure { get { return DateTime.Today - HireDate; } }
        // reference to other class, not persisted
        public GCCAgentScore AgentScore { get; }
    }
}
