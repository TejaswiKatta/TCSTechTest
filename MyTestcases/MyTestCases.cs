using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCSTechTest;


namespace MyTestcases
{
    [TestFixture]
    class MyTestCases
    {
        [Test]
        public void PlayerMoveRockComputerMovePaper()
        {
            Winner  p = new Winner();
            Assert.AreEqual(Program.result.Computer, p.DecideWinner("Rock", "Paper"));
        }

        //[TestCase]
        //public void PlayerMoveRockComputerMoveScissors()
        //{
        //    Program p = new Program();
        //    Assert.AreEqual(Program.result.Player, p.DecideWinner("Rock", "Scissors"));
        //}
        //[TestCase]
        //public void PlayerMoveScissorsComputerMovePaper()
        //{
        //    Program p = new Program();
        //    Assert.AreEqual(Program.result.Player, p.DecideWinner("Scissors", "Paper"));


        //}

        //[TestCase]
        //public void PlayerMoveScissorsComputerMoveRock()
        //{
        //    Program p = new Program();
        //    Assert.AreEqual(Program.result.Computer, p.DecideWinner("Scissors", "Rock"));

        //}

        //[TestCase]
        //public void PlayerMovePaperComputerMoveRock()
        //{
        //    Program p = new Program();
        //    Assert.AreEqual(Program.result.Player, p.DecideWinner("Paper", "Rock"));
        //}
        //[TestCase]
        //public void PlayerMovePaperComputerMoveScissors()
        //{
        //    Program p = new Program();
        //    Assert.AreEqual(Program.result.Computer, p.DecideWinner("Paper", "Scissors"));
        //}

        //[TestCase]
        //public void PlayerMovePaperComputerMovePaper()
        //{
        //    Program p = new Program();
        //    Assert.AreEqual(Program.result.Tie, p.DecideWinner("Paper", "Paper"));
        //}


    }
}
