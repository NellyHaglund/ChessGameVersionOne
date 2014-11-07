using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    class King : Piece
    {

        GameBoard gameBoard;
        
        public King(Position pos, colour c, GameBoard gameBoard)     // Create Pawn with position, value and colour
        {
            position = pos;
            pieceValue = 11;
            pieceColour = c;
            this.gameBoard = gameBoard;
          
        }
        List<Position> KingMoves = new List<Position>();

        public List<Position> PossibleKingMoves()
        {
            KingMoves.Clear();
            KingMoves.Add(new Position(position.X + 1, position.Y));
            KingMoves.Add(new Position(position.X + 1, position.Y - 1));
            KingMoves.Add(new Position(position.X + 1, position.Y + 1));
            KingMoves.Add(new Position(position.X, position.Y - 1));
            KingMoves.Add(new Position(position.X, position.Y + 1));
            KingMoves.Add(new Position(position.X - 1, position.Y - 1));
            KingMoves.Add(new Position(position.X - 1, position.Y + 1));
            KingMoves.Add(new Position(position.X - 1, position.Y));

            return KingMoves;
        }

        public override void Move()
        {

                PossibleKingMoves();
            
            Random random = new Random();


             int ranking = random.Next((KingMoves.Count));
            


            if (pieceColour == colour.white)
            {
                gameBoard.UpdatePosition(this, KingMoves.ElementAt(ranking));
                // break;
            }
            else
            {
                gameBoard.UpdatePosition(this, KingMoves.ElementAt(ranking));
                // break;
            }
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
