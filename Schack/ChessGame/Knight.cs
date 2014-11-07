﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    class Knight : Piece
    {
   GameBoard gameBoard;
         public Knight(Position pos, colour c, GameBoard gameBoard)     // Create Pawn with position, value and colour
        {
            position = pos;
            pieceValue = 4;            
            pieceColour = c;
            this.gameBoard = gameBoard;
        }

         List<Position> KnightMoves = new List<Position>();

         public List<Position> PossibleKnightMoves()
         {
             KnightMoves.Clear();
             KnightMoves.Add(new Position(position.X + 1, position.Y - 2));
             KnightMoves.Add(new Position(position.X + 2, position.Y - 1));
             KnightMoves.Add(new Position(position.X + 2, position.Y + 1));
             KnightMoves.Add(new Position(position.X + 1, position.Y + 2));
             KnightMoves.Add(new Position(position.X - 1, position.Y + 2));
             KnightMoves.Add(new Position(position.X - 2, position.Y + 1));
             KnightMoves.Add(new Position(position.X - 2, position.Y - 1));
             KnightMoves.Add(new Position(position.X - 1, position.Y - 2));
        

             return KnightMoves;
         }

         public override void Move()
         {

             PossibleKnightMoves();

             Random random = new Random();


             int ranking = random.Next((KnightMoves.Count));



             if (pieceColour == colour.white)
             {
                 gameBoard.UpdatePosition(this, KnightMoves.ElementAt(ranking));
                 // break;
             }
             else
             {
                 gameBoard.UpdatePosition(this, KnightMoves.ElementAt(ranking));
                 // break;
             }
         }

        public override string ToString()       // Method that Prints position of Pawn
        {
            if (pieceColour == colour.white)
            {
                
            
            return "White Knight moved from position:  " + position.X + "," + position.Y;
            }
            else
            {
                return "Black Knight moved from position:  " + position.X + "," + position.Y;  
            }
        }
    }
}
