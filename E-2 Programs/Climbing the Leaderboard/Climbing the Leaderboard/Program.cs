using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Climbing_the_Leaderboard
{
    class Program
    {
        static int[] climbingLeaderboard(int[] scores, int[] alice)
        {
            var ss = new Stack<int>(scores.Take(1));
            foreach (var s in scores) { if (s != ss.Peek()) ss.Push(s); }
            return alice.Select(a => { while (ss.Count > 0 && a >= ss.Peek()) { ss.Pop(); } return ss.Count + 1; }).ToArray();

        }
        static void Main(string[] args)
        {
            int scoresCount = Convert.ToInt32(Console.ReadLine());

            int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp))
            ;
            int aliceCount = Convert.ToInt32(Console.ReadLine());

            int[] alice = Array.ConvertAll(Console.ReadLine().Split(' '), aliceTemp => Convert.ToInt32(aliceTemp))
            ;
            int[] result = climbingLeaderboard(scores, alice);

            Console.WriteLine(string.Join("\n", result));
            Console.ReadLine();

        }
    }
}
