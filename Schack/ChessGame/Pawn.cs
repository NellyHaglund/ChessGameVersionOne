using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    class Pawn : Piece
    {
        public Pawn(Position pos, colour c)
        {
            position = pos;
            pieceValue = 5;
            pieceColour = c;
        }

        public void MovePawn(Position pps)
        {
            GameBoard game = new GameBoard();
            
           

        }
        
    }
}
