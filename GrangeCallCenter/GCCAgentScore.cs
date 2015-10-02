using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrangeCallCenter
{
    public class GCCAgentScore
    {
        public GCCAHT AHTScore { get; private set; }
        public GCCQualityControl QualityControlScore { get; private set; }
        public GCCKnowledgeCheck KnowledgeCheckScore { get; private set; }
        public GCCAdherence AdherenceScore { get; private set; }
    }
}
