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
    }
}
