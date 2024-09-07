using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace CheckCredit
{
    class Program
    {
        static void Main(string[] args)
        {
            //var 
            const int LIM = 8000;
            double price;
            //input
            WriteLine("Enter purchase price");
            price = ToDouble(ReadLine());
            //logic
            if (price > LIM)
                WriteLine("Price is over the Credit Limit");
            else
                WriteLine("Approved");

        }
    }
}
