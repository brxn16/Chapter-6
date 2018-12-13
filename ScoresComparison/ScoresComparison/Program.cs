using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ScoresComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tests = new int[4];
            int previousScore = 0;
            for (int i = 0; i < 4; i++)
            {
                Write("Enter 4 test scores >> ");
                tests[i] = Convert.ToInt32(ReadLine());
            }
            for (int j = 0; j < tests.Length; j++)
            {
                if (tests[j] > previousScore)
                {
                    previousScore = tests[j];
                    WriteLine("Congrats, this is the newest high score!");
                }
                else if (tests[j] < previousScore)
                {
                    WriteLine("Sadly you did not score higher than the highest score! You Suck!!!");
                }
            }
        }
    }
}
