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
         
            GameBoard gameBoard = new GameBoard();
            //vita bönder
          //  List<Piece> WhitePawn = new List<Piece>();


            gameBoard.board[1, 0] = new Pawn(new Position(1, 0), colour.white);
            gameBoard.board[1, 1] = new Pawn(new Position(1, 1), colour.white);
            gameBoard.board[1, 2] = new Pawn(new Position(1, 2), colour.white);
            gameBoard.board[1, 3] = new Pawn(new Position(1, 3), colour.white);
            gameBoard.board[1, 4] = new Pawn(new Position(1, 4), colour.white);
            gameBoard.board[1, 5] = new Pawn(new Position(1, 5), colour.white);
            gameBoard.board[1, 6] = new Pawn(new Position(1, 6), colour.white);
            gameBoard.board[1, 7] = new Pawn(new Position(1, 7), colour.white);


            // svarta bönder

            gameBoard.board[6, 0] = new Pawn(new Position(6, 0), colour.black);
            gameBoard.board[6, 1] = new Pawn(new Position(6, 1), colour.black);
            gameBoard.board[6, 2] = new Pawn(new Position(6, 2), colour.black);
            gameBoard.board[6, 3] = new Pawn(new Position(6, 3), colour.black);
            gameBoard.board[6, 4] = new Pawn(new Position(6, 4), colour.black);
            gameBoard.board[6, 5] = new Pawn(new Position(6, 5), colour.black);
            gameBoard.board[6, 6] = new Pawn(new Position(6, 6), colour.black);
            gameBoard.board[6, 7] = new Pawn(new Position(6, 7), colour.black);
                                                              
           



            Console.WriteLine("Start the game? y/n");
            string answer = Console.ReadLine();

        

           


            if (answer == "y" || answer == "Y")
            {
                bool continuePlaying = true; // Spelet ska spela så länge continuePlaying = true
                while (continuePlaying == true)
                {
                    Console.Clear();
                    gameBoard.PrintGameBoard(gameBoard.board);
                    Console.ReadKey();

                    gameBoard.move(gameBoard.board[1, 0], new Position(2, 0));
                    Console.Clear();
                    gameBoard.PrintGameBoard(gameBoard.board);
                    Console.ReadKey();

                    gameBoard.move(gameBoard.board[6, 1], new Position(5, 1));
                    Console.Clear();
                    gameBoard.PrintGameBoard(gameBoard.board);
                    Console.ReadKey();

                    gameBoard.move(gameBoard.board[2, 0], new Position(3, 0));
                    Console.Clear();
                    gameBoard.PrintGameBoard(gameBoard.board);
                    Console.ReadKey();

                    gameBoard.move(gameBoard.board[5, 1], new Position(4, 1));
                    Console.Clear();
                    gameBoard.PrintGameBoard(gameBoard.board);
                    Console.ReadKey();

                    gameBoard.move(gameBoard.board[3, 0], new Position(4, 1));
                    Console.Clear();
                    gameBoard.PrintGameBoard(gameBoard.board);
                    Console.ReadKey();

                   

                    continuePlaying = false;        

                }

            }

            
            Console.ReadLine();
        }
    }
}
