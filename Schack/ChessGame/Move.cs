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
        StartClass listInStart = new StartClass();
        Random random = new Random();
        public MovePosition(GameBoard gameBoard)
        {
            // TODO: Complete member initialization
            this.gameBoard = gameBoard;
        }
        public void MovePiece(Piece randomPiece)
        {
            while (randomPiece.position.X >= 0 || randomPiece.position.X <= 7)
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
        }
        public void RandomizeMove(List<Piece> pawnList)
        {
            bool flag = true;
            while (flag == true)
            {
                flag = false;
                int ran = random.Next((pawnList.Count));
                var randomPiece = pawnList.ElementAt(ran);

                if (randomPiece.position.X < 0 || randomPiece.position.X > 7 ||
                    randomPiece.position.Y < 0 || randomPiece.position.Y > 7)
                {
                    if (randomPiece.pieceColour == colour.white)
                    {
                        Console.WriteLine("Din vita pjäs är snart utanför brädet, flytta en annan");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Din svarta pjäs är snart utanför brädet, flytta en annan");
                        Console.ReadKey();
                    }
                    flag = true;
                }
              
                    Console.WriteLine(randomPiece);
                    if (flag == false)
                    {
                        MovePiece(randomPiece);
                    }
                
            }
        }
        //public List<Piece> ListTest(List<Piece> blackPieces, List<Piece> whitePieces)
        //{
        //    List<Piece> BlockPosition = new List<Piece>();
        //    foreach (var black in blackPieces)
        //    {

        //    }

        //    return BlockPosition;
        //}


    }

}

//random on which pawn the player wants to move
//then go in the loop, which will have a lot of
//if/else. then go outside the loop when the piece
//have moved



