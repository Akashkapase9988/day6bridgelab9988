using System;
using System.Collections.Generic;
using System.Text;

namespace day6
{
    public class reverse
    {
        public static void numreverse()
        {
            int n, reverse = 0, rem;
            Console.Write("Enter a number: ");
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n /= 10;
                Console.Write("Reversed Number: " + reverse);
            }
            Console.Write("Reversed Number: " + reverse);
        }
    }
}
