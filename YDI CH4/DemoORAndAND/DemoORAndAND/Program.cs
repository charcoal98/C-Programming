using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace DemoORAndAND
{
    class Program
    {
        static void Main(string[] args)
        {
            const int ZONE1 = 1, ZONE2 = 2;
            const int LOWQUANT = 10;
            int quant, deliv;

            WriteLine("Delivery is free for zone {0} or {1}", ZONE1, ZONE2);
            WriteLine("when the number of boxes is less than {0}", LOWQUANT);
            WriteLine("Enter Deliveryzone ");
            deliv = ToInt32(ReadLine());
            WriteLine("Enter the number of boxes in the shipment");
            quant = Convert.ToInt32(ReadLine());
            if ((deliv == ZONE1 || deliv == ZONE2) && quant < LOWQUANT)
                WriteLine("Delivery is free");
            else
                WriteLine("A delivery charge applies");
        }
    }
}
