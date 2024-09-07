using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Convert;
using static System.Console;

namespace YDI_CH4
{
    class Program
    {
        static void Main(string[] args)
        {
            //var
            string numString;
            int num1, num2, num3;
            //input
            Write("Enter an integer");
            num1 = ToInt32(ReadLine());
            Write("Enter an integer");
            num2 = ToInt32(ReadLine());
            Write("Enter an integer");
            num3 = ToInt32(ReadLine());
            //Logic
            if (num1 == num2)
                if (num1 == num3)
                    WriteLine("All three numbers are equal");
                else
                    WriteLine("First two are equal");
            else
                if (num1 == num3)
                WriteLine("First and last are equal");
            else
                if (num2 == num3)
                WriteLine("Second and last are equal");
            else
                WriteLine("No two numbers are equal");
                

        }
    }
}
