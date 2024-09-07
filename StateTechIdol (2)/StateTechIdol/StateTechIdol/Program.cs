using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace StateTechIdol
{
    class Program
    {
        static void Main(string[] args)
        {
            //var 
            const int REV = 25;
            int /*Last Years Contestants*/lcont = 0, /*This Years Contestants*/tcont = 0;
            
            bool valid = false;
            //Moto
            WriteLine("**************************");
            WriteLine("*The stars at State Tech.*");
            WriteLine("**************************");

            //User Promt
            while (!valid)/*Validate that the entered value is in range*/
            {
                WriteLine("Enter the number of last year's number of contestants: ");
                int temp = ToInt32(ReadLine());
                if (temp >= 1 && temp <= 30)
                {
                    lcont = temp;
                    valid = true;
                }
                else
                    WriteLine("Invalid Number of Contestants. Number Must Be Between 1-30");
            }
            valid = false;
            while (!valid)/*Validate that the entered value is in range*/
            {
                WriteLine("Enter the number of This year's number of contestants: ");
                int temp = ToInt32(ReadLine());
                if (temp >= 1 && temp <= 30)
                {
                    tcont = temp;
                    valid = true;
                }
                else
                    WriteLine("Invalid Number of Contestants. Number Must Be Between 1-30");
            }
            valid = false;

            //Display Revenue and create Arrays
            string[] names = new string[tcont];
            int[] scores = new int[tcont];
            WriteLine("For last year's revenue it was {0}", (lcont * REV).ToString("c"));
            WriteLine("For this year's revenue it was {0}", (tcont * REV).ToString("c"));

            //Compair last year to this year
            if (tcont > (lcont * 2))
                WriteLine("The competition is more than twice as big this year!");
            else if (tcont > lcont)
                WriteLine("The competition is bigger than ever!");
            else if (tcont < lcont)
                WriteLine("It's a tighter race this year!");
            else
                WriteLine("It's going to be a great race this year!");

            //Populate Arrays
            for (int x = 0; x < tcont; ++x)
            {
                WriteLine("Enter the contestant's name: ");
                names[x] = ReadLine();

                while (!valid)
                { 
                    WriteLine("Enter the contestant's score: ");
                    int temp = ToInt32(ReadLine());
                    if (temp >= 1 && temp <= 10)
                    {
                        scores[x] = temp;
                        valid = true;
                    }
                    else
                        WriteLine("Please enter a valid score between 1 to 10 inclusive");
                }
                valid = false;
            }

            //Bubble Sort Both Arrays to keep same order
            bool sort = false;
            while(!sort){
                sort = true;
                for (int x = 0; x < (tcont) - 1; ++x)
                {
                    if (scores[x] < scores[x + 1])
                    {
                        int temp = scores[x + 1];
                        string /*Temp String*/stemp = names[x + 1];
                        scores[x + 1] = scores[x];
                        names[x + 1] = names[x];
                        scores[x] = temp;
                        names[x] = stemp;
                        sort = false;
                    }
                }
            }

            //Display Contestents
            for (int x = 0; x < (tcont); ++x)
            {
                WriteLine("The Contestant {0} has a score of {1}", names[x], scores[x]);
            }
        }
    }
}
