using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    class Move
    {
        GameBoard gameBoard = new GameBoard();

        public void MovePawn()
        {
            

            gameBoard.board[4, 3] = new Pawn(new Position(4, 3), colour.black);
        }
        Random random = new Random();

        public void RandomizeMove()
        {
            int x = random.Next((8));
            int y = random.Next((8));
            gameBoard.board[x, y] = null;
        }
       








        //random on which pawn the player wants to move
        //then go in the loop, which will have a lot of
        //if/else. then g outside the loop when the piece
        //have moved
    }
}
