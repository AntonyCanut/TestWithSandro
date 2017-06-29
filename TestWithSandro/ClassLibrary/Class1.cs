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

        public void Play(int posx, int posy)
        {
            char play;
            if (CurrentPlayer == 1)
            {
                play = 'X';
            }
            else
            {
                play = 'O';
            }
            Tab[posx, posy] = play;
        }

        public bool Win()
        {
            if (Tab[0,0] == 'X' &&Tab[1,1] == 'X' &&Tab[2,2] == 'X')
                return true;
            return false;
        }
    }
}