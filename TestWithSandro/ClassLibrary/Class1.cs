using System;
using System.Threading;

namespace ClassLibrary
{
    public class TicTacToe
    {
        public int players = 2;
        private int CurrentPlayer;
        private char CurrentSign => CurrentPlayer == 1 ? 'X' : 'O';
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
            return (CheckLine(0,0,1,1,2,2) ||
                    CheckLine(0,0,0,1,0,2) ||
                    CheckLine(1,0,1,1,1,2) ||
                    CheckLine(2,0,2,1,2,2)
                    );
        }
        
        private bool CheckLine(int x, int y, int x2, int y2, int x3, int y3)
        {
            return (Tab[x,y] == CurrentSign && Tab[x2,y2] == CurrentSign && Tab[x3,y3] == CurrentSign);
        }
    }
}