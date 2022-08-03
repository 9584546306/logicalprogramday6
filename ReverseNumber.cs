using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6logicalprogram
{
    internal class ReverseNumber
    {
        public static void Reversenumber()
        {
            int n, reverse = 0, rem;
            Console.WriteLine("Enter the number : ");
            n = int.Parse(Console.ReadLine());

            while (n != 0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n = n / 10;
            }
            Console.WriteLine("Reverse Number :" + reverse);
        }
    }
}
