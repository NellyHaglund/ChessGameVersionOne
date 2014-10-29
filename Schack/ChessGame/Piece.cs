using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    class Piece
    {

        public int whitePawn { get; set; }
        public int blackPawn { get; set; }
        public int PieceValue { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public string type;
        public int strength;
        //List<int> pawnWhite = new List<int>();


        //List<int> pawnBlack = new List<int>();


    }
}
