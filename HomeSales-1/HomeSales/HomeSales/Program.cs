using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace HomeSales
{
    class Program
    {
        static void Main(string[] args)
        {
            //var
            char init = 'a';
            string[] names= { "Danielle", "Edward", "Francis"};
            char[] inital = { 'd', 'e', 'f'};
            double[] house = new double[3];
            bool valid = false;

            WriteLine("Enter salesperson's inital (D, E, F or Z to exit)");
            init = Char.ToLower(ToChar(ReadLine()));
            while (init != 'z')
            {
                for (int x = 0; x < inital.Length; ++x)
                {
                    if (init == inital[x])
                    {
                        WriteLine("Enter the amount for salesperson {0}", names[x]);
                        double data = ToDouble(ReadLine());
                        house[x] += data;
                        valid = true;
                    }
                }
                if (!valid)
                    WriteLine("Invalid SalesPerson Inital");
                WriteLine("Enter salesperson's inital (D, E, F or Z to exit)");
                init = Char.ToLower(ToChar(ReadLine()));
            }
            for (int x = 0; x < inital.Length; ++x)
            {
                WriteLine("{0} total is {1}", names[x], house[x].ToString("c"));
            }
            WriteLine("The grand total of sales is {0}", (house[0] + house[1] + house[2]).ToString("c"));
            if (house[0] > house[1] && house[0] > house[2])
            {
                WriteLine("{0} sold the most", names[0]);
            }
            else if (house[1] > house[0] && house[1] > house[2])
            {
                WriteLine("{0} sold the most", names[1]);
            }
            else if (house[2] > house[0] && house[2] > house[1])
            {
                WriteLine("{0} sold the most", names[2]);
            }
            

        }
    }
}
