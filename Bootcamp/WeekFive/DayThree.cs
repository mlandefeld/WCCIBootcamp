using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.WeekFive
{
    class DayThree
    {
        public void SayHi()
        {
            string str = Console.ReadLine();
            int sum = Add(2, 5);

        }

        public int Add(int one, int two)
        {
            int sum = one + two;
            return sum;
        }
    }
}
