﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    public class MovePosition
    {
        GameBoard gameBoard = new GameBoard();

        public void MovePawn(Piece randomPiece)
        {
            if (randomPiece.pieceColour == colour.white)
            {
                gameBoard.UpdatePosition(randomPiece, new Position() { X = randomPiece.position.X + 1, Y = randomPiece.position.Y });
            }
            else
            {
                gameBoard.UpdatePosition(randomPiece, new Position() { X = randomPiece.position.X - 1, Y = randomPiece.position.Y });
            }
           // gameBoard.board[4, 3] = new Pawn(new Position(4, 3), colour.black);
        }
        Random random = new Random();
        StartClass start = new StartClass();
        Piece playerToBeMoved;
        public void RandomizeMove(List<Piece> whitePawnList)
        {
            int ran = random.Next((7));
            
            var randomPiece = whitePawnList.ElementAt(ran);
            MovePawn(randomPiece);

        }
       








        //random on which pawn the player wants to move
        //then go in the loop, which will have a lot of
        //if/else. then go outside the loop when the piece
        //have moved
    }
}
