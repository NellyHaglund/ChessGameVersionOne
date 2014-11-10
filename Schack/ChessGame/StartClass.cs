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

            //ATTTTENTION!!!!!!! [x,y] x är på lodrätt och y är vågrätt
            //White pieces set at positions on GameBoard & adds white pieces to a list                                                  
            whitePieceList.Add(gameBoard.board[1, 0] = new Pawn(new Position(1, 0), ConsoleColor.White, gameBoard));
            whitePieceList.Add(gameBoard.board[1, 1] = new Pawn(new Position(1, 1), ConsoleColor.White, gameBoard));
            whitePieceList.Add(gameBoard.board[1, 2] = new Pawn(new Position(1, 2), ConsoleColor.White, gameBoard));
            whitePieceList.Add(gameBoard.board[1, 3] = new Pawn(new Position(1, 3), ConsoleColor.White, gameBoard));
            whitePieceList.Add(gameBoard.board[1, 4] = new Pawn(new Position(1, 4), ConsoleColor.White, gameBoard));
            whitePieceList.Add(gameBoard.board[0, 4] = new King(new Position(0, 4), ConsoleColor.White, gameBoard));
            whitePieceList.Add(gameBoard.board[1, 5] = new Pawn(new Position(1, 5), ConsoleColor.White, gameBoard));
            whitePieceList.Add(gameBoard.board[1, 6] = new Pawn(new Position(1, 6), ConsoleColor.White, gameBoard));
            whitePieceList.Add(gameBoard.board[1, 7] = new Pawn(new Position(1, 7), ConsoleColor.White, gameBoard));
            whitePieceList.Add(gameBoard.board[0, 3] = new Queen(new Position(0, 3), ConsoleColor.White, gameBoard));
            whitePieceList.Add(gameBoard.board[0, 1] = new Knight(new Position(0, 1), ConsoleColor.White, gameBoard));
            whitePieceList.Add(gameBoard.board[0, 6] = new Knight(new Position(0, 6), ConsoleColor.White, gameBoard));
            whitePieceList.Add(gameBoard.board[0, 0] = new Rook(new Position(0, 0), ConsoleColor.White, gameBoard));
            whitePieceList.Add(gameBoard.board[0, 7] = new Rook(new Position(0, 7), ConsoleColor.White, gameBoard));
            whitePieceList.Add(gameBoard.board[0, 2] = new Bishop(new Position(0, 2), ConsoleColor.White, gameBoard));
            whitePieceList.Add(gameBoard.board[0, 5] = new Bishop(new Position(0, 5), ConsoleColor.White, gameBoard));

            // Black Pieces sets at positions on GameBoard & adds black pieces to a list
            blackPieceList.Add(gameBoard.board[6, 0] = new Pawn(new Position(6, 0), ConsoleColor.Black, gameBoard));
            blackPieceList.Add(gameBoard.board[6, 1] = new Pawn(new Position(6, 1), ConsoleColor.Black, gameBoard));
            blackPieceList.Add(gameBoard.board[6, 2] = new Pawn(new Position(6, 2), ConsoleColor.Black, gameBoard));
            blackPieceList.Add(gameBoard.board[6, 3] = new Pawn(new Position(6, 3), ConsoleColor.Black, gameBoard));
            blackPieceList.Add(gameBoard.board[6, 4] = new Pawn(new Position(6, 4), ConsoleColor.Black, gameBoard));
            blackPieceList.Add(gameBoard.board[6, 5] = new Pawn(new Position(6, 5), ConsoleColor.Black, gameBoard));
            blackPieceList.Add(gameBoard.board[6, 6] = new Pawn(new Position(6, 6), ConsoleColor.Black, gameBoard));
            blackPieceList.Add(gameBoard.board[6, 7] = new Pawn(new Position(6, 7), ConsoleColor.Black, gameBoard));
            blackPieceList.Add(gameBoard.board[7, 4] = new King(new Position(7, 4), ConsoleColor.Black, gameBoard));
            blackPieceList.Add(gameBoard.board[7, 3] = new Queen(new Position(7, 3), ConsoleColor.Black, gameBoard));
            blackPieceList.Add(gameBoard.board[7, 1] = new Knight(new Position(7, 1), ConsoleColor.Black, gameBoard));
            blackPieceList.Add(gameBoard.board[7, 6] = new Knight(new Position(7, 6), ConsoleColor.Black, gameBoard));
            blackPieceList.Add(gameBoard.board[7, 0] = new Rook(new Position(7, 0), ConsoleColor.Black, gameBoard));
            blackPieceList.Add(gameBoard.board[7, 7] = new Rook(new Position(7, 7), ConsoleColor.Black, gameBoard));
            blackPieceList.Add(gameBoard.board[7, 2] = new Bishop(new Position(7, 2), ConsoleColor.Black, gameBoard));
            blackPieceList.Add(gameBoard.board[7, 5] = new Bishop(new Position(7, 5), ConsoleColor.Black, gameBoard));

           
            Console.ReadKey();
            if (answer == "y" || answer == "Y")
            {
                bool continuePlaying = true;
                int turn = 0;

                // Game continues playing while continuePlaying == true

                Console.Clear();
                Console.WriteLine();
                gameBoard.PrintGameBoard();
                Console.WriteLine();
                Console.ReadKey();

                while (continuePlaying)
                {

                    Console.Clear();
                    movePosition.FindPieceToUse(whitePieceList);
                    //Print out gameboard - updated
                    gameBoard.PrintGameBoard();
                    Console.WriteLine("");
                    //Add turn
                    turn++;
                    Console.WriteLine("Turn = " + turn);
                    Console.ReadKey();
                    //System.Threading.Thread.Sleep(200);

                    Console.Clear();
                    movePosition.FindPieceToUse(blackPieceList);
                    //Print out gameboard - updated
                    gameBoard.PrintGameBoard();
                    Console.WriteLine("");
                    //Add turn
                    turn++;
                    Console.WriteLine("Turn = " + turn);
                    Console.ReadKey();
                    //System.Threading.Thread.Sleep(200);              

                    // If continuePlaying == false; the game ends
                    continuePlaying = true;                                    
                }

            }
            //// Print WhitePiece list ( start positions )
            //foreach (var whitePiece in whitePieceList)
            //{
            //    //Console.SetCursorPosition(45, 35);
            //    Console.Write("White" + whitePiece);
            //}
            //Console.WriteLine();

            //// Print BlackPiece list ( start positions )
            //foreach (var blackPiece in blackPieceList)
            //{
            //    Console.WriteLine("Black" + blackPiece);
            //}


            Console.ReadLine();
        }
    }
}
