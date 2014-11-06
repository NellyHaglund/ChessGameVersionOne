using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    public class StartClass
    { 
        //List With All Black Pieces
        public List<Piece> blackPieceList = new List<Piece>();
        //List With All White Pieces
        public List<Piece> whitePieceList = new List<Piece>();
        //List With All Pieces Toghether
        public List<Piece> PieceList = new List<Piece>();

        public void Start()
        {
            //Start Game
            Console.WriteLine("Start the game? y/n");
            string answer = Console.ReadLine();

            GameBoard gameBoard = new GameBoard();
            MovePosition movePosition = new MovePosition(gameBoard);
            Random random = new Random();

            //White pieces set at positions on GameBoard
            gameBoard.board[1, 0] = new Pawn(new Position(1, 0), colour.white);
            gameBoard.board[1, 1] = new Pawn(new Position(1, 1), colour.white);
            gameBoard.board[1, 2] = new Pawn(new Position(1, 2), colour.white);
            gameBoard.board[1, 3] = new Pawn(new Position(1, 3), colour.white);
            gameBoard.board[1, 4] = new Pawn(new Position(1, 4), colour.white);
            gameBoard.board[1, 5] = new Pawn(new Position(1, 5), colour.white);
            gameBoard.board[1, 6] = new Pawn(new Position(1, 6), colour.white);
            gameBoard.board[1, 7] = new Pawn(new Position(1, 7), colour.white);
            gameBoard.board[0, 4] = new King(new Position(0, 4), colour.white);
            gameBoard.board[0, 3] = new Queen(new Position(0, 3), colour.white);
            gameBoard.board[0, 2] = new Knight(new Position(0, 2), colour.white);
            gameBoard.board[0, 5] = new Knight(new Position(0, 5), colour.white);

            //Adds white pieces to a list         
            whitePieceList.Add(gameBoard.board[1, 0]);
            whitePieceList.Add(gameBoard.board[1, 1]);
            whitePieceList.Add(gameBoard.board[1, 2]);
            whitePieceList.Add(gameBoard.board[1, 3]);
            whitePieceList.Add(gameBoard.board[1, 4]);
            whitePieceList.Add(gameBoard.board[1, 5]);
            whitePieceList.Add(gameBoard.board[1, 6]);
            whitePieceList.Add(gameBoard.board[1, 7]);
            whitePieceList.Add(gameBoard.board[0, 4]);
            whitePieceList.Add(gameBoard.board[0, 3]);
            whitePieceList.Add(gameBoard.board[0, 2]);
            whitePieceList.Add(gameBoard.board[0, 5]);

            // Black Pieces sets at positions on GameBoard
            gameBoard.board[6, 0] = new Pawn(new Position(6, 0), colour.black);
            gameBoard.board[6, 1] = new Pawn(new Position(6, 1), colour.black);
            gameBoard.board[6, 2] = new Pawn(new Position(6, 2), colour.black);
            gameBoard.board[6, 3] = new Pawn(new Position(6, 3), colour.black);
            gameBoard.board[6, 4] = new Pawn(new Position(6, 4), colour.black);
            gameBoard.board[6, 5] = new Pawn(new Position(6, 5), colour.black);
            gameBoard.board[6, 6] = new Pawn(new Position(6, 6), colour.black);
            gameBoard.board[6, 7] = new Pawn(new Position(6, 7), colour.black);
            gameBoard.board[7, 3] = new King(new Position(7, 3), colour.black);
            gameBoard.board[7, 4] = new Queen(new Position(7, 3), colour.black);
            gameBoard.board[7, 2] = new Knight(new Position(7, 2), colour.black);
            gameBoard.board[7, 5] = new Knight(new Position(7, 5), colour.black);

            //Adds black pieces to a list                                                                                    
            blackPieceList.Add(gameBoard.board[6, 0]);
            blackPieceList.Add(gameBoard.board[6, 1]);
            blackPieceList.Add(gameBoard.board[6, 2]);
            blackPieceList.Add(gameBoard.board[6, 3]);
            blackPieceList.Add(gameBoard.board[6, 4]);
            blackPieceList.Add(gameBoard.board[6, 5]);
            blackPieceList.Add(gameBoard.board[6, 6]);
            blackPieceList.Add(gameBoard.board[6, 7]);
            blackPieceList.Add(gameBoard.board[7, 3]);
            blackPieceList.Add(gameBoard.board[7, 4]);
            blackPieceList.Add(gameBoard.board[7, 2]);
            blackPieceList.Add(gameBoard.board[7, 3]);

            //Add black/white-list to another list
            //PieceList.AddRange(blackPieceList);
            //PieceList.AddRange(whitePieceList);
                    
            // Print WhitePiece list
            foreach (var whitePiece in whitePieceList)
            {
                Console.WriteLine("White" + whitePiece);
            }
            Console.WriteLine();

            // Print BlackPiece list
            foreach (var blackPiece in blackPieceList)
            {
                Console.WriteLine("Black" + blackPiece);
            }

            
            Console.ReadKey();
            if (answer == "y" || answer == "Y")
            {
                bool continuePlaying = true;
                int turn = 0;

                // Game continues playing while continuePlaying == true
                while (continuePlaying == true)
                {
                    Console.Clear();
                    gameBoard.PrintGameBoard();
                    Console.WriteLine();
                    
                    Console.Clear();
                    movePosition.RandomizeMove(whitePieceList);
                    gameBoard.PrintGameBoard();// whitePawn moves from position [1,0] -> [2,0]
                    Console.WriteLine("");
                    turn++;
                    Console.WriteLine("Turn = " + turn);
                    Console.ReadKey();//System.Threading.Thread.Sleep(200);
                    

                    Console.Clear();
                    movePosition.RandomizeMove(blackPieceList);
                    gameBoard.PrintGameBoard();// whitePawn moves from position [1,0] -> [2,0]
                    Console.WriteLine("");
                    turn++;
                    Console.WriteLine("Turn = " + turn);
                    Console.ReadKey();//System.Threading.Thread.Sleep(200);
                    
                                                                // Prints the GameBoard updated                

                    //foreach (var whitePawn in whitePieceList)                    // prints out updated whitePawn positions
                    //{
                    //    Console.WriteLine("White" + whitePawn.ToString());

                    //}
                    //Console.WriteLine();
                    //foreach (var blackPawn in blackPawnList)
                    //{
                    //    Console.WriteLine("Black" + blackPawn.ToString());       // prints out updated blackPawn positions

                    //}

                    //Console.ReadKey();
                    continuePlaying = true;                                    // If continuePlaying == false; the game ends

                }

            }


            Console.ReadLine();
        }
    }
}
