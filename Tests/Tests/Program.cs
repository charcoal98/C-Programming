using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vars
            double total = 0, average;
            int i = 0;
            //Input
            while (i < 5) {
                Write("Enter the score for test {0}: ", i + 1);
                total += ToDouble(ReadLine());
                i++;
            }
            //Calculation
            average = total / 5;
            //Output
            WriteLine("{0}% is the average for the five test scores.", average);
        }
    }
}
