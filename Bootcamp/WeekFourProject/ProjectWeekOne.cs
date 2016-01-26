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
            Console.WriteLine("Menu: \nView Students\nView Available Resources\nView Student Accounts\nCheckout Items\nExit");
        }

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

        public string getAvailableResources(string resources)
        {
            string[] books = new string[11];
            books[0] = "C#";
            books[1] = "ASP.NET MVC 5";
            books[2] = "The C# Player's Guide";
            books[3] = "Eloquent JavaScript";
            books[4] = "SQL Queries";
            books[5] = "Javascript for Kids";
            books[6] = "Database Design";
            books[7] = "C# 5.0 for Dummies";
            books[8] = "Essential C# 6.0";
            books[9] = "Assembly Language Tutor";
            books[10] = "Mastering C Pointers";

            foreach(var i in books)
            {
                Console.WriteLine(i.ToString());
            }
            
            Array.Sort<string>(books);
            foreach (var c in books)
            {
                return c;
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



    }
}
