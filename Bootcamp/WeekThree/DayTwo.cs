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
            if (line != null)
            {
                string[] arrayOfWords = line.Split();
                Array.Reverse(arrayOfWords);

                string final = joinArray(arrayOfWords);

                Console.WriteLine(final);
            }
        }

        public string joinArray(string[] arrayOfWords)
        {
            string final = "";

            foreach (string word in arrayOfWords)
            {
                final += word + " ";
            }

            final = final.Trim();

            return final;
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

            int sum = 0;

            for (int i = 0; i <= line.Length - 1; i++)
            {
                int x = int.Parse(line[i].ToString());
                sum += x;
            }
            Console.WriteLine(sum);
        }

    }
}
