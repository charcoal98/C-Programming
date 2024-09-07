using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace LoanCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //var
            const double RATE = .045;
            int duration, amount;
            double pay;
            //input
            Write("Enter the loan amount: ");
            amount = ToInt32(ReadLine());

            Write("Enter the duration in months: ");
            duration = ToInt32(ReadLine());
            //calc
            pay = (amount + (amount * RATE)) / duration;
            //output
            WriteLine("With a loan amount of {0} for {1} months, my monthly payment would be {2}.", amount.ToString("c"), duration, pay.ToString("c"));
        }
    }
}
