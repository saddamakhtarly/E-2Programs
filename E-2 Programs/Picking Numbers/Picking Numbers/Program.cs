using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picking_Numbers
{
    class Program
    {
        public static int pickingNumbers(List<int> a)
        {

            a.Sort();

            var helpList = new List<int>();

            int count = 0;

            for (int i = 0; i < a.Count() - 1; i++)

            {

                int smt = 1;

                while (a[i + smt] - a[i] < 2)

                {

                    count++;

                    smt++;

                    if (i + smt > a.Count - 1)

                        break;

                }

                count++;

                helpList.Add(count);

                count = 0;
            }
            return helpList.Max();
        }

    
    static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            int result = pickingNumbers(a);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
