using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    class Pawn : Piece
    {
        public override void Value()
        {
            
        }
        public int whitePawn { get; set; }
        public int blackPawn { get; set; }

        public Pawn(Position pos, colour c)
        {
            position = pos;
            pieceValue = 5;
            pieceColour = c;
        }
        public override void PrintPos()
        {
            int startX = position.X;
            int startY = position.Y;
            
        }
        
    }
}
