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
            while (true)
            {
                Console.WriteLine("Welcome to the the Amazing and Incredibly Accurate Forture telling machine!");
                Console.WriteLine("If the game gets to be too much for you, enter \"Quit\" at any time, or if you wish to restart the game at any time, enter \"Restart\"");
                Console.WriteLine("What is your first name? ");
                string a = Console.ReadLine().ToLower();
                Console.WriteLine("What is your last name? ");
                string b = Console.ReadLine().ToLower();
                Console.WriteLine("How old are you? ");
                int c = int.Parse(Console.ReadLine());
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
                int f = int.Parse(Console.ReadLine());

                
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


                string[] months = new string[11];
                months[0] = "january";
                months[1] = "february";
                months[2] = "march";
                months[3] = "april";
                months[4] = "may";
                months[5] = "june";
                months[6] = "july";
                months[7] = "august";
                months[8] = "september";
                months[9] = "october";
                months[10] = "november";
                months[11] = "december";

                int x;
                for (int i = 0; i < 12; i++)
                {
                    if (a.Contains(i[0]) | b.Contains(i[0]))
                    {
                        Console.WriteLine("$5");
                    }
                }

            /*

                if (d == "january")
                {
                    if (a.Contains("j") | b.Contains("j"))
                    {
                        Console.WriteLine("$5");
                    }
                    else if (a.Contains("a") | b.Contains("a"))
                    {
                        Console.WriteLine("$100,000,000");
                    }
                    else if (a.Contains("n") | b.Contains("n"))
                    {
                        Console.WriteLine("$1000");
                    }
                    else
                    {
                        Console.WriteLine("$0");
                    }

                }
                else if (d == "february")
                {
                    if (a.Contains("f") | b.Contains("f"))
                    {
                        Console.WriteLine("$5");
                    }
                    else if (a.Contains("e") | b.Contains("e"))
                    {
                        Console.WriteLine("$100,000,000");
                    }
                    else if (a.Contains("b") | b.Contains("b"))
                    {
                        Console.WriteLine("$1000");
                    }
                    else
                    {
                        Console.WriteLine("$0");
                    }
                }
                else if (d == "march")
                {
                    if (a.Contains("m") | b.Contains("m"))
                    {
                        Console.WriteLine("$5");
                    }
                    else if (a.Contains("a") | b.Contains("a"))
                    {
                        Console.WriteLine("$100,000,000");
                    }
                    else if (a.Contains("r") | b.Contains("r"))
                    {
                        Console.WriteLine("$1000");
                    }
                    else
                    {
                        Console.WriteLine("$0");
                    }
                }
                else if (d == "april")
                {
                    if (a.Contains("a") | b.Contains("a"))
                    {
                        Console.WriteLine("$5");
                    }
                    else if (a.Contains("p") | b.Contains("p"))
                    {
                        Console.WriteLine("$100,000,000");
                    }
                    else if (a.Contains("r") | b.Contains("r"))
                    {
                        Console.WriteLine("$1000");
                    }
                    else
                    {
                        Console.WriteLine("$0");
                    }
                }
                else if (d == "may")
                {
                    if (a.Contains("m") | b.Contains("m"))
                    {
                        Console.WriteLine("$5");
                    }
                    else if (a.Contains("a") | b.Contains("a"))
                    {
                        Console.WriteLine("$100,000,000");
                    }
                    else if (a.Contains("y") | b.Contains("y"))
                    {
                        Console.WriteLine("$1000");
                    }
                    else
                    {
                        Console.WriteLine("$0");
                    }
                }
                else if (d == "june")
                {
                    if (a.Contains("j") | b.Contains("j"))
                    {
                        Console.WriteLine("$5");
                    }
                    else if (a.Contains("u") | b.Contains("u"))
                    {
                        Console.WriteLine("$100,000,000");
                    }
                    else if (a.Contains("n") | b.Contains("n"))
                    {
                        Console.WriteLine("$1000");
                    }
                    else
                    {
                        Console.WriteLine("$0");
                    }
                }
                else if (d == "july")
                {
                    if (a.Contains("j") | b.Contains("j"))
                    {
                        Console.WriteLine("$5");
                    }
                    else if (a.Contains("u") | b.Contains("u"))
                    {
                        Console.WriteLine("$100,000,000");
                    }
                    else if (a.Contains("l") | b.Contains("l"))
                    {
                        Console.WriteLine("$1000");
                    }
                    else
                    {
                        Console.WriteLine("$0");
                    }
                }
                else if (d == "august")
                {
                    if (a.Contains("a") | b.Contains("a"))
                    {
                        Console.WriteLine("$5");
                    }
                    else if (a.Contains("u") | b.Contains("u"))
                    {
                        Console.WriteLine("$100,000,000");
                    }
                    else if (a.Contains("g") | b.Contains("g"))
                    {
                        Console.WriteLine("$1000");
                    }
                    else
                    {
                        Console.WriteLine("$0");
                    }
                }
                else if (d == "september")
                {
                    if (a.Contains("s") | b.Contains("s"))
                    {
                        Console.WriteLine("$5");
                    }
                    else if (a.Contains("e") | b.Contains("e"))
                    {
                        Console.WriteLine("$100,000,000");
                    }
                    else if (a.Contains("p") | b.Contains("p"))
                    {
                        Console.WriteLine("$1000");
                    }
                    else
                    {
                        Console.WriteLine("$0");
                    }
                }
                else if (d == "october")
                {
                    if (a.Contains("o") | b.Contains("o"))
                    {
                        Console.WriteLine("$5");
                    }
                    else if (a.Contains("c") | b.Contains("c"))
                    {
                        Console.WriteLine("$100,000,000");
                    }
                    else if (a.Contains("t") | b.Contains("t"))
                    {
                        Console.WriteLine("$1000");
                    }
                    else
                    {
                        Console.WriteLine("$0");
                    }
                }
                else if (d == "november")
                {
                    if (a.Contains("n") | b.Contains("n"))
                    {
                        Console.WriteLine("$5");
                    }
                    else if (a.Contains("o") | b.Contains("o"))
                    {
                        Console.WriteLine("$100,000,000");
                    }
                    else if (a.Contains("v") | b.Contains("v"))
                    {
                        Console.WriteLine("$1000");
                    }
                    else
                    {
                        Console.WriteLine("$0");
                    }
                }
                else if (d == "december")
                {
                    if (a.Contains("d") | b.Contains("d"))
                    {
                        Console.WriteLine("$5");
                    }
                    else if (a.Contains("e") | b.Contains("e"))
                    {
                        Console.WriteLine("$100,000,000");
                    }
                    else if (a.Contains("c") | b.Contains("c"))
                    {
                        Console.WriteLine("$1000");
                    }
                    else
                    {
                        Console.WriteLine("$0");
                    }
                }
                */
                
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
