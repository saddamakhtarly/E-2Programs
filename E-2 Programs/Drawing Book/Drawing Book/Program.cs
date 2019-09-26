using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawing_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DRWAING BOOK");
            Console.WriteLine("Enter the Total Number of pages(n) in the book condion: 1=<n=<10^5");
            int n = 0;
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the page number from where to start(p) Condition 1=<p=<n ");
            int p = 0;
            p = int.Parse(Console.ReadLine());
            int ps = 0;
            for (int i = 1; i <= p; i++)
            {
                if (i % 2 != 0 && i != p)
                {
                    ps++;
                }
            }
            int ns = 0;
            for (int j = n; j >= p; j--)
            {
                if (j % 2 == 0 && j != p)
                {
                    ns++;
                }
            }
            if (ps > ns)
            {
                Console.WriteLine("Start swaping from last page " + n + " The number of pages will be: " + ns);
            }
            if (ns > ps)
            {
                Console.WriteLine("Start swaping form start page 1 The number of pages swap will be: " + ps);
            }
            if (ns == ps)
            {
                Console.WriteLine("You can start from either side ,The number of pages swap will be: " + ns);
            }
            Console.ReadKey();
        }
    }
}
