﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_Statement
{
    //Accept the number from user & print it in reverse order  – > 123  o/p -> 321
    internal class Practice1
    {
        static void Main(string[] args)
        {
            int n, a, rev = 0;
            n = Convert.ToInt32(Console.ReadLine());


            while (n > 0)
            {
                a = n % 10;
                n = n / 10;
                rev = a + (rev * 10);


            }
            Console.WriteLine(rev);


        }
    }
}
    

