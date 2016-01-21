﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.WeekTwo
{
    class DayThree
    {
        public void fizzBuzz()
        {
            //fizzbuzz
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }

                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }

                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }

                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        public void multiplyRange()
        {
            int m = int.Parse(Console.ReadLine());

            int n = int.Parse(Console.ReadLine());

            decimal factorial = 1;
            do
            {
                if (n <= 1)
                {
                    break;
                }
                factorial *= n;
                n--;
            } while (n >= m);


            Console.WriteLine("n! = " + factorial);

        }
    }
}
