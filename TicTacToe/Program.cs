using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerName = "";
            bool gameOver = false;

            //create players
            Console.WriteLine("Enter player 1 name: ");
            playerName = Console.ReadLine();
            TicTacToe player1 = new TicTacToe(1, playerName);
            Console.WriteLine("Enter player 2 name: (Type 'computer' if you want to play against computer");  //will be computer or human player depending on name
            playerName = Console.ReadLine();
            TicTacToe player2 = new TicTacToe(2, playerName);

            while (!gameOver)  //while loop for determining the game state
            {
                TicTacToe.intBoard();
                while (!player1.Playgame() && !player2.Playgame())
                    gameOver = true;

                if (gameOver)
                {
                    Console.WriteLine("Do you want to play another game Press ESC to quit");
                    if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                        Console.WriteLine("Good Bye");
                    else
                        gameOver = false;
                }
            }
            Console.ReadLine();
        }

        class TicTacToe  //setting up the game with player names
        {
            static int[,] board;
            string playerName;

            public TicTacToe(int player, string playerName)
            {
                PlayerName = playerName;
                Player = player;
                board = new int[3, 3];
            }
            public int Player { get; set; }

            public string PlayerName
            {
                get { return playerName; }
                set
                {
                    if (value.Length > 0)
                        playerName = value;
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

            public bool Playgame()
            {
                int r = 0;  //setting variables
                int c = 0;
                Random rand1 = new Random();
                Random rand2 = new Random();

                if (playerName != "computer") //player v player
                {
                    Console.WriteLine("Enter where to place your symbol");  //takes a row first and then enter to write your column next
                    int.TryParse(Console.ReadLine().Trim(), out r);
                    int.TryParse(Console.ReadLine().Trim(), out c);
                }
                else //player v computer
                {
                    r = rand1.Next(1, 4);
                    c = rand2.Next(1, 4);
                }

                while (!checkBoard(r, c))
                {
                    if (playerName != "computer") // not computer player
                    {
                        Console.WriteLine("Entered incorrect location. Try again.");  //takes a row first and then enter to write your column next
                        int.TryParse(Console.ReadLine().Trim(), out r);
                        int.TryParse(Console.ReadLine().Trim(), out c);
                    }
                    else
                    {
                        r = rand1.Next(1, 4);
                        c = rand2.Next(1, 4);
                    }
                }

                board[r - 1, c - 1] = Player;  // takes input from player and subtracts one because 1-4 is some what easier to understand then 0-3
                displayBoard();

                if (win())
                {
                    if (PlayerName.Equals("computer"))
                        Console.WriteLine("Computer Wins!!");
                    else
                        Console.WriteLine("Congratulations" + PlayerName + " . You Win!!");
                    return true; // game over, somone wins
                }
                else if (draw())
                {
                    Console.WriteLine("It's a Draw!!");
                    return true; // game over, a draw
                }
                return false; // not a draw and not a winner, continue game
            }

            private bool win() //check win conditions
            {
                //rows
                if (board[0, 0].Equals(Player) && board[0, 1].Equals(Player) && board[0, 2].Equals(Player))  //1 1 1
                    return true;
                if (board[1, 0].Equals(Player) && board[1, 1].Equals(Player) && board[1, 2].Equals(Player))  //2 2 2
                    return true;
                if (board[2, 0].Equals(Player) && board[2, 1].Equals(Player) && board[2, 2].Equals(Player))  //3 3 3
                    return true;

                //columns
                if (board[0, 0].Equals(Player) && board[1, 0].Equals(Player) && board[2, 0].Equals(Player))  //1 1 1
                    return true;
                if (board[0, 1].Equals(Player) && board[1, 1].Equals(Player) && board[2, 1].Equals(Player))  //2 2 2
                    return true;
                if (board[0, 2].Equals(Player) && board[1, 2].Equals(Player) && board[2, 2].Equals(Player))  //3 3 3
                    return true;

                //diagonal lines
                if (board[0, 0].Equals(Player) && board[1, 1].Equals(Player) && board[2, 2].Equals(Player))
                    return true;
                if (board[0, 2].Equals(Player) && board[1, 1].Equals(Player) && board[2, 0].Equals(Player))
                    return true;

                return false;
            }


            private bool draw()  //determines board space like empty spaces
            {
                for (int r = 0; r < 3; r++)
                {
                    for (int c = 0; c < 3; c++)
                    {
                        if (board[r, c] != 1 && board[r, c] != 2) 
                            return false;  //not a draw
                    }
                }
                return true;
            }




            private bool checkBoard(int r, int c)  //also checks board
            {
                bool OK = false;
                if (r > 3 || c > 3  || r < 1 || c < 1)
                    return false;

                if (board[r - 1, c - 1] != 1 && board[r - 1, c - 1] != 2)
                    OK = true;

                return OK;

            }
            public static void intBoard() //prints out board
            {
                for (int r = 0; r < 3; r++)
                {
                    for (int c = 0; c < 3; c++)
                        board[r, c] = 0;
                }
                displayBoard();
            }
            private static void displayBoard()
            {
                for (int r = 0; r < 3; r++)
                {
                    for (int c = 0; c < 3; c++)
                        Console.Write(board[r, c] + "");

                    Console.WriteLine();
                }
                Console.WriteLine();  //extra line between moves
            }
        }
    }
}
