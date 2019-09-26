using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counting_Valleys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter total number of steps Taken by Gary:");
            int n = 0;
            n = int.Parse(Console.ReadLine());
            string[] st = new string[n];
            //  input in array for steps
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter garys's step U for up And D for down repectively for index:" + i);
                st[i] = Console.ReadLine();
            }
            // define variables
            //v for vallay sea for sea level and h for hill
            int v = 0;
            int sea = 0;
            int h = 0;
            for (int j = 0; j < n; j++)
            {
                // vallay condition
                if (st[j] == "D" || st[j] == "d")
                {
                    if (sea == 0)
                    {
                        v++;
                    }
                    sea--;
                }
                if (st[j] == "U" || st[j] == "u")
                {
                    if (sea == 0)
                    {
                        h++;
                    }
                    sea++;
                }
            }

            Console.WriteLine("Gary visits " + v + " Vallays");
            Console.WriteLine("Gary Visits " + h + " Hills");
            Console.ReadKey();
        }
    }
}
