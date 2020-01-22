using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe2
{
    public class Player
    {
        public UInt16 score;

        public void Win()
        {
            score++;
        }

    }
}
