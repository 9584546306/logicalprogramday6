﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6logicalprogram
{
    internal class FibonacciSeries
    {
        public static void FibonacciSeries1()
        {
            int number, n1 = 0, n2 = 1, n3, i;

            Console.WriteLine("Enter the number of elements");

            number = int.Parse(Console.ReadLine());
            Console.Write(n1 + "  " + n2 + "  ");
            for (i = 2; i < number; i++)
            {
                n3 = n1 + n2;
                Console.Write(n3 + "  ");
                n1 = n2;
                n2 = n3;
            }
        }
    }
}
