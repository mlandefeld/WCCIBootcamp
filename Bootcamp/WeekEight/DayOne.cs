using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.WeekEight
{
    class DayOne
    {
        public void NewEnvironment()
        {
            Random num = new Random();
            for(int number = 1; number<=10; number++)
            {
                int randomNumber = num.Next(100, 201);
                Console.WriteLine("{0}",randomNumber);
            }
        }

        public void Day()
        {
            DateTime day = new DateTime();
            Console.WriteLine(day.DayOfWeek.ToString());
        }

        public void Triangle()
        {
            double area = .5 * 7 * 4;
            Console.WriteLine(area);

            double newArea = .5 * 24 * 32 * (Math.Sin(.65));
            Console.WriteLine(newArea);
        }
    }
}
