using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCSTechTest
{
    class Computer
    {
        public string Selection(string[] Moves)
        {
            string Randomselect = Moves[new Random().Next(1, 3)];
            Console.WriteLine("Computer Move:{0}", Randomselect);
            return Randomselect;
        }

    }
}
