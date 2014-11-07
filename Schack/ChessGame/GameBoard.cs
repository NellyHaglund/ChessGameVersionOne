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

        public void UpdatePosition(Piece piece, Position position)
        {

            if (position.X >= 0 && position.X < 8 && position.Y >= 0 && position.Y < 8)
            {
                board[piece.position.X, piece.position.Y] = null;
                piece.position.X = position.X;
                piece.position.Y = position.Y;
                board[position.X, position.Y] = piece;
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
                    else
                    {
                        Console.ForegroundColor = board[x, y].PieceColour;
                        
                        Console.Write("[{0}]",board[x, y].PieceChar);
                        
                    }
                }
            }
        }
    }
}
