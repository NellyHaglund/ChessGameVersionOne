﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    public class GameBoard
    {
        public Piece[,] board = new Piece[8, 8];

        
        public void PrintGameBoard(Piece[,] board)
        {
           
            
            //int whitePawn = 15;

            //int blackPawn = 05;



            for (int y = 0; y < 8; y++)
            {
                Console.WriteLine();
                for (int x = 0; x < 8; x++)
                {
                    if (board[y, x] == null)
                    {

                        Console.Write("[ ]");
                    }
                    else if (board[y, x].pieceValue == 5 && board[y, x].pieceColour == colour.white )
                    {
                        Console.Write("[B]");
                    }
                    else if (board[y, x].pieceValue == 5 && board[y, x].pieceColour == colour.black)
                    {
                        Console.Write("[F]");
                    }
                    else 
                    {
                        Console.Write("FEL: " +  board[y,x].pieceValue);
                    }
                }
                
                Console.WriteLine();
            }
            


        }
    }
}
