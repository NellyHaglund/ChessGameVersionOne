using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    class Knight : Piece
    {
   GameBoard gameBoard;
         public Knight(Position pos, colour c, GameBoard gameBoard)     // Create Pawn with position, value and colour
        {
            position = pos;
            pieceValue = 6;            
            pieceColour = c;
            this.gameBoard = gameBoard;
        }

         public override void Move()
         {
             bool hasMoved = false;

             if (pieceColour == colour.white)
             {
                 gameBoard.UpdatePosition(this, new Position(position.X + 1, position.Y));
                 // break;
             }
             else
             {
                 gameBoard.UpdatePosition(this, new Position(position.X - 1, position.Y));
                 // break;
             }
         }

        public override string ToString()       // Method that Prints position of Pawn
        {
            if (pieceColour == colour.white)
            {
                
            
            return "White Knight moved from position:  " + position.X + "," + position.Y;
            }
            else
            {
                return "Black Knight moved from position:  " + position.X + "," + position.Y;  
            }
        }
    }
}
