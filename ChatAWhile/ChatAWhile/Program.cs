using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace ChatAWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrays
            int[] aCode = {262, 414, 608, 715, 815, 920};
            double[] pMin = {0.07, 0.10, 0.05, 0.16, 0.24, 0.14};
            //var
            int inCode;
            double time;
            bool inArray = false;
            //input
            Write("What area code are you calling? ");
            inCode = ToInt32(ReadLine());
            Write("How many minutes is your call?");
            time = ToDouble(ReadLine());

            //loop
            for (int x = 0; x < aCode.Length; ++x)
            {
                if (inCode == aCode[x])
                {
                    WriteLine("Your phone call to area code {0} cost {1} per minute.\nFor {2} minutes the total is {3}", aCode[x], pMin[x].ToString("C"), time, (pMin[x] * time).ToString("c"));
                    inArray = true;
                }
            }
            if (inArray == false)
                WriteLine("Area Code Out Of Range");

        }
    }
}
