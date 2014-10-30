using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    class Pawn : Piece
    {
                                                
        public Pawn(Position pos, colour c)     // Create Pawn with position, value and colour
        {
            position = pos;
            pieceValue = 5;
            pieceColour = c;
        }

        public void MovePawn(Position pps)
        {
         //ToDo. this method will decide how the 
         // Pawn can move in the Game

        }
                                               
        public override string ToString()       // Method that Prints position of Pawn
        {
            return "Pawn at position:  " + position.X + "," + position.Y;
        }
    }
}
