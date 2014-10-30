using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    class Rook : Piece
    {
        public override void Value()
        {
            pieceValue = pieceValue + 8;
        }
    }
}
