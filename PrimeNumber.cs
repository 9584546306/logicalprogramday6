using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6logicalprogram
{
    internal class PrimeNumber
    {
        public static void primenumber()
        {

            for (int number = 1; number <= 100; number++)
            {
                int count = 0;

                for (int i = 1; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    Console.WriteLine(number);

                }

            }
        }
    }
}
