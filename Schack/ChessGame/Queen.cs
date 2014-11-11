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
        public List<List<Position>> QueenMoves = new List<List<Position>>();
    //    public List<Position> FinalMovesList = new List<Position>();
        public List<Position> DownDown = new List<Position>();
        public List<Position> UpUp = new List<Position>();
        public List<Position> RightRight = new List<Position>();
        public List<Position> LeftLeft = new List<Position>();
        public List<Position> DownRight = new List<Position>();
        public List<Position> DownLeft = new List<Position>();
        public List<Position> UpLeft = new List<Position>();
        public List<Position> UpRight = new List<Position>();
        public Queen(Position pos, ConsoleColor c, GameBoard gameBoard)
        {
            position = pos;
            pieceValue = 9;
            PieceColour = c;
            this.gameBoard = gameBoard;
            PieceChar = 'Q';
           
        }
        public Queen() { }
        

        public override void PossibleMoves()
        {
            QueenMoves.Clear();
            // Rör sig lodrätt nedåt

            DownDown.Add(new Position(position.X + 1, position.Y));
            DownDown.Add(new Position(position.X + 2, position.Y));
            DownDown.Add(new Position(position.X + 3, position.Y));
            DownDown.Add(new Position(position.X + 4, position.Y));
            DownDown.Add(new Position(position.X + 5, position.Y));
            DownDown.Add(new Position(position.X + 6, position.Y));
            DownDown.Add(new Position(position.X + 7, position.Y));
            


            // Rör sig lodrätt uppåt
            UpUp.Add(new Position(position.X - 1, position.Y));
            UpUp.Add(new Position(position.X - 2, position.Y));
            UpUp.Add(new Position(position.X - 3, position.Y));
            UpUp.Add(new Position(position.X - 4, position.Y));
            UpUp.Add(new Position(position.X - 5, position.Y));
            UpUp.Add(new Position(position.X - 6, position.Y));
            UpUp.Add(new Position(position.X - 7, position.Y));
            // Rör sig vågrätt höger
            RightRight.Add(new Position(position.X, position.Y + 1));
            RightRight.Add(new Position(position.X, position.Y + 2));
            RightRight.Add(new Position(position.X, position.Y + 3));
            RightRight.Add(new Position(position.X, position.Y + 4));
            RightRight.Add(new Position(position.X, position.Y + 5));
            RightRight.Add(new Position(position.X, position.Y + 6));
            RightRight.Add(new Position(position.X, position.Y + 7));
            // Rör sig vågrätt vänster
            LeftLeft.Add(new Position(position.X, position.Y - 1));
            LeftLeft.Add(new Position(position.X, position.Y - 2));
            LeftLeft.Add(new Position(position.X, position.Y - 3));
            LeftLeft.Add(new Position(position.X, position.Y - 4));
            LeftLeft.Add(new Position(position.X, position.Y - 5));
            LeftLeft.Add(new Position(position.X, position.Y - 6));
            LeftLeft.Add(new Position(position.X, position.Y - 7));
            // Diagonalt nedåt mot höger
            DownRight.Add(new Position(position.X + 1, position.Y + 1));
            DownRight.Add(new Position(position.X + 2, position.Y + 2));
            DownRight.Add(new Position(position.X + 3, position.Y + 3));
            DownRight.Add(new Position(position.X + 4, position.Y + 4));
            DownRight.Add(new Position(position.X + 5, position.Y + 5));
            DownRight.Add(new Position(position.X + 6, position.Y + 6));
            DownRight.Add(new Position(position.X + 7, position.Y + 7));
            // Diagonalt nedåt mot vänster
            DownLeft.Add(new Position(position.X + 1, position.Y - 1));
            DownLeft.Add(new Position(position.X + 2, position.Y - 2));
            DownLeft.Add(new Position(position.X + 3, position.Y - 3));
            DownLeft.Add(new Position(position.X + 4, position.Y - 4));
            DownLeft.Add(new Position(position.X + 5, position.Y - 5));
            DownLeft.Add(new Position(position.X + 6, position.Y - 6));
            DownLeft.Add(new Position(position.X + 7, position.Y - 7));
            // Diagonalt uppåt mot vänster
            UpLeft.Add(new Position(position.X - 1, position.Y + 1));
            UpLeft.Add(new Position(position.X - 2, position.Y + 2));
            UpLeft.Add(new Position(position.X - 3, position.Y + 3));
            UpLeft.Add(new Position(position.X - 4, position.Y + 4));
            UpLeft.Add(new Position(position.X - 5, position.Y + 5));
            UpLeft.Add(new Position(position.X - 6, position.Y + 6));
            UpLeft.Add(new Position(position.X - 7, position.Y + 7));
            // Diagonalt uppåt mot höger
            UpRight.Add(new Position(position.X - 1, position.Y - 1));
            UpRight.Add(new Position(position.X - 2, position.Y - 2));
            UpRight.Add(new Position(position.X - 3, position.Y - 3));
            UpRight.Add(new Position(position.X - 4, position.Y - 4));
            UpRight.Add(new Position(position.X - 5, position.Y - 5));
            UpRight.Add(new Position(position.X - 6, position.Y - 6));
            UpRight.Add(new Position(position.X - 7, position.Y - 7));

            QueenMoves.Add(UpUp);
            QueenMoves.Add(UpLeft);
            QueenMoves.Add(UpRight);
            QueenMoves.Add(DownLeft);
            QueenMoves.Add(DownRight);
            QueenMoves.Add(DownDown);
            QueenMoves.Add(RightRight);
            QueenMoves.Add(LeftLeft);


            foreach (var item in QueenMoves)
            {
                Console.WriteLine(item);
                Console.ReadKey();
            }
      }
        public override void Finalmove(Piece piece)
        { 
            foreach (var position in QueenMoves )
            {
                //if (position == null)
                //{
                    FinalMovesList.Add(position);
                //}
              //  else if (position != null && PieceColour.)
            }
            foreach (var item in FinalMovesList)
            {
                Console.WriteLine(item);
            }
        }

        public override void Move(Piece piece)
        {
            PossibleMoves();

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
