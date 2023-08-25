using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_Statement
{
    //Check if the given number is Armstrong or not.
    internal class Practice3
    {
        static void Main(string[] args)
        {
            int n, a, x, sum = 0;
            Console.WriteLine("Enter a three digit number =");
            n = Convert.ToInt32(Console.ReadLine());
            x = n;
            while (n > 0)
            {
                a = n % 10;
                sum = sum + (a * a * a);
                n = n / 10;
            }
            if (sum == x)
            {
                Console.WriteLine("its armstrong ");
            }
            else
            {
                Console.WriteLine("Not armstrong ");
            }

        }
    }
}
    

