using System;
using System.Threading;

namespace ClassLibrary
{
    public class TicTacToe
    {
        public int players = 2;
        public int CurrentPlayer { get; set; }
        public char[,] Tab = new char[3,3];
        
        public TicTacToe()
        {
            CurrentPlayer = 1;
        }

        public void Next()
        {
            CurrentPlayer = (CurrentPlayer == 2) ? 1 : 2 ;
        }
    }
}