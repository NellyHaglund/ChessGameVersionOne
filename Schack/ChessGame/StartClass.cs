using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    class StartClass
    {
        public void Start()
        {
            Console.WriteLine("Start the game? y/n");
            string answer = Console.ReadLine();

            Piece piece = new Piece();
            piece.whitePawn = 15;
            piece.blackPawn = 05;



            var blackPawn1 = piece.blackPawn;
            var blackPawn2 = piece.blackPawn;
            var blackPawn3 = piece.blackPawn;
            var blackPawn4 = piece.blackPawn;
            var blackPawn5 = piece.blackPawn;
            var blackPawn6 = piece.blackPawn;
            var blackPawn7 = piece.blackPawn;
            var blackPawn8 = piece.blackPawn;

            var whitePawn1 = piece.whitePawn;
            var whitePawn2 = piece.whitePawn;
            var whitePawn3 = piece.whitePawn;
            var whitePawn4 = piece.whitePawn;
            var whitePawn5 = piece.whitePawn;
            var whitePawn6 = piece.whitePawn;
            var whitePawn7 = piece.whitePawn;
            var whitePawn8 = piece.whitePawn;




            GameBoard gameBoard = new GameBoard();


            gameBoard.board[1, 0] = whitePawn1;
            gameBoard.board[1, 1] = whitePawn2;
            gameBoard.board[1, 2] = whitePawn3;
            gameBoard.board[1, 3] = whitePawn4;
            gameBoard.board[1, 4] = whitePawn5;
            gameBoard.board[1, 5] = whitePawn6;
            gameBoard.board[1, 6] = whitePawn7;
            gameBoard.board[1, 7] = whitePawn8;

            gameBoard.board[6, 0] = blackPawn1;
            gameBoard.board[6, 1] = blackPawn2;
            gameBoard.board[6, 2] = blackPawn3;
            gameBoard.board[6, 3] = blackPawn4;
            gameBoard.board[6, 4] = blackPawn5;
            gameBoard.board[6, 5] = blackPawn6;
            gameBoard.board[6, 6] = blackPawn7;
            gameBoard.board[6, 7] = blackPawn1;



            if (answer == "y" || answer == "Y")
            {
                bool continuePlaying = true; // Spelet ska spela så länge continuePlaying = true
                while (continuePlaying == true)
                {

                    gameBoard.PrintGameBoard(gameBoard.board);
                    continuePlaying = false;
                }

            }

            Console.ReadLine();
        }
    }
}
