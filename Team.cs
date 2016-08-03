using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpikeBowl.Engine
{
    public class Team
    {
        public int BlitzRemaining { get; set; }
        public int FoulsRemaining { get; set; }
        public int PassesRemaining { get; set; }
        public int HandOffsRemaining { get; set; }
        public int RerollsRemaining { get; set; }

        public int RerollsRemainingThisHalf { get; set; }

        public List<Player> players { get; set; }
    }
}
