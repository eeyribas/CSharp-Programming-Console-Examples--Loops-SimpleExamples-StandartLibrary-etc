﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_CalcNumberAndFrequency
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Esen EYRIBAS";

            Random r = new Random();
            int k = r.Next(10, 21);
            int[] a = new int[k];
            int n = 1000 * k;

            for(int i = 0; i < n; i++) 
                a[r.Next(k)]++;

            Console.WriteLine("\tNumber = {0}", n);
            Console.WriteLine("\tOrder\tFrequence");
            for(int i = 0; i < k; i++)
                Console.WriteLine("\t{0,3}\t{1,6}", i + 1, a[i]);

            Console.Write("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
