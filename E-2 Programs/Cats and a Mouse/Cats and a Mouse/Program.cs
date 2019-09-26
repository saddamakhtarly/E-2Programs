﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cats_and_a_Mouse
{
    class CAM
    {
        public string fnd()
        {
            Console.WriteLine("IN the function");
            int asteps = 0;
            //cat b steps
            int bsteps = 0;
            int[] po = new int[3];

            /// input for positions of both cat and mouse
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter the Position of CatA,CatB and mouseC " + i);
                po[i] = int.Parse(Console.ReadLine());
            }

            /////// Cat A movement
            if (po[0] < po[2])
            {
                for (int j = po[0]; j < po[2]; j++)
                {
                    asteps++;
                }
            }
            if (po[0] > po[2])
            {
                for (int k = po[0]; k > po[2]; k--)
                {
                    asteps++;
                }
            }

            ///// Cat B movement
            if (po[1] < po[2])
            {
                for (int l = po[1]; l < po[2]; l++)
                {
                    bsteps++;
                }
            }
            if (po[1] > po[2])
            {
                for (int m = po[1]; m > po[2]; m--)
                {
                    bsteps++;
                }
            }

            // output
            string m1 = "";
            if (asteps < bsteps)
            {
                m1 = "CAt A will reach first in steps: " + asteps;
            }
            if (bsteps < asteps)
            {
                m1 = "CAt B will reach first in steps: " + bsteps;

            }
            if (asteps == bsteps)
            {
                m1 = "Mouse C will Escape";

            }

            return m1;

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // ask number of object for the iteration to call the function
            Console.WriteLine("Enter the number of queries you want to perform");
            int q = 0;
            q = int.Parse(Console.ReadLine());
            // calling the function in the class
            string[] dec = new string[q];
            for (int p = 0; p < q; p++)
            {
                CAM lp = new CAM();
                string sv = lp.fnd();
                dec[p] = sv;
            }
            for (int o = 0; o < q; o++)
            {
                Console.WriteLine(dec[o]);
            }
            //CAM f1 = new CAM();
            //string v=f1.fnd();
            //Console.WriteLine(v);


            Console.ReadKey();
        }
    }
}
