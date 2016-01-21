using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.WeekThree
{
    class ProjectDay
    {
        public void Project()
        {
            Console.WriteLine("What is your first name? ");
            string a = Console.ReadLine();
            Console.WriteLine("What is your last name? ");
            string b = Console.ReadLine();
            Console.WriteLine("How old are you? ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("What month were you born? ");
            string d = Console.ReadLine();
            Console.WriteLine("What is your favorite ROYGBIV color? If you do not know what ROYGBIV is, enter \"HELP\". ");
            string e = Console.ReadLine();
            Console.WriteLine("How many siblings do you have? ");
            int f = int.Parse(Console.ReadLine());

            if (c % 2 == 1)
            {
                Console.WriteLine("You will retire in 10 years.");
            }

            if (c % 2 == 0)
            {
                Console.WriteLine("You will retire in 60 years.");
            }

            switch (f)
            {
                case 0:
                    Console.WriteLine("You will live in New Zealand");
                    break;
                case 1:
                    Console.WriteLine("You will live in Oklahoma");
                    break;
                case 2:
                    Console.WriteLine("You will live in the North Pole");
                    break;
                case 3:
                    Console.WriteLine("You will live in Cleveland");
                    break;
                default:
                    Console.WriteLine("You have too many sibling and will live with them for the rest of your life");
                    break;
            }

            switch (e)
            {
                case "R":
                    Console.WriteLine("");
                    break;
                case "O":
                    Console.WriteLine("");
                    break;
                case "Y":
                    Console.WriteLine("");
                    break;
                case "G":
                    Console.WriteLine("");
                    break;
                case "B":
                    Console.WriteLine("");
                    break;
                case "I":
                    Console.WriteLine("");
                    break;
                case "V":
                    Console.WriteLine("");
                    break;
                default:
                    Console.WriteLine();
                    break;


            }
        }
    }
}
