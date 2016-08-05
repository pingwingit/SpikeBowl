using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpikeBowl.Engine
{
    public class Player
    {
        public int ST { get; set; }
        public int AG { get; set; }
        public int MV { get; set; }
        public int AV { get; set; }

        public int level { get; set; }
        public int SPP { get; set; }

        public int GFIs { get; set; }

        public string name { get; set; }
        public int number { get; set; }

        public Point boardPosition { get; set; }

        public bool isMNG { get; set; }

        public Locations location { get; set; }

        public bool hasBall { get; set; }

        public bool stunnedThisTurn { get; set; }

        public Side side { get; set; }

        public int movesRemaining { get; set; }
        public int GFIsRemaining { get; set; }

        public PlayerStatus status { get; set; }

        public bool isReallyStupid { get; set; }
        public bool isBoneHeaded { get; set; }
        
        public Team team { get; set; }

        public Dictionary<Skills,SkillSettings> skills { get; set; }

        public bool hasTackleZone
        {            
            get
            {
                if (status == PlayerStatus.STANDING && !isBoneHeaded && !isReallyStupid)
                    return true;
                else
                    return false;
            }            
        }

        //TODO - make these return some sort of AmourBreakOrInjuryResult object
        private void BreakArmour()
        {

        }

        private void Injure()
        {

        }

        public bool IsUsingSkill(Skills s)
        {
            bool result = false;

            if ( skills.ContainsKey(s) )
            {
                SkillSettings ss = skills[s];
                if ( ss.limitedUse && ss.usesRemaining == 0)
                {
                    //already used skill
                    result = false;
                }
                else if (ss.autoUse || ss.mandatory)
                {
                    if (ss.limitedUse)
                        ss.usesRemaining--;

                    result = true;
                }
                else
                    result = false;//TODO - ask if skill should be used
            }

            return result;
        }

        public Player()
        {

        }
    }
}
