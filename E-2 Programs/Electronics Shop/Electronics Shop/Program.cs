﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronics_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the total amount monica have:");
            int am = 0;
            am = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of keyboard brand:");
            int k = 0;
            k = int.Parse(Console.ReadLine());
            int[] kam = new int[k];
            Console.WriteLine("Enter the number of Usb brands");
            int u = 0;
            u = int.Parse(Console.ReadLine());
            int[] uam = new int[u];
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine("Enter the amount of keyboard for index" + i);
                kam[i] = int.Parse(Console.ReadLine());
            }
            for (int j = 0; j < u; j++)
            {
                Console.WriteLine("Enter the Amount of Usb For index" + j);
                uam[j] = int.Parse(Console.ReadLine());
            }
            int max = 0;
            int kn = 0;
            int un = 0;
            int ch = 0;
            for (int k1 = 0; k1 < k; k1++)
            {

                for (int l = 0; l < u; l++)
                {
                    ch = kam[k1] + uam[l];
                    if (ch < am)
                    {
                        if (max < ch)
                        {
                            max = ch;
                            kn = k1;
                            un = l;
                        }
                    }
                }

            }
            if (max != 0)
            {
                Console.WriteLine("Monica will buy the keyboard number: " + kn + " And The usb of Number " + un + " Total: " + kam[kn] + "+" + uam[un] + "=" + max);
            }
            if (max == 0)
            {
                Console.WriteLine("You dont have enough money :-1");
            }
            Console.ReadKey();
        }
    }
}
