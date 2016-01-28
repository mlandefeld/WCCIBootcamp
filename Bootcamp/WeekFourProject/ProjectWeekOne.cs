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
        //TODO: student can only check out less than three books. ignore case, validate input
        
        public void Project()
        {
            if (Console.BackgroundColor == ConsoleColor.Black)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
            }
            Console.Title = "Bootcamp Library Checkout System";
            string s = "Bootcamp Library Checkout System";
            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
            Console.WriteLine(s);

            string menu = (""+
                "\n\tMenu: Enter a number to select the corresponding option\n\t" +
                "1.View Students\n\t" + 
                "2.View Available Resources\n\t" +
                "3.View Student Accounts\n\t" +
                "4.Checkout Items\n\t" +
                "5.Return Items\n\t" +
                "6.Exit" +
                "");
            Console.WriteLine(menu);
           string input = Console.ReadLine();
            ResourceLibrary.Commands commandInterface = new ResourceLibrary.Commands();
            while (true)
            {
                if (input.Equals("exit", StringComparison.CurrentCultureIgnoreCase))
                {
                    ResourceLibrary.Commands.exit();
                }
                else if (input == "1")
                {
                    Console.Clear();
                    string one = "Bootcamp Library Checkout System \n\n\t\t\tList of Students:\n";
                    Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
                    Console.WriteLine(one);
                    commandInterface.viewStudents();
                    Console.WriteLine(menu);
                    input = Console.ReadLine();
                    continue;
                    
                }
                else if (input == "2")
                {
                    Console.Clear();
                    string two = "Bootcamp Library Checkout System \n\n\t\t\tList of Available Resources:\n";
                    Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
                    Console.WriteLine(two);
                    commandInterface.viewAvailableResources();
                    Console.WriteLine(menu);
                    input = Console.ReadLine();
                    continue;
                }
                else if (input == "3")
                {
                    Console.Clear();
                    string three = "Bootcamp Library Checkout System \n\n\t\t\tView Student Accounts:\n";
                    Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
                    Console.WriteLine(three);
                    commandInterface.viewStudentAccounts();
                    Console.WriteLine(menu);
                    input = Console.ReadLine();
                    continue;
                }
                else if (input == "4")
                {
                    Console.Clear();
                    string four = "Bootcamp Library Checkout System \n\n\t\t\tCheckout Item:\n";
                    Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
                    Console.WriteLine(four);
                    commandInterface.checkoutItem();
                    Console.WriteLine(menu);
                    input = Console.ReadLine();
                    continue;
                }
                else if (input == "5")
                {
                    Console.Clear();
                    string five = "Bootcamp Library Checkout System \n\n\t\t\tReturn Item:\n";
                    Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
                    Console.WriteLine(five);
                    commandInterface.returnItem();
                    Console.WriteLine(menu);
                    input = Console.ReadLine();
                    continue;
                }
                else if(input == "6")
                {
                    ResourceLibrary.Commands.exit();
                }
                else
                {
                    Console.WriteLine("Oops! You need to enter a vaild menu number!");
                    input = Console.ReadLine();
                }
            }

        }

        public bool isValidName(string name)
        {
            string[] names = new string[6];
            names[0] = "Susy Student";
            names[1] = "Chris Collins";
            names[2] = "Amy Apple";
            names[3] = "Matt Martins";
            names[4] = "Betty Blue";
            names[5] = "Joe Jones";


            if (names.Contains(name.ToLower()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool isValidTitle(string title)
        {
            string[] titles = new string[11];
            titles[0] = "C#";
            titles[1] = "ASP.NET MVC 5";
            titles[2] = "The C# Player's Guide#";
            titles[3] = "Eloquent JavaScript";
            titles[4] = "SQL Queries";
            titles[5] = "Javascript for Kids";
            titles[6] = "Database Design";
            titles[7] = "C# 5.0 for Dummies";
            titles[8] = "Essential C# 6.0";
            titles[9] = "Assembly Language Tutor";
            titles[10] = "Mastering C Pointers";

            if (titles.Contains(title.ToLower()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*
        public string getInput(string question, string validationType)
    {
        
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
