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
            int d = 0, e = 0, f = 0;

            //loop
            WriteLine("Enter salesperson's inital (D, E, F or Z to exit)");
            init = ToChar(ReadLine());
            while (init != 'z' && init != 'Z')
            {
                WriteLine("Enter the amount for salesperson {0}", init.ToString());
                if (init == 'D' || init == 'd')
                {
                    d += ToInt32(ReadLine());
                }
                else if (init == 'E' || init == 'e')
                {
                    e += ToInt32(ReadLine());
                }
                else if (init == 'F' || init == 'f')
                {
                    f += ToInt32(ReadLine());
                }
                else if (!(init == 'Z' || init == 'z'))
                {
                    WriteLine("ERROR Invalid Inital");
                }
                WriteLine("Enter salesperson's inital (D, E, F or Z to exit)");
                init = ToChar(ReadLine());
                
            }

            //output
            WriteLine("D sold {0} houses", d);
            WriteLine("E sold {0} houses", e);
            WriteLine("F sold {0} houses", f);
            WriteLine("{0} Total houses sold", (d + e + f));
            if (d > e && d > f) { 
            init = 'D';
            WriteLine("{0} sold the most", init); }
            else if (e > d && e > f){
                init = 'E';
                WriteLine("{0} sold the most", init); }
            else if (f > d && f > e){
                init = 'F';
                WriteLine("{0} sold the most", init); }
        }
    }
}
