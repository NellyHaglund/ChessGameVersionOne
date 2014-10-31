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
           // pawn can move in the game
           // Try use bool moved, if moved = false        
           // it can move two or one step
           // if moved = true, it can only move one step
        }
        
        // Method that Prints position of Pawn                                      
        public override string ToString()       
        {
            return "Pawn at position:  " + position.X + "," + position.Y;
        }
    }
}
