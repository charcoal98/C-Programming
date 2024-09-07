using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace cellBill
{
    class Program
    {
        static void Main(string[] args)
        {
            //var
            const double MINA = 0.45, MINB = .40;
            const int MAXA = 450, MAXB = 900;
            const double PRICEA = 39.99, PRICEB = 59.99, PRICEC = 69.99;
            char plan = 'A';
            int min;
            double price = 0.0;
            //input
            WriteLine("Enter plan (A, B, C): ");
            plan = ToChar(ReadLine());
            WriteLine("Enter number of minutes used: ");
            min = ToInt32(ReadLine());
            //logic
            switch (plan)
            {
                case 'A':
                    if (min > MAXA)
                        price = PRICEA + (MINA * (min - MAXA));
                    WriteLine("Your Total Charges for {0} Minutes with Package {1} is {2}", min, plan, price.ToString("c"));
                    break;
                case 'B':
                    if (min > MAXB)
                        price = PRICEB + (MINB * (min - MAXB));
                    WriteLine("Your Total Charges for {0} Minutes with Package {1} is {2}", min, plan, price.ToString("c"));
                    break;
                case 'C':
                    WriteLine("Your Total Charges for {0} Minutes with Package {1} is {2}", min, plan, PRICEC.ToString("c"));
                    break;
            }
        }
    }
}
