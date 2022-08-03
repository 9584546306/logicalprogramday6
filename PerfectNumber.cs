using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6logicalprogram
{
    internal class PerfectNumber
    {
        public static void Perfect_Number()
        {
            int mn, mx, n, i, sum;
            Console.WriteLine("Input the Starting Range of Number");
            mn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the Ending Range of Number");
            mx = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Perfect numbers within the given range");

            for (n = mn; n < mn; n++)
            {
                i = 1;
                sum = 0;

                while (i < n)
                {
                    if (n % i == 0)
                        sum = sum + i;
                    i++;
                }
                if (sum == n)
                    Console.Write("{0} , ", n);
            }
        }

    }
}
        
