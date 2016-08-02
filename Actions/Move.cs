using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpikeBowl.Engine.Interfaces;

namespace SpikeBowl.Engine.Actions
{
    class Move : SBAction
    {
        Player player;
        Point destination;

        public Move(Player player, Point destination)
        {
            this.player = player;
            this.destination = destination;
        }

        public ActionResults TryAction()
        {
            var opponentsWithTackleZoneOnPlayer = GameManager.engine.GetOpposingPlayersWithTackleZoneOnPoint(player.boardPosition, player.side);
            var opponentsWithTackleZoneOnDestination = GameManager.engine.GetOpposingPlayersWithTackleZoneOnPoint(destination, player.side);

            ActionResults result;

            if (opponentsWithTackleZoneOnPlayer.Count == 0)
            {
                //no tackle zones on player so move automatically succeeds
                player.movesRemaining--;
                if (player.movesRemaining == 0)
                    result = ActionResults.OK_STOP;
                else
                    result = ActionResults.OK_CONTINUE;
            }
            else
            {
                //tackle zone on player so must make dodge roll



                throw new NotImplementedException("need to implement dodging");
                result = ActionResults.TURNOVER;
            }

            return result;            
        }

        public bool ValidateAction()
        {
            throw new NotImplementedException();
        }
    }
}
