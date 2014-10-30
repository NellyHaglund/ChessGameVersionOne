﻿using System;
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
                                                                                //Start Game
            Console.WriteLine("Start the game? y/n");
            string answer = Console.ReadLine();

            GameBoard gameBoard = new GameBoard();
                                                                                //White Pawns set at positions on GameBoard
            gameBoard.board[1, 0] = new Pawn(new Position(1, 0), colour.white);
            gameBoard.board[1, 1] = new Pawn(new Position(1, 1), colour.white);
            gameBoard.board[1, 2] = new Pawn(new Position(1, 2), colour.white);
            gameBoard.board[1, 3] = new Pawn(new Position(1, 3), colour.white);
            gameBoard.board[1, 4] = new Pawn(new Position(1, 4), colour.white);
            gameBoard.board[1, 5] = new Pawn(new Position(1, 5), colour.white);
            gameBoard.board[1, 6] = new Pawn(new Position(1, 6), colour.white);
            gameBoard.board[1, 7] = new Pawn(new Position(1, 7), colour.white);

                                                                                 //Adds white pawns to a list
            List<Piece> whitePawnList = new List<Piece>();

            whitePawnList.Add(gameBoard.board[1, 0]);
            whitePawnList.Add(gameBoard.board[1, 1]);
            whitePawnList.Add(gameBoard.board[1, 2]);
            whitePawnList.Add(gameBoard.board[1, 3]);
            whitePawnList.Add(gameBoard.board[1, 4]);
            whitePawnList.Add(gameBoard.board[1, 5]);
            whitePawnList.Add(gameBoard.board[1, 6]);
            whitePawnList.Add(gameBoard.board[1, 7]);




                                                                                // Black Pawns sets at positions on GameBoard
            gameBoard.board[6, 0] = new Pawn(new Position(6, 0), colour.black);
            gameBoard.board[6, 1] = new Pawn(new Position(6, 1), colour.black);
            gameBoard.board[6, 2] = new Pawn(new Position(6, 2), colour.black);
            gameBoard.board[6, 3] = new Pawn(new Position(6, 3), colour.black);
            gameBoard.board[6, 4] = new Pawn(new Position(6, 4), colour.black);
            gameBoard.board[6, 5] = new Pawn(new Position(6, 5), colour.black);
            gameBoard.board[6, 6] = new Pawn(new Position(6, 6), colour.black);
            gameBoard.board[6, 7] = new Pawn(new Position(6, 7), colour.black);

                                                                                //Adds black pawns to a list
            List<Piece> blackPawnList = new List<Piece>();
                             
            blackPawnList.Add(gameBoard.board[6, 0]);
            blackPawnList.Add(gameBoard.board[6, 1]);
            blackPawnList.Add(gameBoard.board[6, 2]);
            blackPawnList.Add(gameBoard.board[6, 3]);
            blackPawnList.Add(gameBoard.board[6, 4]);
            blackPawnList.Add(gameBoard.board[6, 5]);
            blackPawnList.Add(gameBoard.board[6, 6]);
            blackPawnList.Add(gameBoard.board[6, 7]);
                             
            

           

                                                                                // Print whitePawn list
            foreach (var whitePawn in whitePawnList)
            {
                Console.WriteLine("White" + whitePawn.ToString());
            }
            Console.WriteLine();
                                                                                // Print blackPawn list
            foreach (var blackPawn in blackPawnList)
            {
                Console.WriteLine("Black" + blackPawn);
            }

            
            Console.ReadKey();


            if (answer == "y" || answer == "Y")
            {
                bool continuePlaying = true;                                    // Game continues playing while continuePlaying == true
                while (continuePlaying == true)
                {
                    Console.Clear();
                    gameBoard.PrintGameBoard(gameBoard.board);
                    Console.ReadKey();

                    gameBoard.Move(gameBoard.board[1, 0], new Position(2, 0));  // whitePawn moves from position [1,0] -> [2,0]
                    Console.Clear();
                    gameBoard.PrintGameBoard(gameBoard.board);                  // Prints the GameBoard updated
                    Console.ReadKey();

                    gameBoard.Move(gameBoard.board[6, 1], new Position(5, 1));
                    Console.Clear();
                    gameBoard.PrintGameBoard(gameBoard.board);
                    Console.ReadKey();

                    gameBoard.Move(gameBoard.board[2, 0], new Position(3, 0));
                    Console.Clear();
                    gameBoard.PrintGameBoard(gameBoard.board);
                    Console.ReadKey();
                                     
                    gameBoard.Move(gameBoard.board[5, 1], new Position(4, 1));
                    Console.Clear();
                    gameBoard.PrintGameBoard(gameBoard.board);
                    Console.ReadKey();
                    gameBoard.Move(gameBoard.board[3, 0], new Position(4, 1));
                    Console.Clear();
                    gameBoard.PrintGameBoard(gameBoard.board);
                    Console.ReadKey();
                    gameBoard.Move(gameBoard.board[4, 1], new Position(5, 1));
                    Console.Clear();
                    gameBoard.PrintGameBoard(gameBoard.board);
                    Console.ReadKey();

                    foreach (var whitePawn in whitePawnList)                    // prints out updated whitePawn positions
                    {
                        Console.WriteLine("White" + whitePawn.ToString());

                    }
                    Console.WriteLine();
                    foreach (var blackPawn in blackPawnList)
                    {
                        Console.WriteLine("Black" + blackPawn.ToString());       // prints out updated blackPawn positions

                    }

                    Console.ReadKey();
                    continuePlaying = false;

                }

            }


            Console.ReadLine();
        }
    }
}
