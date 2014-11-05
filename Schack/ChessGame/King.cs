using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    class King : Piece
    {

        public King(Position pos, colour c)     // Create Pawn with position, value and colour
        {
            position = pos;
            pieceValue = 40;            
            pieceColour = c;
        }

        public override string ToString()       // Method that Prints position of Pawn
        {
            if (pieceColour == colour.white)
            {
                
            
            return "White King moved from position:  " + position.X + "," + position.Y;
            }
            else
            {
                return "Black King moved from position:  " + position.X + "," + position.Y;  
            }
        }
    
    }
}
