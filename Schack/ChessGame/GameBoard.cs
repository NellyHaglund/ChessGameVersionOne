﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    public class GameBoard
    {
        public Piece[,] board = new Piece[8, 8];                    // creating the array of the GameBoard at 8*8 

        public void Move(Piece piece, Position pos)                 // Move-method, gets the piece and sets the new position X & Y
        {
            board[piece.position.X, piece.position.Y] = null;
            board[pos.X, pos.Y] = piece;
            piece.position.X = pos.X;
            piece.position.Y = pos.Y;
        }
        public void PrintGameBoard(Piece[,] board)                  // PrintGameBoard-method, prints out the GameBoard and sets out the 
        {                                                           // pieces on its startPositions
            for (int y = 0; y < 8; y++)
            {
                Console.WriteLine();
                for (int x = 0; x < 8; x++)
                {
                    if (board[y, x] == null)
                    {

                        Console.Write("[ ]");
                    }
                    else if (board[y, x].pieceValue == 5 && board[y, x].pieceColour == colour.white)
                    {
                        Console.Write("[B]");
                    }
                    else if (board[y, x].pieceValue == 5 && board[y, x].pieceColour == colour.black)
                    {
                        Console.Write("[P]");
                    }
                    else
                    {
                        Console.Write("FEL: " + board[y, x].pieceValue);
                    }
                }

                Console.WriteLine();
            }



        }
    }
}
