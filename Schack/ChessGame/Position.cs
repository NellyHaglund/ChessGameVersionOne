﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
   public class Position
    {
        public Position()
        {

        }                                // Constructor
        public Position(int x, int y)
        {
            X = x;
            Y = y;
           
        }
        public int X;
        public int Y;
       
    }
}
