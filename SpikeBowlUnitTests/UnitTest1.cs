using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpikeBowl.Engine;
using SpikeBowl.Engine.Actions;

namespace SpikeBowlUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GFIFails()
        {
            Engine e = new Engine();

            e.diceManager = new LoadedDiceManager(new int[] { 1,1,1,1 });

            e.homeTeam = new Team();
            e.awayTeam = new Team();

            Player h1 = new Player();
            h1.GFIs = 2;
            h1.MV = 1;
            h1.status = PlayerStatus.STANDING;
            h1.boardPosition = new Point(2, 2);

            e.homeTeam.AddPlayer(h1);
            e.InitialiseTurn(e.homeTeam);

            e.actionQueue.Enqueue(new Move(h1, new Point(3, 2), e));
            e.actionQueue.Enqueue(new Move(h1, new Point(4, 2), e));

            ActionResults ar = e.ProcessActionQueue();

            //Assert.IsTrue(ar == ActionResults.TURNOVER);
            Assert.AreEqual(ActionResults.TURNOVER, ar);
            Assert.AreEqual(4,h1.boardPosition.x);
        }

        //CannotUseSprintTwiceInSameTurn

        
    }
}
