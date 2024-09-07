using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            //var
            Random rand = new Random();
            int ran = rand.Next(1, 4), user = 1;
            string input;
            //input
            WriteLine("Enter r, p, or s: ");
            input = ReadLine();
            switch (input)
            {
                case "r":
                    user = 1;
                    break;
                case "p":
                    user = 2;
                    break;
                case "s":
                    user = 3;
                    break;
            }
            switch (ran)
            {
                case 1:
                    WriteLine("r");
                    break;
                case 2:
                    WriteLine("p");
                    break;
                case 3:
                    WriteLine("s");
                    break;
            }
            if (ran == user)
                WriteLine("Tie");
            else if (ran == 1)
            {
                if (user == 2)
                    WriteLine("You Win");
                if (user == 3)
                    WriteLine("You Lose");
            }
            else if (ran == 2)
            {
                if (user == 3)
                    WriteLine("You Win");
                if (user == 1)
                    WriteLine("You Lose");
            }
            if (ran == 3)
            {
                if (user == 1)
                    WriteLine("You Win");
                if (user == 2)
                    WriteLine("You Lose");
            }



        }
    }
}
