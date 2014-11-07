using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    class Rook : Piece
    {
        GameBoard gameBoard;
        public Rook(Position pos, ConsoleColor c, GameBoard gameBoard)     // Create Pawn with position, value and colour
        {
            position = pos;
            pieceValue = 5;
            PieceColour = c;
            this.gameBoard = gameBoard;
            PieceChar = 'R';
        }
        List<Position> RookMoves = new List<Position>();

        public List<Position> PossibleRookMoves()
        {
            RookMoves.Clear();
            // Rör sig lodrätt nedåt
            RookMoves.Add(new Position(position.X + 1, position.Y));
            RookMoves.Add(new Position(position.X + 2, position.Y));
            RookMoves.Add(new Position(position.X + 3, position.Y));
            RookMoves.Add(new Position(position.X + 4, position.Y));
            RookMoves.Add(new Position(position.X + 5, position.Y));
            RookMoves.Add(new Position(position.X + 6, position.Y));
            RookMoves.Add(new Position(position.X + 7, position.Y));
            // Rör sig lodrätt uppåt
            RookMoves.Add(new Position(position.X - 1, position.Y));
            RookMoves.Add(new Position(position.X - 2, position.Y));
            RookMoves.Add(new Position(position.X - 3, position.Y));
            RookMoves.Add(new Position(position.X - 4, position.Y));
            RookMoves.Add(new Position(position.X - 5, position.Y));
            RookMoves.Add(new Position(position.X - 6, position.Y));
            RookMoves.Add(new Position(position.X - 7, position.Y));
            // Rör sig vågrätt höger
            RookMoves.Add(new Position(position.X, position.Y + 1));
            RookMoves.Add(new Position(position.X, position.Y + 2));
            RookMoves.Add(new Position(position.X, position.Y + 3));
            RookMoves.Add(new Position(position.X, position.Y + 4));
            RookMoves.Add(new Position(position.X, position.Y + 5));
            RookMoves.Add(new Position(position.X, position.Y + 6));
            RookMoves.Add(new Position(position.X, position.Y + 7));
            // Rör sig vågrätt vänster
            RookMoves.Add(new Position(position.X, position.Y - 1));
            RookMoves.Add(new Position(position.X, position.Y - 2));
            RookMoves.Add(new Position(position.X, position.Y - 3));
            RookMoves.Add(new Position(position.X, position.Y - 4));
            RookMoves.Add(new Position(position.X, position.Y - 5));
            RookMoves.Add(new Position(position.X, position.Y - 6));
            RookMoves.Add(new Position(position.X, position.Y - 7));


            return RookMoves;
        }

        public override void Move(Piece piece)
        {

            PossibleRookMoves();

            Random random = new Random();


            int ranking = random.Next((RookMoves.Count));



            if (PieceColour == ConsoleColor.White)
            {
                gameBoard.UpdatePosition(this, RookMoves.ElementAt(ranking));
                // break;
            }
            else
            {
                gameBoard.UpdatePosition(this, RookMoves.ElementAt(ranking));
                // break;
            }
        }

        public override string ToString()       // Method that Prints position of Pawn
        {
            if (PieceColour == ConsoleColor.White)
            {


                return "White Rook moved from position:  " + position.X + "," + position.Y;
            }
            else
            {
                return "Black Rook moved from position:  " + position.X + "," + position.Y;
            }
        }
    }
}
