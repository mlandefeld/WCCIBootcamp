using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Bootcamp.WeekFive
{
    class DayFour
    {
        public void ReadMore()
        {
            string line = "Amy Lawrence was proud";
            char[] trimLine;
            trimLine = line.ToCharArray();
            for(int i = 0; i<trimLine.Length; i++)
            {
                if (trimLine.Length <= 55)
                {
                    Console.Write(trimLine[i]);

  
                }
                else if(trimLine.Length>55)
                {
                    Console.WriteLine("false");
                    break;
                }
                else
                {
                    break;
                    
                }
            }
            
        }

        static void BuildHouse()
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int y = (width * 5) + (height * 5);
            Console.WriteLine(y);

        }

        static void CountdownTimer()
        {
            Console.WriteLine(DateTime.Now.ToString());
            
        }

        static void ValidName()
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            while (true)
            {
                if (Regex.IsMatch(firstName, @"^[A-Za-z]+$"))
                {

                }
                else if (Regex.IsMatch(lastName, @"^[A-Za-z]+$"))
                {

                }
                break;
            }

            Console.WriteLine(firstName + " " + lastName);
        }

        static void CircleArea()
        {
            double radius = 4.3234;
            double area = Math.PI * (radius * radius);

            Console.WriteLine(area);
            
        }

        static void NumberCheck()
        {
            string test = Console.ReadLine();
            while (true)
            {
                if (Regex.IsMatch(test, @"^[0-9]+$"))
                {

                }
                else
                {

                }
                break;
            }

        }

        static void LostMyTeeth()
        {

        }
    }
}
