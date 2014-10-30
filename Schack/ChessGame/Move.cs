using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    class Move
    {

        public void MovePawn()
        {
            GameBoard gameBoard = new GameBoard();

            gameBoard.board[4, 3] = new Pawn(new Position(4, 3), colour.black);
        }
    }
}
