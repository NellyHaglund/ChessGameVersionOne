using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    class Pawn : Piece
    {
                                                // Create Pawn with position, value and colour
        public Pawn(Position pos, colour c)
        {
            position = pos;
            pieceValue = 5;
            pieceColour = c;
        }

        public void MovePawn(Position pps)
        {
           
           

        }
                                                // Method that Prints position of Pawn
        public override string ToString()
        {
            return "Pawn at position:  " + position.X + "," + position.Y;
        }
    }
}
