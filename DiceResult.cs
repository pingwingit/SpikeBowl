using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpikeBowl.Engine
{
    class DiceResult
    {
        int total;
        List<int> individualResults;
        bool isDouble;
        RollTypes rollType;

        public DiceResult(List<int> individualResults, RollTypes rollType)
        {
            this.rollType = rollType;
            this.individualResults = individualResults;
            total = individualResults.Sum();

            if (rollType == RollTypes._2D6)
            {
                //doubles are significant for level up rolls and fouls
                if (individualResults[0] == individualResults[1])
                    isDouble = true;
                else
                    isDouble = false;
            }
            else
                isDouble = false;
        }
    }
}
