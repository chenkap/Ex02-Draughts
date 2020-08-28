using System;
using System.Collections.Generic;
using System.Text;

namespace Ex02_Draughts
{
    public class Program
    {
        public static void Main()
        {
            Board myBoard = new Board(6);
            myBoard.CreateBoard();
            myBoard.PrintBoard();
        }
    }
}
