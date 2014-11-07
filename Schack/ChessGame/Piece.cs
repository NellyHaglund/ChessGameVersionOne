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
      
        public bool Moved { get; set; }
      public char PieceChar { get; protected set; }
      public ConsoleColor PieceColour { get; set; }                 
        public int pieceValue;

        public virtual void Move(Piece pic) { }

      public virtual void EnemyOrFree(){}
  
  }

                                                    //Enum class, uses too set players colour, black and/or white
  
}
