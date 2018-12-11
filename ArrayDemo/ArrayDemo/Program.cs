using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[8];
            int i;

            for (i = 0; i < 8; i++)
            {
                Write("Enter a number - " + i + " << ");
                arr[i] = Convert.ToInt32(ReadLine());
            }

            int option;

            WriteLine("Choose 1) to view the list in order from first to last position, 2) to view the list in order from the last to first position, or 3) to choose a specific position to view");
            option = Convert.ToInt32(ReadLine());

            if (option == 1)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    WriteLine(arr[j]);
                }
            }
            else if(option == 2)
            {
                for(int b =7; b>=0; b--)
                {
                    WriteLine(arr[b]);
                }
            }
            else if(option == 3)
            {
                int choice;
                WriteLine("What position ");
                choice = Convert.ToInt32(ReadLine());
                WriteLine("The number is " + arr[choice]);
            }
            ReadLine();
        }
    }
}
