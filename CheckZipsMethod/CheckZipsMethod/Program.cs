using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace CheckZipsMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string entryZip;

            Write("Enter a ZIP code for delivery: ");
            entryZip = ReadLine();
            ZipCodes.displayZips(entryZip);
        }
    }
}
