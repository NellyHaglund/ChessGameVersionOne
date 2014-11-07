using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    public class MovePosition
    {
        Position position = new Position();
        GameBoard gameBoard;
        StartClass listInStart = new StartClass();
        Random random = new Random();
      
        public MovePosition(GameBoard gameBoard)
        {
            //Constructor..
            this.gameBoard = gameBoard;
        }
        public void MovePiece(Piece randomPiece)
        {
            //beroende på vilken piece det blir, så kallar vi på dennes Move metod
            randomPiece.Move();   
        }
        public void RandomizePiece(List<Piece> pawnList)
        {
            bool flag = true;
            while (flag == true)
            {
                flag = false;
                int ran = random.Next((pawnList.Count));
                var randomPiece = pawnList.ElementAt(ran);

                if (position.X < 0 || position.X > 7 ||
                    position.Y < 0 || position.Y > 7)
                {
                    if (randomPiece.pieceColour == colour.white)
                    {
                        Console.WriteLine("Din vita pjäs är snart utanför brädet, flytta en annan");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Din svarta pjäs är snart utanför brädet, flytta en annan");
                        Console.ReadKey();
                    }
                    flag = true;
                }
              
                    Console.WriteLine(randomPiece);
                    if (flag == false)
                    {
                        MovePiece(randomPiece);
                    }         
            }
        }
 


        //        public List<Piece> CheckFreePos(List<Piece> White, List<Piece> black)
        //{
        //    List<Piece> FreePos = new List<Piece>();

        //    foreach (var item in White)             //Här vill jag att alla lediga pos på brädet lagras i en lista.
        //    {                                       //Man får då jämföra sin Piecelista med FreePos listan för att kolla vilka som kan flytta
        //        Console.WriteLine("Test teat teat " + item); // man får också jämföra (kanske först) vilka pjäser som man har som kan ta 


        //        if (position x+1 y+ yield-1)
        //        {
        //            FreePos.Add(item);
        //        }
                
                
              
        //    }

            
        //    foreach (var item in FreePos)
        //    {
        //        Console.WriteLine("nya listan"+ item);
        //    }
        //    return FreePos;
        //}



    }

}

//random on which pawn the player wants to move
//then go in the loop, which will have a lot of
//if/else. then go outside the loop when the piece
//have moved



