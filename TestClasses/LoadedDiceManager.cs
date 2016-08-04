using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpikeBowl.Engine
{
    public class LoadedDiceManager : IDiceManager
    {
        private Queue<int> D6Rolls;
        private Queue<int> D8Rolls;

        public LoadedDiceManager( IEnumerable<int> D6R )
        {
            D6Rolls = new Queue<int>(D6R);
        }

        public DiceResult RollDice(RollTypes rollType)
        {
            List<int> rolls = null;

            switch (rollType)
            {
                case RollTypes.D6:
                    rolls = RollD6().ToList();
                    break;
                case RollTypes._2D6:
                    break;
                case RollTypes._3D6:
                    break;
                case RollTypes.D3:
                    break;
                case RollTypes.D8:
                    break;
                case RollTypes.D16:
                    break;
                case RollTypes.D68:
                    break;
                default:
                    break;
            }

            DiceResult result = new DiceResult(rolls, rollType);
            return result;
        }

        private IEnumerable<int> RollD6()
        {
            for ( int i = 0; i < 1; i++)
            {
                yield return D6Rolls.Dequeue();
            }
        }

        private IEnumerable<int> Roll2D6()
        {
            for (int i = 0; i < 2; i++)
            {
                yield return D6Rolls.Dequeue();
            }
        }

        private IEnumerable<int> Roll3D6()
        {
            for (int i = 0; i < 3; i++)
            {
                yield return D6Rolls.Dequeue();
            }
        }
    }
}
