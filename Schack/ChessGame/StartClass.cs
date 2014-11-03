using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    public class StartClass
    {
      public  List<Piece> blackPawnList = new List<Piece>();

        public List<Piece> whitePawnList = new List<Piece>();
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
                             
            blackPawnList.Add(gameBoard.board[6, 0]);
            blackPawnList.Add(gameBoard.board[6, 1]);
            blackPawnList.Add(gameBoard.board[6, 2]);
            blackPawnList.Add(gameBoard.board[6, 3]);
            blackPawnList.Add(gameBoard.board[6, 4]);
            blackPawnList.Add(gameBoard.board[6, 5]);
            blackPawnList.Add(gameBoard.board[6, 6]);
            blackPawnList.Add(gameBoard.board[6, 7]);


            MovePosition movePosition = new MovePosition(gameBoard);


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
            Random random = new Random();

            if (answer == "y" || answer == "Y")
            {
                bool continuePlaying = true;
                // Game continues playing while continuePlaying == true                  
                while (continuePlaying == true)
                {
                    Console.Clear();
                    gameBoard.PrintGameBoard();

                    //gameBoard.PrintWhitePiece(whitePawnList);
  





                    System.Threading.Thread.Sleep(200);
                    Console.Clear();
                    
                    movePosition.RandomizeMove(whitePawnList);                     
                   
                    gameBoard.PrintGameBoard();                                                              
                    System.Threading.Thread.Sleep(200);
                    Console.Clear();

                    
                    movePosition.RandomizeMove(blackPawnList);
                    gameBoard.PrintGameBoard();
                    System.Threading.Thread.Sleep(200);
                    Console.Clear();

                    // prints out updated whitePawn positions
                    //foreach (var whitePawn in whitePawnList)                    
                    //{
                    //    Console.WriteLine("White" + whitePawn.ToString());

                    //}
                    // prints out updated blackPawn positions
                    //Console.WriteLine();
                    //foreach (var blackPawn in blackPawnList)
                    //{
                    //    Console.WriteLine("Black" + blackPawn.ToString());       

                    //}

                    // If continuePlaying == false; the game ends
                    continuePlaying = true;                                    

                }

            }


            Console.ReadLine();
        }
    }
}
