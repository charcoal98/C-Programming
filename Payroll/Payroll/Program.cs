using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace Payroll
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vars
            string name;
            double pay, gross, fed, state, net;
            int hours;
            //Input
            Write("Enter employee name: ");
            name = ReadLine();
            Write("Enter the employee's hourly pay rate: ");
            pay = ToDouble(ReadLine());
            Write("Enter number of hours at a pay rate of {0} ", pay.ToString("c"));
            hours = ToInt32(ReadLine());
            //Calculate
            gross = pay * hours;
            fed = gross * .15;
            state = gross * .05;
            net = (gross - fed) - state;
            //Output
            WriteLine("{0} worked {1} hours at a pay rate of {2}", name, hours, pay.ToString("c"));
            WriteLine("Gross pay was {0}\n{1} was withheld for feseral taxes.\n" +
                "{2} was withheld for state taxes.\nNet pay was {3}.",
                gross.ToString("c"), fed.ToString("c"),state.ToString("c"),net.ToString("c"));
        }
    }
}
