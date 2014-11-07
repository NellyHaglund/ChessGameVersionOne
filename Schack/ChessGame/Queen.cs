using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    class Queen : Piece
    {
        GameBoard gameBoard;
        public Queen(Position pos, ConsoleColor c, GameBoard gameBoard)
        {
            position = pos;
            pieceValue = 9;
            PieceColour = c;
            this.gameBoard = gameBoard;
            PieceChar = 'Q';
        }

        List<Position> QueenMoves = new List<Position>();

        public List<Position> PossibleQueenMoves()
        {
            QueenMoves.Clear();
            // Rör sig lodrätt nedåt
            QueenMoves.Add(new Position(position.X + 1, position.Y));
            QueenMoves.Add(new Position(position.X + 2, position.Y));
            QueenMoves.Add(new Position(position.X + 3, position.Y));
            QueenMoves.Add(new Position(position.X + 4, position.Y));
            QueenMoves.Add(new Position(position.X + 5, position.Y));
            QueenMoves.Add(new Position(position.X + 6, position.Y));
            QueenMoves.Add(new Position(position.X + 7, position.Y));
            // Rör sig lodrätt uppåt
            QueenMoves.Add(new Position(position.X - 1, position.Y));
            QueenMoves.Add(new Position(position.X - 2, position.Y));
            QueenMoves.Add(new Position(position.X - 3, position.Y));
            QueenMoves.Add(new Position(position.X - 4, position.Y));
            QueenMoves.Add(new Position(position.X - 5, position.Y));
            QueenMoves.Add(new Position(position.X - 6, position.Y));
            QueenMoves.Add(new Position(position.X - 7, position.Y));
            // Rör sig vågrätt höger
            QueenMoves.Add(new Position(position.X, position.Y + 1));
            QueenMoves.Add(new Position(position.X, position.Y + 2));
            QueenMoves.Add(new Position(position.X, position.Y + 3));
            QueenMoves.Add(new Position(position.X, position.Y + 4));
            QueenMoves.Add(new Position(position.X, position.Y + 5));
            QueenMoves.Add(new Position(position.X, position.Y + 6));
            QueenMoves.Add(new Position(position.X, position.Y + 7));
            // Rör sig vågrätt vänster
            QueenMoves.Add(new Position(position.X, position.Y - 1));
            QueenMoves.Add(new Position(position.X, position.Y - 2));
            QueenMoves.Add(new Position(position.X, position.Y - 3));
            QueenMoves.Add(new Position(position.X, position.Y - 4));
            QueenMoves.Add(new Position(position.X, position.Y - 5));
            QueenMoves.Add(new Position(position.X, position.Y - 6));
            QueenMoves.Add(new Position(position.X, position.Y - 7));
            // Diagonalt nedåt mot höger
            QueenMoves.Add(new Position(position.X + 1, position.Y + 1));
            QueenMoves.Add(new Position(position.X + 2, position.Y + 2));
            QueenMoves.Add(new Position(position.X + 3, position.Y + 3));
            QueenMoves.Add(new Position(position.X + 4, position.Y + 4));
            QueenMoves.Add(new Position(position.X + 5, position.Y + 5));
            QueenMoves.Add(new Position(position.X + 6, position.Y + 6));
            QueenMoves.Add(new Position(position.X + 7, position.Y + 7));
            // Diagonalt nedåt mot vänster
            QueenMoves.Add(new Position(position.X + 1, position.Y - 1));
            QueenMoves.Add(new Position(position.X + 2, position.Y - 2));
            QueenMoves.Add(new Position(position.X + 3, position.Y - 3));
            QueenMoves.Add(new Position(position.X + 4, position.Y - 4));
            QueenMoves.Add(new Position(position.X + 5, position.Y - 5));
            QueenMoves.Add(new Position(position.X + 6, position.Y - 6));
            QueenMoves.Add(new Position(position.X + 7, position.Y - 7));
            // Diagonalt uppåt mot vänster
            QueenMoves.Add(new Position(position.X - 1, position.Y + 1));
            QueenMoves.Add(new Position(position.X - 2, position.Y + 2));
            QueenMoves.Add(new Position(position.X - 3, position.Y + 3));
            QueenMoves.Add(new Position(position.X - 4, position.Y + 4));
            QueenMoves.Add(new Position(position.X - 5, position.Y + 5));
            QueenMoves.Add(new Position(position.X - 6, position.Y + 6));
            QueenMoves.Add(new Position(position.X - 7, position.Y + 7));
            // Diagonalt uppåt mot höger
            QueenMoves.Add(new Position(position.X - 1, position.Y - 1));
            QueenMoves.Add(new Position(position.X - 2, position.Y - 2));
            QueenMoves.Add(new Position(position.X - 3, position.Y - 3));
            QueenMoves.Add(new Position(position.X - 4, position.Y - 4));
            QueenMoves.Add(new Position(position.X - 5, position.Y - 5));
            QueenMoves.Add(new Position(position.X - 6, position.Y - 6));
            QueenMoves.Add(new Position(position.X - 7, position.Y - 7));

            return QueenMoves;
        }

        public override void Move(Piece piece)
        {
            PossibleQueenMoves();

            Random random = new Random();
            int ranking = random.Next((QueenMoves.Count));

            if (PieceColour == ConsoleColor.White)
            {
                gameBoard.UpdatePosition(this, QueenMoves.ElementAt(ranking));
            }
            else
            {
                gameBoard.UpdatePosition(this, QueenMoves.ElementAt(ranking));
            }
        }

        public override string ToString()  
        {
            if (PieceColour == ConsoleColor.White)
            {


                return "White Queen moved from position:  " + position.X + "," + position.Y;
            }
            else
            {
                return "Black Queen moved from position:  " + position.X + "," + position.Y;
            }
        }
    }
}
