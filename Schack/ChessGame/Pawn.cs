using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    class Pawn : Piece
    {
        GameBoard gameBoard;



        public Pawn(Position pos, ConsoleColor c, GameBoard gameBoard)     // Create Pawn with position, value and colour
        {
            position = pos;
            pieceValue = 1;
            PieceColour = c;
            this.gameBoard = gameBoard;
            PieceChar = 'P';
        }


        public override void Move(Piece rondomPiece)
        {
            //bool hasMoved = false;

            if (PieceColour == ConsoleColor.White)
            {



                if (gameBoard.board[position.X + 1, position.Y] == null && position.X > 0 && position.X < 7 &&
                position.Y > 0 && position.Y < 7)
                {

                    gameBoard.UpdatePosition(this, new Position(position.X + 1, position.Y));

                }
                else
                {
                    Console.WriteLine("något ivägen");
                }

            }

            else
            {
                    if (gameBoard.board[position.X - 1, position.Y] == null && position.X > 0 && position.X < 7 &&
                position.Y > 0 && position.Y < 7)
                    {
                    gameBoard.UpdatePosition(this, new Position(position.X - 1, position.Y));


                    }
                    else
                    {
                        Console.WriteLine("något ivägen");
                    }

            }

        }

        public override string ToString()       // Method that Prints position of Pawn
        {
            if (PieceColour == ConsoleColor.White)
            {


                return "White Pawn moved from position:  " + position.X + "," + position.Y;
            }
            else
            {
                return "Black Pawn moved from position:  " + position.X + "," + position.Y;
            }
        }
    }
}
