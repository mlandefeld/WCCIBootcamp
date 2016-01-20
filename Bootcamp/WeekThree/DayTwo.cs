using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.WeekThree
{
    class DayTwo
    {
        public void reverseWords()
        {
            string line = "   Hello CodeEval";
            string[] arrline = line.Split();
            
            Array.Reverse(arrline);
            foreach (string i in arrline)
            {
                if (arrline == null)
                {
                    continue;
                }

                string linetwo = line.Trim();
                Console.Write(i + " ");
            }

            
            
        }

        public void forEach()
        {
            string foods = "Spaghetti bread carrots candy gummibears";
            string[] arrfoods = foods.Split();

            foreach (string x in arrfoods)
            {
                Console.WriteLine(x);
            }
        }

        public void sumOfDigits()
        {
            string line = "23";
            string[] array = line.Split();
            int sum = int.Parse(array);

            for (int i = 0; i < array.Length; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);

        }

    }
}
