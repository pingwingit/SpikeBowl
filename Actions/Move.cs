using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpikeBowl.Engine.Interfaces;

namespace SpikeBowl.Engine.Actions
{
    public class Move : IAction
    {
        public ActionResults actionResult { get; set; }

        Player player;
        Point destination;
        Engine engine;

        public Move(Player player, Point destination, Engine engine)
        {
            this.player = player;
            this.destination = destination;
            this.engine = engine;
        }

        public ActionResults TryAction()
        {
            var opponentsWithTackleZoneOnPlayer = engine.GetOpposingPlayersWithTackleZoneOnPoint(player.boardPosition, player.side);
            var opponentsWithTackleZoneOnDestination = engine.GetOpposingPlayersWithTackleZoneOnPoint(destination, player.side);

            ActionResults result;

            if (player.movesRemaining == 0)
            {
                //TODO - move all this into it's ownmethod that includes reroll check
                //using a GFI
                int dr = engine.diceManager.RollDice(RollTypes.D6).total;

                //TODO - check for weather
                int target = 2;
                if (dr < target)
                {
                    //GFI failed
                    //TODO - call method to knock down player, including armour/injury rolls
                    player.boardPosition = destination;
                    player.status = PlayerStatus.KNOCKED_DOWN;
                    result = ActionResults.TURNOVER;
                    return result;
                }
            }

            if (opponentsWithTackleZoneOnPlayer.Count == 0)
            {   
                //no tackle zones on player so move automatically succeeds
                player.boardPosition = destination;
                

                if (player.movesRemaining > 0)
                    player.movesRemaining--;
                else
                    player.GFIsRemaining--;

                if (player.movesRemaining + player.GFIsRemaining == 0)
                    result = ActionResults.OK_STOP;
                else
                    result = ActionResults.OK_CONTINUE;
            }
            else
            {
                //tackle zone on player so must make dodge roll
                int target = GameManager.engine.GetAGRollTarget(player.AG);

                int modifier = 1;   //dodge has +1 modifier to base AG roll
                modifier -= opponentsWithTackleZoneOnDestination.Count; //-1 modifier for every opposing tackle zone on destination square


                throw new NotImplementedException("need to implement dodging");
                result = ActionResults.TURNOVER;
            }

            actionResult = result;
            return result;            
        }

        public bool ValidateAction()
        {
            throw new NotImplementedException();
        }
    }
}
