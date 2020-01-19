using System;

namespace TicTacToe
{
    class TicTacToe
    {
        static int[,] board;
        string playerName;

        public TicTacToe(int player, string playerName)
        {
            PlayerName = playerName
            Player = player;
            board = new int[3, 3];
        }
        public int Player { get; set;  }

        public string PlayerName
        {
            get { return _playerName;  }
            set
            {
                if (value.Length > 0)
                    _playerName = value;
                else
                {
                    while (value.Length < 1)  //has to be a name and not nothing
                    {
                        Console.WriteLine("InvalidCastException entry. Please re-enter player's name: ");
                        value = Console.ReadLine();
                    }
                }
            }
        }
        public static void intBoard()
        {
            for (int r =0; r < 3; r++)
            {
                for (int c = 0; c < 3; c++)
                    board[r, c] = 0;
            }
            displayBoard();
        }
        private static void displayBoard()
        {
            for (int r = 0; r <3; r++)
            {
                for (int c = 0; c < 3; c++)
                    Console.Write(board[r, c] + "");

                Console.WriteLine();
            }
            Console.WriteLine();  //extra line between moves
        }
    }
}
