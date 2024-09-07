using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace TippingTable
{
    class Program
    {
        static void Main(string[] args)
        {
            double dinnerPrice = 10.00, tip, tipRate;
            const double LOWRATE = 0.1, MAXRATE = 0.25, TIPSTEP = .05, MAXDINNER = 100, DINNERSTEP = 10;

            Write("    Price");
            for (tipRate = LOWRATE; tipRate <= MAXRATE; tipRate += TIPSTEP)
                Write("{0, 8}", tipRate.ToString("F"));
            WriteLine();
            WriteLine("---------------------------------------");
            tipRate = LOWRATE;
            /*while (dinnerPrice <= MAXDINNER)
            {
                Write("{0, 8}", dinnerPrice.ToString("C"));
                while (tipRate <= MAXRATE)
                {
                    tip = dinnerPrice * tipRate;
                    Write("{0, 8}", tip.ToString("F"));
                    tipRate += TIPSTEP;
                }
                dinnerPrice += DINNERSTEP;
                tipRate = LOWRATE;
                WriteLine();
            }*/
            do
            {
                Write("{0, 8}", dinnerPrice.ToString("C"));
                while (tipRate <= MAXRATE)
                {
                    tip = dinnerPrice * tipRate;
                    Write("{0, 8}", tip.ToString("F"));
                    tipRate += TIPSTEP;
                }
                dinnerPrice += DINNERSTEP;
                tipRate = LOWRATE;
                WriteLine();
            }
            while (dinnerPrice <= MAXDINNER);
        }
    }
}
