using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace ArrayDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[8];
            int x;
            int count;
            const int DASHES = 50;

            for (x = 0; x < scores.Length; ++x)
            {
                Write("Enter your score on test {0} ", x + 1);
                scores[x] = ToInt32(ReadLine());
            }
            WriteLine();
            for (count = 0; count < DASHES; ++count)
                Write("-");
            WriteLine();
            WriteLine("Scores in original order:");
            for (x = 0; x < scores.Length; ++x)
                Write("{0, 6}", scores[x]);
            WriteLine();
            for (count = 0; count < DASHES; ++count)
                Write("-");
            WriteLine();
            Array.Sort(scores);
            WriteLine("Scores in sorted order:");
            for (x = 0; x < scores.Length; ++x)
                Write("{0,6}", scores[x]);
            WriteLine();
            for (count = 0; count < DASHES; ++count)
                Write("-");
            WriteLine();
            Array.Reverse(scores);
            WriteLine("Scores in reverse order:");
            for (x = 0; x < scores.Length; ++x)
                Write("{0, 6}", scores[x]);
            WriteLine();
        }
    }
}
