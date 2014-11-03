using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    public class MovePosition
    {
        Position position = new Position();
        GameBoard gameBoard;
        bool MoveOk;

        public MovePosition(GameBoard gameBoard)
        {
            // TODO: Complete member initialization
            this.gameBoard = gameBoard;
        }

        public void MovePawn(Piece randomPiece)
        {
            if (position.X >= 0 && position.X <= 7 && position.Y >= 0 && position.Y <= 7)
            {
                MoveOk = true;
            }
            else
            {
                Console.WriteLine("U suck!!");
                Console.ReadKey();
            }
<<<<<<< HEAD

                if (randomPiece.pieceColour == colour.white && MoveOk == true)
                {
                    gameBoard.UpdatePosition(randomPiece, new Position(randomPiece.position.X + 1, randomPiece.position.Y));

                }
                else
                {
                    gameBoard.UpdatePosition(randomPiece, new Position(randomPiece.position.X - 1, randomPiece.position.Y));

                }
            
=======
           // gameBoard.board[4, 3] = new Pawn(new Position(4, 3), colour.black);
>>>>>>> parent of 2df0a30... Svarta och vita bönder rör sig själva. 1 steg var
        }
        Random random = new Random();
            
        public void RandomizeMove(List<Piece> whitePawnList)
        {
          while (MoveOk == false)
            {
                int ran = random.Next((pawnList.Count));

                var randomPiece = pawnList.ElementAt(ran);
                MovePawn(randomPiece);
               
           }
            
<<<<<<< HEAD
=======
            var randomPiece = whitePawnList.ElementAt(ran);
            MovePawn(randomPiece);
>>>>>>> parent of 2df0a30... Svarta och vita bönder rör sig själva. 1 steg var
        }
       








        //random on which pawn the player wants to move
        //then go in the loop, which will have a lot of
        //if/else. then go outside the loop when the piece
        //have moved

    }
}
