using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpikeBowl.Engine
{
    public class SkillSettings
    {
        public int usesPerTurn { get; set; }
        public int usesRemaining { get; set; }
        public bool limitedUse { get; set; }
        public bool autoUse { get; set; }
        public bool mandatory { get; set; }
    }
}
