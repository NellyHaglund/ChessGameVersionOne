using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.DarkYellow;
            StartClass sC = new StartClass();
            
            sC.Start();

            Console.ReadLine();


            Console.ReadKey();

            

        }
    }
}
