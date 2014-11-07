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
        List<Position> kingMoves = new List<Position>();

        public King(Position position, ConsoleColor playerColour, GameBoard gameBoard)     // Create Pawn with position, value and colour
        {
            base.position = position;
            pieceValue = 11;
            PieceColour = playerColour;
            this.gameBoard = gameBoard;
            PieceChar = 'K';


        }

        public List<Position> PossibleKingMoves()
        {
            kingMoves.Clear();
            kingMoves.Add(new Position(position.X + 1, position.Y));
            kingMoves.Add(new Position(position.X + 1, position.Y - 1));
            kingMoves.Add(new Position(position.X + 1, position.Y + 1));
            kingMoves.Add(new Position(position.X, position.Y - 1));
            kingMoves.Add(new Position(position.X, position.Y + 1));
            kingMoves.Add(new Position(position.X - 1, position.Y - 1));
            kingMoves.Add(new Position(position.X - 1, position.Y + 1));
            kingMoves.Add(new Position(position.X - 1, position.Y));

            return kingMoves;
        }

        public override void Move(Piece piece)
        {

                PossibleKingMoves();
            
            Random random = new Random();


             int ranking = random.Next((kingMoves.Count));
            


            if (PieceColour == ConsoleColor.White)
            {
                gameBoard.UpdatePosition(this, kingMoves.ElementAt(ranking));
                // break;
            }
            else
            {
                gameBoard.UpdatePosition(this, kingMoves.ElementAt(ranking));
                // break;
            }
        }
       

    

        public override string ToString()       // Method that Prints position of Pawn
        {
            if (PieceColour == ConsoleColor.White)
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
