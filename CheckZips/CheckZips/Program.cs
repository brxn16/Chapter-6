using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace CheckZips
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] zips = { 67777, 45555, 87654, 12345, 43527, 19476, 47385, 48676, 49337, 85633 };
            int userZip = 0;
            int result = 0;

            WriteLine("Enter a 5 digit zip code to see if you area code is eligible for us to deliver to you. >>> ");
            userZip = Convert.ToInt32(ReadLine());

            for (int i = 0; i < 1; i++)
            {
                if (zips[i] == userZip)
                {
                    WriteLine("We can deliver to your area!");
                    result = 1;
                }
                else
                {
                    WriteLine("We do not deliver to your area");
                    result = 1;
                }
            }
        }
    }
}
