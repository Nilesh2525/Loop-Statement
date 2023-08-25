using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_Statement
{
    // Write a program to find sum of all even numbers between 1 to n
    internal class Practice9
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                int sum = 0;

                for (int i = 1; i <= 10; i++)
                {
                    if (i % 2 == 0)
                    {
                        sum = sum + i;
                    }
                }
                Console.WriteLine("The sum of 1 to 10 is =" + sum);
            }
        }
    }
}
