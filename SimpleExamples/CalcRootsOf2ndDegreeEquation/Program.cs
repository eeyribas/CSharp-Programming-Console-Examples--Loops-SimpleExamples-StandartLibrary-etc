﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcRootsOf2ndDegreeEquation
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Esen EYRIBAS";

            Console.WriteLine("Calculating Roots of 2nd Degree Equation\n");
            double x1, x2;
            Console.Write("\ta value > ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("\tb value > ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("\tc value > ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            double delta = b * b - 4 * a * c;
            if (delta < 0)
            {
                Console.WriteLine("\tRoot is digital");
            }
            else if (delta > 0)
            {
                Console.WriteLine("\tRoot is reel");
                x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("\tx1 = {0}\n\tx2 = {1}", x1, x2);
            }
            else
            {
                Console.WriteLine("\tRoot is equal");
                x1 = -b / (2 * a);
                Console.WriteLine("\tx1 = x2 = " + x1);
            }

            Console.Write("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
