using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace TemperatureList
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] temp = new int[6];
            int i;
            int average;
            int total = 0;

            for (i = 0; i < temp.Length; i++)
            {
                WriteLine("Enter High Temperatures for 7 Days");
                temp[i] = Convert.ToInt32(ReadLine());
                total = temp[i] + total;
            }
            average = total / temp.Length;
            for(int j = 0; j < temp.Length; j++)
            {
                WriteLine("The difference for temp " + temp[j] + " and the average is " + (temp[j] - average));
            }
            WriteLine("The average is " + average);

        }
    }
}
