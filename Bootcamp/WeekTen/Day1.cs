using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.WeekTen
{
    class Day1
    {

        public void CodeEvalCabOrChard()
        {
            string input = "Cabernet Merlot Noir | ot";

            string[] substrings = input.Split('|');
            string result = substrings[1].Trim();
            string[] arr = substrings[0].Split(' ');
            Console.WriteLine(arr[1]);

            foreach (var word in arr)
            {
                if (word.Contains(result))
                {
                    Console.WriteLine(word);
                    break;
                }
                else if(!word.Contains(result))
                {
                    Console.WriteLine("False");
                    break;
                }
            }
        }
    }
}
