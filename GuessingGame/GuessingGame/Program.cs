using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;


namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ran = new Random();
            //var
            int rand = ran.Next(1, 11), guess;
            //input
            WriteLine("Guess a random number between 1 and 10");
            guess = ToInt32(ReadLine());
            //Logic
            WriteLine("The Number is {0}", rand);
            if (rand == guess)
                WriteLine("You guessed Correct");
            else if (rand > guess)
                WriteLine("You guessed to low");
            else
                WriteLine("You guessed to high");

        }
    }
}
