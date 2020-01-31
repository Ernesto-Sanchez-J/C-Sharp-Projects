using System;
using System.Collections.Generic;

namespace TowersofHanoi
{
    // Towers of Hanoi
    class Program
    {
        private static Dictionary<string, Stack<int>> board = new Dictionary<string, Stack<int>>();
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(4);
            stack.Push(3);
            stack.Push(2);
            stack.Push(1);
            board.Add("A", stack);
            board.Add("B", new Stack<int>());
            board.Add("C", new Stack<int>());

            do
            {
                Console.Clear();
                PrintBoard();
                Console.WriteLine("Enter the tower to move FROM.");
                string from = Console.ReadLine().ToUpper();
                Console.WriteLine("Enter the tower to move TO.");
                string to = Console.ReadLine().ToUpper();

                if (IsMoveValid(from, to))
                {
                    // use the stack.Push(object) to move the peg from the original position to the new position
                    // you can substitute the "object" in the push method with the stack.Pop() 
                    // ex:  stack.Push(stack.Pop());
                }
                else
                {
                    Console.WriteLine("Move was not valid.");
                    Console.WriteLine("Press any key to try again.");
                    Console.ReadKey();
                }

            } while (!CheckWin());

            Console.Clear();
            PrintBoard();
            Console.WriteLine("You win!");
            Console.ReadKey();
        }

        private static bool IsMoveValid(string from, string to)
        {
            // if the count is zero, it means the tower has nothing to move, and you can't move nothing
            if (board[from].Count == 0)
            {
                // nothing in this tower
                return false;
            }
            else if (to == from)
            {
                // can't move a peg from and to the same tower
                return ??;
            }
            // check that the destination tower is not empty before using Peek, otherwise it will throw an error
            else if (board[to].Count != 0)
            {
                // can't move a larger number on top of a smaller number
                if (??.Peek() > ??.Peek()) //code needs to add a variable
                {
                    return ??;
                }

                // if the above expression is false, it assumes the move is legal
                return true;
            }
            else // move is legal
            {
                return ??;
            }
        }

        private static bool CheckWin()
        {
            // How many items must there be in Stack "C" to win?
            if (board["C"].Count = ??)
            {
                return true;
            }
            return false;
        }

        private static void PrintBoard()
        {
            foreach (var item in board)
            {
                Console.Write($"\n{item.Key}: ");
                var numbers = item.Value.ToArray();
                // print values in reverse order.  You can also use Linq:  .Reverse() instead of a FOR loop
                for (int i = numbers.Length; i > 0; i--)
                {
                    Console.Write(numbers[i - 1] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}