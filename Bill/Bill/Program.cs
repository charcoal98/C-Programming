using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace Bill
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vars
            double meal, tax, tip, cost;
            //Input
            Write("Enter the meal charge: ");
            meal = ToDouble(ReadLine());
            //Calculate
            tax = meal * .0675;
            tip = (meal + tax) * .2;
            cost = meal + tax + tip;
            //Output
            WriteLine("Meal cost: {0}\nTotal tax: {1}\nTotal tip: {2}\nTotal cost: {3}",
                meal.ToString("c"), tax.ToString("c"), tip.ToString("c"), cost.ToString("c"));
        }
    }
}
