﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpikeBowl.Engine.Interfaces;

namespace SpikeBowl.Engine
{
    public class Engine
    {
        public Queue<IAction> actionQueue { get; set; }

        public IDiceManager diceManager { get; set; }

        //engine shouldn't need to know about clients
        //public IClient homeClient { get; set; }
        //public IClient awayClient { get; set; }

        public Team homeTeam { get; set; }
        public Team awayTeam { get; set; }

        public Ball ball { get; set; }

        public Engine()
        {
            actionQueue = new Queue<IAction>();
        }

        public bool RequestReroll(Team activeTeam, RerollRequestMessages message, string moreInfo)
        {
            //check to see if there are any team/leader rerolls available
            //check for Pro reroll

            //TODO - send message to controller and wait for answer

            //attempt pro/loner rolls if necessary
            //reroll...
            return true;
        }

        public ActionResults ProcessActionQueue()
        {
            ActionResults result = ActionResults.OK_CONTINUE;

            while ( result == ActionResults.OK_CONTINUE && actionQueue.Count > 0 )
            {
                IAction action = actionQueue.Dequeue();
                result = action.TryAction();
            }

            return result;
        }

        public List<Player> GetOpposingPlayersWithTackleZoneOnPoint(Point p, Side side)
        {
            List<Player> opposingPlayers;

            if ( side == Side.HOME)
            {
                opposingPlayers = awayTeam.players;
            }
            else
            {
                opposingPlayers = homeTeam.players;
            }
            
            var resultPlayers = opposingPlayers.Where(player => player.boardPosition.GetSquaredDistance(p) <= 2 && player.hasTackleZone);
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
                p.GFIsRemaining = p.GFIs;
                p.stunnedThisTurn = false;
            }

        }
    }
}
