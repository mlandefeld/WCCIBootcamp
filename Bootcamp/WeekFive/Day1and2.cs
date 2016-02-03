using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.WeekFive
{
    class Day1and2
    {
        public void fibonacciCodeEval()
        {
            string line = Console.ReadLine();
            int n = int.Parse(line);


            int[] F = new int[n + 1];
            F[0] = 0;
            F[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                F[i] = F[i - 2] + F[i - 1];
            }

            //unhandled exception for "0"
            if (n>=0)
            {
                Console.WriteLine(F[n]);
            }
            
        }

        public void stringBuilder()
        {
            Console.WriteLine(DateTime.Now);
            StringBuilder test = new StringBuilder();
            test.Append("Build with StringBuilder!");
            for (int i=0;i<200000;i++)
            {
                test.Append(i);

            }
            Console.WriteLine(test);
            Console.WriteLine(DateTime.Now);
        }

        public void capWords()
        {
            string line = "1sdlfkj RE lsRELK";

            if (string.IsNullOrEmpty(line))
            {
                return string.Empty;
            }
            Console.WriteLine(char.ToUpper(line[0])+ line.Substring(1));
        }
    }
}
