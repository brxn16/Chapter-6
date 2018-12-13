using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace CheckZipsMethod
{
    class ZipCodes
    {
        static public void displayZips(string entryZip)
        {
            bool zipFound = false;
            string[] zips = { "67777", "45555", "87654", "12345", "43527", "19476", "47385", "48676", "49337", "85633" };
            for (int i = 0; i < zips.Length && !zipFound; ++i)
            {
                if (entryZip == zips[i])
                {
                    WriteLine("Delivery to {0} is ok", entryZip);
                    zipFound = true;
                }
            }
            if (!zipFound)
                WriteLine("Sorry, {0} is not a place we deliver to", entryZip);
        }

    }
}
