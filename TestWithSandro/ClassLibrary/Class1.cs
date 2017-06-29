using System;

namespace ClassLibrary
{
    public class TicTacToe
    {
        public int players = 2;
        public int CurrentPlayer { get; set; }
        
        public TicTacToe()
        {
            CurrentPlayer = 1;
        }

        public void Next()
        {
            CurrentPlayer = 2;
        }
    }
}