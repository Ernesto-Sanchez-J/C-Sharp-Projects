using System;

namespace MasterMind
{
    //The program should select 2 colors at random from(Red, Yellow and Blue). The colors can repeat.
    //The program should then prompt the user for their guess.
    //The program should then print a hint to the user if they did not guess correctly:
    //"0-0" if the user did not guess the correct colors at all
    //"1-0" if they guessed one of the colors correctly but not at the correct position
    //"1-1" if they guessed one of the colors correctly at the correct position
    //"2-0" if they guessed both colors correctly but at the wrong positions
    //"2-2" if they guessed both colors correctly and both positions can see when debugging
    public class MasterMind
    {
        private string[] _colors = new string[] { "red", "yellow", "blue" };  //string array with colors
        private string _color1;     //variables set
        private string _color2;
        private void _initGame()
        {
            var rand = new Random();  //computer setting random guesses
            var index1 = rand.Next(0, 3);
            var index2 = rand.Next(0, 3);

            _color1 = _colors[index1];  //converts random guess to color
            _color2 = _colors[index2];
        }


        private bool _checkGuess(string guess)  //checks guess and adds correct answers for hints
        {
            var colorsCorrect = 0;   //hint starts at 0 in game
            var positionsCorrect = 0;

            if (guess.Contains(_color1)) colorsCorrect++; //plus one if guess is correct 
            if (guess.Contains(_color2)) colorsCorrect++;

            var guesses = guess.Split(' ');
            if (guesses[0] == _color1) positionsCorrect++;
            if (guesses[1] == _color2) positionsCorrect++;

            if (colorsCorrect == 2 && positionsCorrect == 2)  //if guesses add up to 2 and 2 then game is over and user wins
            {
                return true;
            }
            else
            {
                Console.WriteLine("Your hint is " + colorsCorrect + "-" + positionsCorrect);  //prints out hint for user if not correct
                return false;
            }
        }

        public MasterMind() //begins game, jumps to class program and starts new game 
        {
            _initGame();
        }

        public void Play() //asks user for guesses
        {
            var guessCount = 0;
            while (guessCount < 5) //has 5 guesses to win game will end when more then 5 guesses
            {
                Console.WriteLine("Enter your guess:");
                if (_checkGuess(Console.ReadLine().ToLower()))
                {
                    Console.WriteLine("You won!!"); //breaks out of while loop win user wins
                    break;
                }
                else
                {
                    guessCount++;  //adds how many guesses the user has made
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args) //wipes game and starts new one
        {
            var game = new MasterMind();
            game.Play();
           
           
            Console.ReadLine();
        }
    }
}