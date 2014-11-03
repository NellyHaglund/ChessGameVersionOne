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
            //if (position.X >= 0 && position.X <= 7 && position.Y >= 0 && position.Y <= 7)
            //{
            //    MoveOk = true;
            //}
            //else
            //{
            //    Console.WriteLine("U suck!!");
            //    Console.ReadKey();
            //}
            while (randomPiece.position.X >= 0 && randomPiece.position.X <= 7 && randomPiece.position.Y >= 0 && randomPiece.position.Y <= 7)
            {


                if (randomPiece.pieceColour == colour.white)
                {
                    gameBoard.UpdatePosition(randomPiece, new Position(randomPiece.position.X + 1, randomPiece.position.Y));
                    break;
                }
                else
                {
                    gameBoard.UpdatePosition(randomPiece, new Position(randomPiece.position.X - 1, randomPiece.position.Y));
                    break;
                }
            }
         
            

           // gameBoard.board[4, 3] = new Pawn(new Position(4, 3), colour.black);

        }
        Random random = new Random();
            
        public void RandomizeMove(List<Piece> pawnList)
        {   
                int ran = random.Next((pawnList.Count));
                var randomPiece = pawnList.ElementAt(ran);
                MovePawn(randomPiece);

                Console.WriteLine(randomPiece);
        }    
    
        //random on which pawn the player wants to move
        //then go in the loop, which will have a lot of
        //if/else. then go outside the loop when the piece
        //have moved

    }
}
