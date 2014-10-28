using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    public class GameBoard
    {
        public int[,] board = new int[8, 8];

        
        public int[,] PrintGameBoard(int[,] board)
        {
            Piece piece = new Piece();

            //int whitePawn = 15;

            //int blackPawn = 05;



            for (int y = 0; y < 8; y++)
            {
                Console.WriteLine();
                for (int x = 0; x < 8; x++)
                {
                    if (board[y, x] == 0)
                    {

                        Console.Write("[ ]");
                    }
                    else if (board[y, x] == 5)
                    {
                        Console.Write("[" + (char)182 + "]");
                    }
                    else if (board[y, x] == 15)
                    {
                        Console.Write("[" + (char)165 + "]");
                    }
                }
                
                Console.WriteLine();
            }
            return board;


        }
    }
}
