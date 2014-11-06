using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    public class GameBoard
    {

        
        // creating the array of the GameBoard at 8*8 
        public Piece[,] board = new Piece[8, 8];
       

        //MovePosition move;
        //StartClass start;
        //public GameBoard(MovePosition move, StartClass start)
        //{
        //    // TODO: Complete member initialization
        //    this.move = move;
        //    this.start = start;
        //}

        //public GameBoard()
        //{
        //    // TODO: Complete member initialization
        //}
         
        // UpdatePosition-method, gets the piece and sets the new position X & Y
        


        public void UpdatePosition(Piece piece, Position pos)                 
        {

            if (pos.X >= 0 && pos.X <8 && pos.Y >= 0 && pos.Y < 8)
            {
                board[piece.position.X, piece.position.Y] = null;
                piece.position.X = pos.X;
                piece.position.Y = pos.Y;
                board[pos.X, pos.Y] = piece;
            }
            else
            {
                               
                Console.WriteLine("Hoppsan! Error..");
            }          
           
        }
        // PrintGameBoard-method, prints out the GameBoard and sets out the
        // pieces on its startPositions
        public void PrintGameBoard()                  
        {                                                         
            
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
                        else if (board[x, y].pieceValue == 40 && board[x, y].pieceColour == colour.white)
                        {
                            Console.Write("[");
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Write("K");
                            Console.ResetColor();
                            Console.Write("]");
                        }
                        else if (board[x, y].pieceValue == 40 && board[x, y].pieceColour == colour.black)
                        {
                            Console.Write("[");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("K");
                            Console.ResetColor();
                            Console.Write("]");
                        }
                        else if (board[x, y].pieceValue == 38 && board[x, y].pieceColour == colour.white)
                        {
                            Console.Write("[");
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Write("Q");
                            Console.ResetColor();
                            Console.Write("]");
                        }
                        else if (board[x, y].pieceValue == 38 && board[x, y].pieceColour == colour.black)
                        {
                            Console.Write("[");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("Q");
                            Console.ResetColor();
                            Console.Write("]");
                        }
                        else if (board[x, y].pieceValue == 6 && board[x, y].pieceColour == colour.white)
                        {
                            Console.Write("[");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("H");
                            Console.ResetColor();
                            Console.Write("]");
                        }
                        else if (board[x, y].pieceValue == 6 && board[x, y].pieceColour == colour.black)
                        {
                            Console.Write("[");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("H");
                            Console.ResetColor();
                            Console.Write("]");
                        }

                        else
                        {
                            Console.Write("FEL: " + board[x, y].pieceValue);
                        }
                    
                }

                Console.WriteLine();
                //kommentar..
            }
            
        }
    }
}
