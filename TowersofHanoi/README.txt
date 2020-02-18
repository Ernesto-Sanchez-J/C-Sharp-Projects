

namespace TowerOfHanoi
{
    public class TowersofHanoi
    {
        private Dictionary<string, Stack<int>> _board = new Dictionary<string, Stack<int>>  //Dictionary with our numbers and towers
        {
            { "A", new Stack<int>() },
            { "B", new Stack<int>() },
            { "C", new Stack<int>() }
        };

        public TowersofHanoi() //making new board
        {
            _initBoard();
        }

        public void Play() //playing the game until you win
        {
            while (!_gameOver())
            {
                _printBoard();  //resets board with new rings and towers after move is made
                _askMove();  //make your moves 
        }

        private void _initBoard()  //for loop for making rings
        {
            for (int i = 4; i > 0; i--)
            {
                _board["A"].Push(i);
            }
        }

        private void _printBoard()
        {
            foreach (var key in _board.Keys)
            {
                Console.Write(key + ": ");
                _printStack(_board[key]);
                Console.WriteLine();
            }
        }

        private void _printStack(Stack<int> stack)
        {
            int[] arr = stack.ToArray();

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
        }

        private bool _gameOver()  //checking for win condition, true false
        {
            return _board["B"].Count == 4 || _board["C"].Count == 4;  //can win from tower b or tower c

        }

        private void _askMove()  //asks for your move
        {
            Console.WriteLine("Which tower do you want to move from? [A/B/C]?");
            var towerFrom = Console.ReadLine().ToUpper();
            Console.WriteLine("Which tower do you want to move to? [A/B/C]?");
            var towerTo = Console.ReadLine().ToUpper();

            if (_isLegalMove(towerFrom, towerTo))  // checks for legal move
            {
                _move(towerFrom, towerTo);
            }
            else
            {
                Console.WriteLine("Illegal move made, try again.");
            }
        }

        private void _move(string from, string to)
        {
            _board[to].Push(_board[from].Pop());
        }

        private bool _isLegalMove(string from, string to)
        {
            return _board[from].Count != 0 && (_board[to].Count == 0 || _board[from].Peek() < _board[to].Peek());  //returns ring to tower that it was from 
        }                                                                                                           //before illegal move was made
    }

    class Program
    {
        static void Main(string[] args)
        {
            var game = new TowersofHanoi();
            game.Play();
            Console.ReadLine();
        }
    }
}