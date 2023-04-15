﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfChance
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Esen EYRIBAS";

            int n, col, tmp;
            int[] a = new int[6];
            Random r = new Random();
            Console.WriteLine("Game Of Chance\n");
            while (true) {
                Console.Write("Column Number ( between 1 and 20 ) : ");
                if (int.TryParse(Console.ReadLine(), out col)) {
                    if (col < 1 || col > 20)
                        Console.WriteLine("\nError\n");
                    else 
                        break;
                }
                else {
                    Console.WriteLine("\nThe number you entered is not an integer");
                    Console.WriteLine("Please enter an integer...\n");
                }
            }

            Console.Clear();
            Console.WriteLine("Column number = {0,3}\n", col);
            for (int k = 1; k <= col; k++) {
                Console.Write("{0,3}.column ---> ", k);
                a[0] = r.Next(1, 50);
                for (int i = 1; i <= 5; i++) {
                    do {
                        a[i] = r.Next(1, 50);
                        n = 0;
                        for (int j = 0; j < i; j++)
                            if (a[i] == a[j]) n++;
                    } while (n > 0);

                    for (int j = 0; j < i; j++) {
                        if (a[j] > a[i]) {
                            tmp = a[j];
                            a[j] = a[i];
                            a[i] = tmp;
                        }
                    }
                }
                for (int i = 0; i <= 5; i++) 
                    Console.Write("{0,3}", a[i]);
                Console.WriteLine();
            }

            Console.Write("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
