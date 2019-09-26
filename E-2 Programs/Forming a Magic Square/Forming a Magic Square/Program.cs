using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forming_a_Magic_Square
{
    class Program
    {
        static int formingMagicSquare(int[][] s)
        {
            List<List<int>> lstmagicalsqrs = new List<List<int>>() {
            new List<int>(){ 2, 7, 6, 9, 5, 1, 4, 3, 8 },
            new List<int>(){ 2, 9, 4, 7, 5, 3, 6, 1, 8 },

             new List<int>(){4, 3, 8, 9, 5, 1, 2, 7, 6},
            new List<int>(){ 4, 9, 2, 3, 5, 7, 8, 1, 6},

             new List<int>(){ 6, 1, 8, 7, 5, 3, 2, 9, 4},
            new List<int>(){6, 7, 2, 1, 5, 9, 8, 3, 4 },

             new List<int>(){ 8, 1, 6, 3, 5, 7, 4, 9, 2 },
            new List<int>(){ 8, 3, 4, 1, 5, 9, 6, 7, 2},

        };

            List<int> inputarrtolist = new List<int>();
            List<int> mincostlst = new List<int>();
            int mincount = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    inputarrtolist.Add(s[i][j]);
                }
            }
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    List<int> lst = lstmagicalsqrs[i];

                    if (inputarrtolist[j] != lst[j])
                    {
                        mincount += Math.Abs(inputarrtolist[j] - lst[j]);

                    }
                }

                mincostlst.Add(mincount);
                mincount = 0;

            }

            return mincostlst.Min();
        }
        static void Main(string[] args)
        {
            int[][] s = new int[3][];

            for (int i = 0; i < 3; i++)
            {
                s[i] = Array.ConvertAll(Console.ReadLine().Split(' '), sTemp => Convert.ToInt32(sTemp));
            }

            int result = formingMagicSquare(s);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
