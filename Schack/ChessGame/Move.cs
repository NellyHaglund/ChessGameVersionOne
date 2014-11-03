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

        //MovePawn-Method that makes the pawns move 1 step
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

                if (randomPiece.pieceColour == colour.white && MoveOk == true)
                {
                    gameBoard.UpdatePosition(randomPiece, new Position(randomPiece.position.X + 1, randomPiece.position.Y));

                }
                else
                {
                    gameBoard.UpdatePosition(randomPiece, new Position(randomPiece.position.X - 1, randomPiece.position.Y));

                }
            
        }
        Random random = new Random();
        
        //RandomizeMove-Method that randomize which pawn in the
        //white/black-PawnList that moves
        public void RandomizeMove(List<Piece> pawnList)
        {
          while (MoveOk == false)
            {
                int ran = random.Next((pawnList.Count));

                var randomPiece = pawnList.ElementAt(ran);
                MovePawn(randomPiece);
               
           }
            
        }
       








        //random on which pawn the player wants to move
        //then go in the loop, which will have a lot of
        //if/else. then go outside the loop when the piece
        //have moved

    }
}
