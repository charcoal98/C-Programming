using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace CheckingCharges
{
    class Program
    {
        static void Main(string[] args)
        {
            //var
            const double u20 = .10, b2039 = .08, b4059 = .06, o60 = .04;
            int check;
            double charge;
            //input
            WriteLine("Enter number of checks this month: ");
            check = ToInt32(ReadLine());
            //logic
            if (check < 20)
                charge = check * u20;
            else if (check < 40)
                charge = check * b2039;
            else if (check < 60)
                charge = check * b4059;
            else
                charge = check * o60;
            WriteLine("The total charge this month for {0} checks is {1}", check, charge.ToString("C"));
        }
    }
}
