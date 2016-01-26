using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Bootcamp.WeekFourProject
{
    class ProjectWeekOne
    {
        public void Project()
        {
            Console.WriteLine("Bootcamp Resources Checkout System");
            Console.WriteLine(""+
                "\tMenu: Enter a number to select option\n\t" + 
                "1.View Students\n\t" + 
                "2.View Available Resources\n\t" +
                "3.View Student Accounts\n\t" +
                "4.Checkout Items\n\t" +
                "5.Exit" +
                "");
            ResourceLibrary.Commands.viewStudents();
        }
        /*
        public string Menu(string input)
        {
            string[] menuItems = new string[6];
            menuItems[0] = "View Students";
            menuItems[1] = "View Available Resources";
            menuItems[2] = "View Student Accounts";
            menuItems[3] = "Checkout Items";
            menuItems[4] = "Return Item";
            menuItems[5] = "Exit";

            if (menuItems[0] == 1)
            {

            }
            else if ()


                case 1:
                    return getStudents;
                    break;
                case 2:
                    return getAvailableResources;
                    break;
                case 3:
                    return getStudentAccounts;
                    break;
                case 4:
                    return getCheckoutItem;
                    break;
                case 5:
                    return getReturnItem;
                    break;
                default:
                    return "You need to select an eligible menu number";
                    break;
            }

           
        }

        public string getInput(string question, string validationType)
        {
            Console.WriteLine(question);
            string input = (Console.ReadLine());
            while (true)
            {
                if (input.Equals("exit", StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.WriteLine("Thank you for using We Can Code IT's Checkout System!");
                    Environment.Exit(0);
                }
                if (input.Equals("exit", StringComparison.CurrentCultureIgnoreCase))
                {
                    throw new Exception();
                }
                if (validationType == "numbers")
                {
                    if (!Regex.IsMatch(input, @"^[a-zA-Z0-9]+$"))
                    {
                        Console.WriteLine("Your input didn't validate, try again!");
                        input = Console.ReadLine();
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    return "error!";
                }
            }

            return input;
        }
        public string Name(string student)
        {
            return student;
        }

        public string getStudentAccounts(string student)
        {
            return student; 
        }

        public string getCheckoutItem(string info)
        {
            Console.WriteLine("Student's Name: ");
            Console.WriteLine("Title of Checkout Item: ");

            return info;
        }

        public string getReturnItem()
        {
            Console.WriteLine("Student's Name: ");
            Console.WriteLine("Title of Checkout Item: ");

            if ()
            {

            }

            return "";
        }

    

        public string getStudents(string student)
        {


            string[] students = new string[6];
            students[0] = "A A";
            students[1] = "B B";
            students[2] = "C C";
            students[3] = "D D";
            students[4] = "E E";
            students[5] = "F F";

            //students = students.OrderBy(p => p.Name).ToArray();

            return student;

        }


        */
    }
}
