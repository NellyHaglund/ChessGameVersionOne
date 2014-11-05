using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    class Knight : Piece
    {
         public Knight(Position pos, colour c)     // Create Pawn with position, value and colour
        {
            position = pos;
            pieceValue = 6;            
            pieceColour = c;
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
