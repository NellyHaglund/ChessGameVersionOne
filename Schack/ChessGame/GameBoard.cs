using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    public class GameBoard
    {
<<<<<<< HEAD
        // creating the array of the GameBoard at 8*8 
        public Piece[,] board = new Piece[8, 8];                    

        // UpdatePosition-method, gets the piece and sets the new position X & Y
<<<<<<< HEAD
        public void UpdatePosition(Piece piece, Position pos)
=======
        public Piece[,] board = new Piece[8, 8];                    // creating the array of the GameBoard at 8*8 
        
        
        public void UpdatePosition(Piece piece, Position pos)                 // UpdatePosition-method, gets the piece and sets the new position X & Y
>>>>>>> parent of 2df0a30... Svarta och vita bönder rör sig själva. 1 steg var
=======
        public void UpdatePosition(Piece piece, Position pos)                 
>>>>>>> origin/master
        {
            board[piece.position.X, piece.position.Y] = null;
            piece.position.X = pos.X;
            piece.position.Y = pos.Y;
            board[pos.X, pos.Y] = piece;
<<<<<<< HEAD
<<<<<<< HEAD


=======
          
           
>>>>>>> origin/master
        }
        // PrintGameBoard-method, prints out the GameBoard and sets out the
        // pieces on its startPositions
<<<<<<< HEAD
        public void PrintGameBoard()
        {
            //if (x >= 0 && x < 8 && y >= 0 && y < 8)
            //{
            //    Console.SetCursorPosition(x, y);
            //    Console.Write("[ ]");
            //}
            //for (int x = 0; x < 8; x++)
            //{
            //    Console.WriteLine();
            //    for (int y = 0; y < 8; y++)
            //    {
            //        if (board[x, y] == null)
            //        {

            //            Console.Write("[ ]");
            //        }
            //    }
            //}
        }
        //else if (board[x, y].pieceValue == 5 && board[x, y].pieceColour == colour.white)
        //{
        //    Console.Write("[");
        //    Console.ForegroundColor = ConsoleColor.Blue;
        //    Console.Write("B");
        //    Console.ResetColor();
        //    Console.Write("]");
        //}
        //else if (board[x, y].pieceValue == 5 && board[x, y].pieceColour == colour.black)
        //{
        //    Console.Write("[");
        //    Console.ForegroundColor = ConsoleColor.DarkGreen;
        //    Console.Write("B");
        //    Console.ResetColor();
        //    Console.Write("]");
        //}
        //else
        //{
        //    Console.Write("FEL: " + board[x, y].pieceValue);
        //}
=======
            //board[piece.position.X, piece.position.Y] = piece;
           
        }
        public void PrintGameBoard()                  // PrintGameBoard-method, prints out the GameBoard and sets out the 
        {                                                          // pieces on its startPositions
>>>>>>> parent of 2df0a30... Svarta och vita bönder rör sig själva. 1 steg var
=======
        public void PrintGameBoard()                  
        {                                                         
>>>>>>> origin/master

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
                //kommentar
            }
<<<<<<< HEAD
<<<<<<< HEAD
=======
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
>>>>>>> parent of 2df0a30... Svarta och vita bönder rör sig själva. 1 steg var



=======
            
>>>>>>> origin/master
        }
    }
}
