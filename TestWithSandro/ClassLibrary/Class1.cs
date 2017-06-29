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
            return ((Tab[0,0] == CurrentSign && Tab[1,1] == CurrentSign && Tab[2,2] == CurrentSign) ||
                    (Tab[0,0] == CurrentSign && Tab[1,1] == CurrentSign && Tab[2,2] == CurrentSign));
        }
        
        private bool CheckLine(int x, int y, int x2, int y2, int x3, int y3)
        {
            return ((Tab[0,0] == CurrentSign && Tab[1,1] == CurrentSign && Tab[2,2] == CurrentSign) ||
                    (Tab[0,0] == CurrentSign && Tab[1,1] == CurrentSign && Tab[2,2] == CurrentSign));
        }
    }
}