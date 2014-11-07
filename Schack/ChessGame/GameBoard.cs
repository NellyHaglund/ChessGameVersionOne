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
                        
                        //Vit Kung
                        else if (board[x, y].pieceValue == 11 && board[x, y].pieceColour == colour.white)
                        {
                            Console.Write("[");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("K");
                            Console.ResetColor();
                            Console.Write("]");
                        }
                        //Svart Kung
                        else if (board[x, y].pieceValue == 11 && board[x, y].pieceColour == colour.black)
                        {
                            
                            Console.Write("[");
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.Write("K");
                            Console.ResetColor();
                            Console.Write("]");
                        }
                        //Vit Queen
                        else if (board[x, y].pieceValue == 9 && board[x, y].pieceColour == colour.white)
                        {
                            Console.Write("[");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Q");
                            Console.ResetColor();
                            Console.Write("]");
                        }
                        //Black Queen
                        else if (board[x, y].pieceValue == 9 && board[x, y].pieceColour == colour.black)
                        {
                            Console.Write("[");
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.Write("Q");
                            Console.ResetColor();
                            Console.Write("]");
                        }
                        
                        //White Rook
                        else if (board[x, y].pieceValue == 5 && board[x, y].pieceColour == colour.white)
                        {
                            Console.Write("[");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("R");
                            Console.ResetColor();
                            Console.Write("]");
                        }
                            //Black Rook
                        else if (board[x, y].pieceValue == 5 && board[x, y].pieceColour == colour.black)
                        {
                            Console.Write("[");
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.Write("R");
                            Console.ResetColor();
                            Console.Write("]");
                        }
                        //White Horse
                        else if (board[x, y].pieceValue == 4 && board[x, y].pieceColour == colour.white)
                        {
                            Console.Write("[");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("H");
                            Console.ResetColor();
                            Console.Write("]");
                        }
                        //Black Horse
                        else if (board[x, y].pieceValue == 4 && board[x, y].pieceColour == colour.black)
                        {
                            Console.Write("[");
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.Write("H");
                            Console.ResetColor();
                            Console.Write("]");
                        }
                            //White Löpare
                        else if (board[x, y].pieceValue == 3 && board[x, y].pieceColour == colour.white)
                        {
                            Console.Write("[");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("L");
                            Console.ResetColor();
                            Console.Write("]");
                        }
                            //Black löpare
                        else if (board[x, y].pieceValue == 3 && board[x, y].pieceColour == colour.black)
                        {
                            Console.Write("[");
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.Write("L");
                            Console.ResetColor();
                            Console.Write("]");
                        }
                        //Vit Bonden
                        else if (board[x, y].pieceValue == 1 && board[x, y].pieceColour == colour.white)
                        {
                            Console.Write("[");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("B");
                            Console.ResetColor();
                            Console.Write("]");
                        }
                        //Svart Bonden
                        else if (board[x, y].pieceValue == 1 && board[x, y].pieceColour == colour.black)
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
            
        }
    }
}
