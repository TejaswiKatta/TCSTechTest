using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCSTechTest
{
    class Player
    {
        public string Selection(string[] Moves)
        {

            while (true)
            {
                Console.WriteLine("Enter a valid move(1.Rock 2.Paper 3.Scissors):");
                int PlayerMove = Convert.ToInt32(Console.ReadLine());

                if (PlayerMove > 0 && PlayerMove <= 3)
                {
                    return Moves[PlayerMove - 1];
                }
                else
                    Console.WriteLine("Invalid Move \n");
            }

        }

    }

}
