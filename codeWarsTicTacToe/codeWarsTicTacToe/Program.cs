using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsTicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class TicTacToe
    {
        public int IsSolved(int[,] board)
        {
            //if (board.Length != 9)
            //    return -1;

            //foreach (var item in board)
            //{
            //    if (item == 0)
            //        return -1;
            //}

            if (board[0, 0] == board[0, 1] && board[0, 1] == board[0, 2])
                return board[0, 0];
            else if (board[1, 0] == board[1, 1] && board[1, 1] == board[1, 2])
                return board[1, 0];
            else if (board[2, 0] == board[2, 1] && board[2, 1] == board[2, 2])
                return board[2, 0];
            else if (board[0, 0] == board[1, 0] && board[1, 0] == board[2, 0])
                return board[0, 0];
            else if (board[1, 0] == board[1, 1] && board[1, 1] == board[1, 2])
                return board[1, 0];
            else if (board[2, 0] == board[2, 1] && board[2, 1] == board[2, 2])
                return board[2, 0];
            else if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
                return board[0, 0];
            else if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
                return board[0, 2];
            else
                return 0;
        }
    }
}
