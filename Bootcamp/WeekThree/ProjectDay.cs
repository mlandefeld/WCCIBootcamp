using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.WeekThree
{
    class ProjectDay
    {
        public string[] getInput()
        {
            Console.WriteLine("Welcome to the the Amazing and Incredibly Accurate Forture telling machine!");
            Console.WriteLine("If the game gets to be too much for you, enter \"Quit\" at any time, or if you wish to restart the game at any time, enter \"Restart\"");
            Console.WriteLine("What is your first name? ");
            string a = Console.ReadLine().ToLower();
            Console.WriteLine("What is your last name? ");
            string b = Console.ReadLine().ToLower();
            Console.WriteLine("How old are you? ");
            string c =(Console.ReadLine());
            Console.WriteLine("What month were you born? ");
            string d = Console.ReadLine().ToLower();
            Console.WriteLine("What is your favorite ROYGBIV color? Enter \"Help\" if you don't know what ROYGBIV is.");
            string e = Console.ReadLine().ToLower();
            while (true)
            {
                if (e == "help")
                {
                    Console.WriteLine("Choose: \nRed\nOrange\nYellow\nGreen\nBlue\nIndigo\nViolet");
                    Console.ReadLine();
                    continue;
                }
                else
                {
                    break;
                }

            }
            Console.WriteLine("How many siblings do you have? ");
            string f = (Console.ReadLine());

            string[] input = new string[6];
            input[0] = a;
            input[1] = b;
            input[2] = c;
            input[3] = d;
            input[4] = e;
            input[5] = f;

            return input;
        }

        public string getPredictedBankAmount(string firstname, string lastname, string birthMonth)
        {
            char firstLetter = birthMonth[0];
            char secondLetter = birthMonth[1];
            char thirdLetter = birthMonth[2];
            
            if(firstname.Contains(firstLetter) | lastname.Contains(firstLetter))
            {
                return "$10";
            }
            else if(firstname.Contains(secondLetter) | lastname.Contains(secondLetter))
            {
                return "$5000";
            }
            else if (firstname.Contains(thirdLetter) | lastname.Contains(thirdLetter))
            {
                return "$100,000,000";
            }
            else
            {
                return "$0";
            }
        }

        public void Project()
        {
            while (true)
            {

                string[] input = getInput();

                string bankAmount = getPredictedBankAmount(input[0], input[1], input[3]);

                
                if (c % 2 == 1)
                {
                    Console.WriteLine("10 years");
                }

                if (c % 2 == 0)
                {
                    Console.WriteLine("60 years");
                }

                if (f == 0)
                {
                    Console.WriteLine("New Zealand");
                }
                else if (f == 1)
                {
                    Console.WriteLine("Oklahoma");
                }

                else if (f == 2)
                {
                    Console.WriteLine("the North Pole");
                }

                else if (f >= 3)
                {
                    Console.WriteLine("Cleveland");
                }
                else
                {
                    Console.WriteLine("You need to enter a valid number!");
                }



                
                
                
                if (e == "red")
                {
                    Console.WriteLine("rowboat!");
                }
                else if (e == "orange")
                {
                    Console.WriteLine("skateboard!");
                }
                else if (e == "yellow")
                {
                    Console.WriteLine("motorcycle!");
                }
                else if (e == "green")
                {
                    Console.WriteLine("batmobile!");
                }
                else if (e == "blue")
                {
                    Console.WriteLine("parachute!");
                }
                else if (e == "indigo")
                {
                    Console.WriteLine("helicopter!");
                }
                else if (e == "violet")
                {
                    Console.WriteLine("ferarri!");
                }
                else
                {
                    Console.WriteLine("Oops! You need to enter a ROYGBIV color or \"Help\"!");
                }


                Console.WriteLine(a + " " + b + " will retire in "  +  c + " with " + d + " in the bank, a vacation home in " + e + " and a "+ f);

                Console.WriteLine("Would you like to try again? \"Yes\" or \"No\"");
                string g = Console.ReadLine().ToLower();
               

                if (g == "no")
                {
                    Console.WriteLine("Thank you for playing!");
                    break;
                }
                else if (g == "yes")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("You chose wrong. Good bye!");
                    break;
                }
                

            }
       
        }
       
    }
}
