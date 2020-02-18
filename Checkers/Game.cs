using System;
using System.Collections.Generic;
using System.Linq;

namespace Checker
{
    #region Game Class
    public class Game
    {
        private Board board;

        public Game()
        {
            this.board = new Board();
        }

        public bool CheckForWin()
        {
            //the following code is using LINQ, you should research LINQ for future lessons
            return (board.checkers.All(x => x.Team == Color.White) || board.checkers.All(x => x.Team == Color.Black));
        }

        public void Start()
        {
            DrawBoard();

            while (!CheckForWin())
            {
                ProcessInput();
            }
            Console.WriteLine("You won!");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        public bool IsLegalMove(Color player, Position source, Position destination)
        {
            // 1. Both the source position and the destination position must be integers between 0 and 7
            //Fill in the blanks in the logic
            if (source.Row < 0 || source.Row > 7 || source.Column < 0 || source.Column > 7
                || destination.Row < 0 || destination.Row > 7 || destination.Column < 0
                || destination.Column > 7) return false;

            // 2. The row distance between the destination position and the source position must be larger than 0 AND less than or equal to 2
            int rowDistance = Math.Abs(destination.Row - source.Row);
            int colDistance = Math.Abs(destination.Column - source.Column);


            //i.e. The line below checks to make sure that the checker cannot move in a straight line.
            if (colDistance == 0 || rowDistance == 0) return false;
            //The line below checks the slope of the checker.
            if (rowDistance / colDistance != 1) return false;

            if (rowDistance > 2) return false;

            Checker c = board.GetChecker(source);
            if (c == null)  // this is no checker at the source position
            {
                return false;
            }

            c = board.GetChecker(destination);
            if (c != null) // the destination position has been taken
            {
                return false;
            }
            // If we get here, that means the source position has a checker AND the destination position is empty AND destination.Row != source.Row AND destination.Column != source.Destination
            //Fill in the blanks in the logic
            if (rowDistance == 2)
            {
                if (IsCapture(source, destination))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }

        public bool IsCapture(Position source, Position destination)
        {
            //We can have a capture move when the source and destination positions are both 2 rows and columns each apart and there is a checker in the middle of the opposite team.

            // |destination.Row - source.Row|==2 && |destination.Column - source.Column|==2
            int rowDistance = Math.Abs(destination.Row - source.Row);
            int colDistance = Math.Abs(destination.Column - source.Column);

            // The above line of code finds the distance between the rows. Place a line of code that will do the same thing for the columns.

            if (rowDistance == 2 && colDistance == 2)
            {
                // there must be a piece in the middle of the source and the destination
                int row_mid = (destination.Row + source.Row) / 2;
                // The above line of code finds the mipoint between the rows. 
                int col_mid = (destination.Column + source.Column) / 2;

                //The following line instantiates a new Position with the midpoint row and column.
                Position p = new Position(row_mid, col_mid);

                //How do we get the checker that has positon p?  This is the midpoint checker.
                Checker c = board.GetChecker(p);
                //How do we get the checker at the source position?
                Checker player = board.GetChecker(source);

                if (c == null)
                {
                    return false;
                }
                else
                {
                    //Remember: Team accesses what part of the checker? What are we comparing here?
                    if (c.Team == player.Team)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            else
            {
                return false;
            }
        }

        public Checker GetCaptureChecker(Position source, Position destination)
        {
            if (IsCapture(source, destination))
            {
                //To get the capture checker we have to find it's position on the board.  We have done this in another place already but because the scope of this method is local you must repeat yourself a bit.
                int row_mid = (destination.Row + source.Row) / 2;
                int col_mid = (destination.Column + source.Column) / 2;
                Position p = new Position(row_mid, col_mid);
                Checker CapturedChecker = board.GetChecker(p);
                return CapturedChecker;
            }
            return null;

        }

        public void ProcessInput()
        {
            ///NOTE: If you want to, you can try to validate the source position right after the user enters the data by checking if there is a checker at the given position
            Console.WriteLine("Select a checker to move (Row, Column):");
            string[] src = Console.ReadLine().Split(','); 


            Console.WriteLine("Select a square to move to (Row, Column):");
            string[] dest = (Console.ReadLine().Split(',')); 

            // usually we need to check if src.Count==2 before we retrieve data src[0] and src[1]
            // you can add the check if you want to. Likewise, we usually check dest.Count==2 as well
            Position from = new Position(int.Parse(src[0]), int.Parse(src[1]));
            Position to = new Position(int.Parse(src[0]), int.Parse(src[1]));

            //1. Get the checker at the source position:
            // hint: use GetChecker function
            Checker srcChecker = board.GetChecker(from);

            //2. If there is no checker at the source position notify the user of the error, then stop
            if (srcChecker == null)
            {
                Console.WriteLine("Invalid source position, try again.");
            }
            //3. If there is a checker at the source position then check if the move from the source position to the destination positio is a legal move
            else
            {
                if (IsLegalMove(srcChecker.Team, from, to))
                {
                    if (IsCapture(from, to))
                    {
                        //We need to find and save the checker that is being jumped.
                        Checker jumpChecker = this.GetCaptureChecker(from, to);

                        //Once we have saved the checker to be jumped, what needs to be done with it? Place the line of code below.
                        board.RemoveChecker(jumpChecker);
                        //What needs to be done with the source checker? Place the line of code below.
                        board.MoveChecker(srcChecker, to);
                    }
                    //What the above code block doesn't execute, what will need to be called? Place the line of code below.
                    board.MoveChecker(srcChecker, to);

                }
                else
                {
                    Console.WriteLine("Invalid move. Check the source and destination.");
                }
            }

            //We need to redraw the board, what function is called?  Place the line of code below.
            DrawBoard();
        }

        public void DrawBoard()
        {
            String[][] grid = new String[8][];
            for (int r = 0; r < 8; r++)
            {
                grid[r] = new String[8];
                for (int c = 0; c < 8; c++)
                {
                    grid[r][c] = " ";
                }
            }
            foreach (Checker c in board.checkers)
            {
                grid[c.Position.Row][c.Position.Column] = c.Symbol;
            }

            Console.WriteLine("   0   1   2   3   4   5   6   7");
            Console.Write("  ");
            for (int i = 0; i < 32; i++)
            {
                Console.Write("\u2501");
            }
            Console.WriteLine();

            for (int r = 0; r < 8; r++)
            {
                Console.Write($"{r} ");
                for (int c = 0; c < 8; c++)
                {
                    Console.Write($" {grid[r][c]} \u2503"); 
                }
                Console.WriteLine();
                Console.Write("  ");
                for (int i = 0; i < 32; i++)
                {
                    Console.Write("\u2501");
                }
                Console.WriteLine();
            }
        }
    }

    #endregion
}