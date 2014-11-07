using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    class Bishop : Piece
    {
        GameBoard gameBoard;
        public Bishop(Position pos, ConsoleColor c, GameBoard gameBoard)     // Create Pawn with position, value and colour
        {
            position = pos;
            pieceValue = 3;
            PieceColour = c;
            this.gameBoard = gameBoard;
            PieceChar = 'B';
        }
        //List With Possible Bishop Moves
        List<Position> BishopMoves = new List<Position>();
        public List<Position> PossibleBishopMoves()
        {
            BishopMoves.Clear();
            // Diagonalt nedåt mot höger
            BishopMoves.Add(new Position(position.X + 1, position.Y + 1));
            BishopMoves.Add(new Position(position.X + 2, position.Y + 2));
            BishopMoves.Add(new Position(position.X + 3, position.Y + 3));
            BishopMoves.Add(new Position(position.X + 4, position.Y + 4));
            BishopMoves.Add(new Position(position.X + 5, position.Y + 5));
            BishopMoves.Add(new Position(position.X + 6, position.Y + 6));
            BishopMoves.Add(new Position(position.X + 7, position.Y + 7));
            // Diagonalt nedåt mot vänster
            BishopMoves.Add(new Position(position.X + 1, position.Y - 1));
            BishopMoves.Add(new Position(position.X + 2, position.Y - 2));
            BishopMoves.Add(new Position(position.X + 3, position.Y - 3));
            BishopMoves.Add(new Position(position.X + 4, position.Y - 4));
            BishopMoves.Add(new Position(position.X + 5, position.Y - 5));
            BishopMoves.Add(new Position(position.X + 6, position.Y - 6));
            BishopMoves.Add(new Position(position.X + 7, position.Y - 7));
            // Diagonalt uppåt mot vänster
            BishopMoves.Add(new Position(position.X - 1, position.Y + 1));
            BishopMoves.Add(new Position(position.X - 2, position.Y + 2));
            BishopMoves.Add(new Position(position.X - 3, position.Y + 3));
            BishopMoves.Add(new Position(position.X - 4, position.Y + 4));
            BishopMoves.Add(new Position(position.X - 5, position.Y + 5));
            BishopMoves.Add(new Position(position.X - 6, position.Y + 6));
            BishopMoves.Add(new Position(position.X - 7, position.Y + 7));
            // Diagonalt uppåt mot höger
            BishopMoves.Add(new Position(position.X - 1, position.Y - 1));
            BishopMoves.Add(new Position(position.X - 2, position.Y - 2));
            BishopMoves.Add(new Position(position.X - 3, position.Y - 3));
            BishopMoves.Add(new Position(position.X - 4, position.Y - 4));
            BishopMoves.Add(new Position(position.X - 5, position.Y - 5));
            BishopMoves.Add(new Position(position.X - 6, position.Y - 6));
            BishopMoves.Add(new Position(position.X - 7, position.Y - 7));

            return BishopMoves;
        }

        public override void Move(Piece piece)
        {

            PossibleBishopMoves();

            Random random = new Random();

            //Väljer ut ett slumpmässigt drag från listan
            int ranking = random.Next((BishopMoves.Count));

            if (PieceColour == ConsoleColor.White)
            {
                
                    gameBoard.UpdatePosition(this, BishopMoves.ElementAt(ranking));
            

            }
            else
            {
                gameBoard.UpdatePosition(this, BishopMoves.ElementAt(ranking));

            }
        }

        // Method that Prints position of Bishop
        public override string ToString()
        {
            if (PieceColour == ConsoleColor.White)
            {
                return "White Bishop moved from position:  " + position.X + "," + position.Y;
            }
            else
            {
                return "Black Bishop moved from position:  " + position.X + "," + position.Y;
            }
        }
    }
}
