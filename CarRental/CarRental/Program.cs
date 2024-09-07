using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace CarRental
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vars
            int days, miles;
            double charge;
            //Input
            Write("Enter the number of days: ");
            days = ToInt32(ReadLine());
            Write("Enter the nuber of miles driven: ");
            miles = ToInt32(ReadLine());
            //Calculate
            charge = (days * 20) + (miles * .25);
            //Output
            WriteLine("If you rent a car for {0} days and drive {1} miles, your rental fee is {2}.", days, miles, charge.ToString("c"));
        }
    }
}
