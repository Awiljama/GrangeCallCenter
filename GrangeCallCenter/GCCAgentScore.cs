using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrangeCallCenter
{
    public class GCCAgentScore
    {
        // TODO: - add calculation method for weighted score
        public GCCAHT AHTScore { get; }
        public GCCQualityControl QualityControlScore { get; }
        public GCCKnowledgeCheck KnowledgeCheckScore { get; }
        public GCCAdherence AdherenceScore { get; }
    }
}
