using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.WeekTwo
{
    class DayTwo
    {
        public void Statements()
        {
            //Conditional Statements Slide 39
            /*
                        int num = Convert.ToInt32(Console.ReadLine());

                        switch (num)
                        {
                            case 0:
                                Console.WriteLine("Cat");
                                break;

                            case 1:
                                Console.WriteLine("Dog");
                                break;

                            case 2:
                                Console.WriteLine("Fish");
                                break;

                            case 3:
                                Console.WriteLine("Bird");
                                break;
                            case 4:
                                Console.WriteLine("Snake");
                                break;
                            case 5:
                                Console.WriteLine("Rabbit");
                                break;
                            case 6:
                                Console.WriteLine("Mouse");
                                break;
                            case 7:
                                Console.WriteLine("Monkey");
                                break;
                            case 8:
                                Console.WriteLine("Elephant");
                                break;
                            case 9:
                                Console.WriteLine("Lion");
                                break;

                            default:
                                Console.WriteLine("Can't use this number");
                                break;
                        }   
                                        
            //conditional statements slide 40
            int a = Convert.ToInt32(Console.WriteLine());
            int b = Convert.ToInt32(Console.WriteLine());

    */

            //Code Eval Compare Points
            //first two integers are coordinates X,Y and you have to find the second position X,Y as relative to the first coordinates


            string line = "0 0 0 0";
            string[] separate = line.Split(new char[] { ' ' }); //split up the 4 integers between the spaces

            int currentX = Convert.ToInt32(separate[0]);
            int currentY = Convert.ToInt32(separate[1]);
            int overlookX = Convert.ToInt32(separate[2]);
            int overlookY = Convert.ToInt32(separate[3]);

            int xdiff = overlookX - currentX; //in order to find coordinates make directions based on the difference of the coordinates
            int ydiff = overlookY - currentY;

            if (xdiff == 0 && ydiff > 0)
            {
                Console.WriteLine("N");
            }

            else if (xdiff > 0 && ydiff > 0)
            {
                Console.WriteLine("NE");
            }

            else if (xdiff > 0 && ydiff == 0)
            {
                Console.WriteLine("E");
            }

            else if (xdiff > 0 && ydiff < 0)
            {
                Console.WriteLine("SE");
            }

            else if (xdiff == 0 && ydiff < 0)
            {
                Console.WriteLine("S");
            }

            else if (xdiff < 0 && ydiff < 0)
            {
                Console.WriteLine("SW");
            }

            else if (xdiff < 0 && ydiff == 0)
            {
                Console.WriteLine("W");
            }

            else if (xdiff < 0 && ydiff > 0)
            {
                Console.WriteLine("NW");
            }

            else
            {
                Console.WriteLine("here");
            }
        }
    }
}
