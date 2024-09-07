using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace You_Do_It
{
    class Program
    {
        static void Main(string[] args)
        {
            int idNum;
            const int LOW = 1000, HIGH = 9999;

            Write("Enter an ID number: ");
            idNum = ToInt32(ReadLine());

            while(idNum < LOW || idNum > HIGH)
            {
                WriteLine("{0} is an invalid ID number", idNum);
                Write("ID numbers must be ");
                WriteLine("between {0} and {1} inclusive", LOW, HIGH);
                Write("Enter an ID number: ");
                idNum = ToInt32(ReadLine());
            }
            WriteLine("ID number {0} is valid", idNum);
        }
    }
}
