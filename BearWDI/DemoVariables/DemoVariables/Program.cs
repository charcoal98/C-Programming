using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DemoVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            int anInt = -123456789;
            uint anUnsignedInt = 567;
            WriteLine("The int is {0} and the unsigned int is {1}", anInt, anUnsignedInt);
        }
    }
}