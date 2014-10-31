using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    public class GameBoard
    {
        public Piece[,] board = new Piece[8, 8];                    // creating the array of the GameBoard at 8*8 
        
        
        public void UpdatePosition(Piece piece, Position pos)                 // UpdatePosition-method, gets the piece and sets the new position X & Y
        {
            board[piece.position.X, piece.position.Y] = null;
            piece.position.X = pos.X;
            piece.position.Y = pos.Y;
            board[pos.X, pos.Y] = piece;
            //board[piece.position.X, piece.position.Y] = piece;
           
        }
        public void PrintGameBoard()                  // PrintGameBoard-method, prints out the GameBoard and sets out the 
        {                                                          // pieces on its startPositions

            for (int x = 0; x < 8; x++)
            {
                Console.WriteLine();
                for (int y = 0; y < 8; y++)
                {
                    if (board[x, y] == null)
                    {

                        Console.Write("[ ]");
                    }
                    else if (board[x, y].pieceValue == 5 && board[x, y].pieceColour == colour.white)
                    {
                        Console.Write("[");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("B");
                        Console.ResetColor();
                        Console.Write("]");
                    }
                    else if (board[x, y].pieceValue == 5 && board[x, y].pieceColour == colour.black)
                    {
                        Console.Write("[");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("B");
                        Console.ResetColor();
                        Console.Write("]");
                    }
                    else
                    {
                        Console.Write("FEL: " + board[x, y].pieceValue);
                    }
                }

                Console.WriteLine();
            }
            //Position piecePossition = new Position();
            //for (int x = 0; x < 8; x++)
            //{
            //    Console.WriteLine();
            //    for (int y = 0; y < 8; y++)
            //    {
            //        if (board[piece.position.X, piece.position.Y] == null)
            //        {
            //            Console.Write("[ ]");
            //        }
            //        else if (board[piece.position.X, piece.position.Y].pieceValue == 5 && board[piece.position.X, piece.position.Y].pieceColour == colour.white)
            //        {
            //            Console.Write("[");
            //            Console.ForegroundColor = ConsoleColor.Blue;
            //            Console.Write("B");
            //            Console.ResetColor();
            //            Console.Write("]");
            //        }
            //        else if (board[piecePossition.X, piecePossition.Y].pieceValue == 5 && board[piecePossition.X, piecePossition.Y].pieceColour == colour.black)
            //        {
            //            Console.Write("[");
            //            Console.ForegroundColor = ConsoleColor.DarkGreen;
            //            Console.Write("B");
            //            Console.ResetColor();
            //            Console.Write("]");
            //        }
            //        else
            //        {
            //            Console.Write("FEL: " + board[x, y].pieceValue);
            //        }
            //    }

            //    Console.WriteLine();
            //}



        }
    }
}
