using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpikeBowl.Engine
{
    public class Engine
    {
        public Team homeTeam { get; set; }
        public Team awayTeam { get; set; }

        public Ball ball { get; set; }

        public List<Player> GetOpposingPlayersWithTackleZoneOnPoint(Point p, Side side)
        {
            List<Player> opposingPlayers;

            if ( side == Side.HOME)
            {
                opposingPlayers = awayTeam.players;
            }
            {
                opposingPlayers = homeTeam.players;
            }

            var resultPlayers = opposingPlayers.Where(player => player.boardPosition.GetSquaredDistance(p) <= 2);
            return resultPlayers.ToList();
        }
        
        public int GetAGRollTarget(int AG)
        {
            int target = 7 - AG;
            if (target < 2)
                target = 2;
            return target;
        }

        public void InitialiseTurn(Team activeTeam)
        {
            //set counts for number of blitzs, passes etc. allowed this turn
            activeTeam.BlitzRemaining = 1;
            activeTeam.PassesRemaining = 1;
            activeTeam.HandOffsRemaining = 1;
            activeTeam.FoulsRemaining = 1;

            if ( activeTeam.RerollsRemainingThisHalf > 0)
                activeTeam.RerollsRemaining = 1;
            else
                activeTeam.RerollsRemaining = 0;


            //set movement allowance on players etc.
            foreach(Player p in activeTeam.players)
            {
                p.movesRemaining = p.MV;
                p.stunnedThisTurn = false;
            }

        }
    }
}
