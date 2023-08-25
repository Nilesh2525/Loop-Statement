using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_Statement
{
    internal class Practice2
    {
        static void Main(string[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 1; i++)
            {
                if (n % 2 == 0)
                {
                    Console.WriteLine("not prime =" + n);
                }
                else
                {
                    Console.WriteLine(" prime =" + n);
                }
            }
        }
    }
    
}
