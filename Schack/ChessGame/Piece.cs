using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
  public  abstract class Piece
    {
        public Position position;
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public colour pieceColour;
        public int pieceValue; 
        public virtual void Value()
        {
            Console.WriteLine("Värde PieceKlassen");
        }
        public virtual void PrintPos()
        {
            Console.WriteLine("PieceKlassen");
        }
    }
  public enum colour
  {
      white, black


  }
}
