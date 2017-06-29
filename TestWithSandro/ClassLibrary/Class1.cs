using System;
using System.Threading;

namespace ClassLibrary
{
    public class TicTacToe
    {
        public int players = 2;
        private int CurrentPlayer;

        public char CurrentSign => CurrentPlayer == 1 ? 'X' : 'O';

        public char[,] Tab = new char[3,3];
        
        public TicTacToe()
        {
            CurrentPlayer = 1;
        }

        public int GetCurrentPlayer()
        {
            return CurrentPlayer;
        }

        public void Next()
        {
            CurrentPlayer = (CurrentPlayer == 2) ? 1 : 2 ;
        }

        public void Play(int posx, int posy)
        {
            Tab[posx, posy] = CurrentSign;
        }

        public bool Win()
        {
            if (Tab[0,0] == CurrentSign &&Tab[1,1] == CurrentSign &&Tab[2,2] == CurrentSign)
                return true;
            return false;
        }
    }
}