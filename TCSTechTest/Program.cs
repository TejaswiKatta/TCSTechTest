using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCSTechTest
{ 
    public class Program
    {
        public enum result{Tie,Computer,Player};

        public static void Main(string[] args)
        {

            Program program = new Program();
            program.DeclareWinner();

        }

        public void DeclareWinner()
        {
            #region VariableDeclarations
            string[] Moves = new string[3] { "Rock", "Paper", "Scissors" };

            Player player = new Player();
            Computer computer = new Computer();
            Program.result result;
            int computerCount = 0, playerCount = 0;
            #endregion

            for (int i = 1; i <= 3; i++)
            {
                string PlayerMove = player.Selection(Moves);
                string ComputerMove = computer.Selection(Moves);
                result = DecideWinner(PlayerMove, ComputerMove);
                if (result == result.Computer)
                {
                    computerCount++;
                    Console.WriteLine("In Round {0} : Computer Won", i);
                }
                else if (result == result.Player)
                {
                    playerCount++;
                    Console.WriteLine("In Round {0} : Player Won", i);
                }
                else
                {
                    Console.WriteLine("In Round {0} :It is a tie!!", i);
                }
            }
            Console.WriteLine("*******************************************");
            if (playerCount > computerCount)
            {
                Console.WriteLine("Final Result-Player won!!");
            }

            if (playerCount < computerCount)
            {
                Console.WriteLine("Final Result-Computer won!!");
            }

            if (playerCount == computerCount)
            {
                Console.WriteLine("Oops!! It's a tie");
            }

        }

        public result DecideWinner(string PlayerMove, string ComputerMove)
        {
            if (PlayerMove == "Rock")
            {
                if (ComputerMove == "Paper")
                {
                    return result.Computer;
                }
                else if (ComputerMove == "Scissors")
                {
                    return result.Player;
                }
            }
            else if (PlayerMove == "Paper")
            {
                if (ComputerMove == "Rock")
                {
                    return result.Player;
                }
                else if (ComputerMove == "Scissors")
                {
                    return result.Computer;
                }
            }
            else if (PlayerMove == "Scissors")
            {
                if (ComputerMove == "Paper")
                {
                    return result.Player;
                }
                else if (ComputerMove == "Rock")
                {
                    return result.Computer;
                }
            }
            return result.Tie;
        }

    }


}
