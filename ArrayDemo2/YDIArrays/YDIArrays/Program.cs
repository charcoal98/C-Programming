using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace YDIArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //var 
            double[] payRate = { 13.00, 17.35, 19.12, 22.45 };
            for (int x = 0; x < payRate.Length; ++x)
                WriteLine("Pay rate {0} is {1}", x, payRate[x].ToString("C"));
        }
    }
}
