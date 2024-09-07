using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace CountySalesTax
{
    class Program
    {
        static void Main(string[] args)
        {
            //Var
            string[] county = {"Cole", "Osage", "Maries", "Gasconade", "Boone", "Franklein", "Camden"};
            double[] rate = { 0.05725, 0.05975, 0.06391, 0.05224, 0.056, 0.06475, 0.05975, 0.05225 };
            double sale;
            string inCounty;
            bool valid = false;
            // Input
            //Repeats until the user input a valid county
            while (!valid)
            {
                WriteLine("Select County (Cole, Osage, Maries, Gasconade, Boone, Franklein, Camden): ");
                inCounty = ReadLine();
                for (int x = 0; x < county.Length; ++x)
                {
                    if (inCounty == county[x])
                    {
                        WriteLine("Enter sales amount: ");
                        sale = ToDouble(ReadLine());
                        valid = true;
                        //Output
                        WriteLine("\nCounty: {0}\nSales Enter: {1}\nCalculated tax: {2}\nTotal: {3}"
                        /*Vars*/,county[x], sale.ToString("c"), (sale*rate[x]).ToString("c"), (sale + (sale*rate[x])).ToString("c"));
                    }
                }
                //Error Message
                if (!valid)
                    WriteLine("Invalid County Name");
                WriteLine();
            }

        }
    }
}
