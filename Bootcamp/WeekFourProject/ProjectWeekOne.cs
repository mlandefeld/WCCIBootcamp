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
            if (Console.BackgroundColor == ConsoleColor.Black)
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Clear();
            }
            Console.Title = "Bootcamp Library Checkout System";
            string s = "Bootcamp Library Checkout System";
            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
            Console.WriteLine(s);

            string menu = (""+
                "\n\tMenu: Enter a number to select the corresponding option\n\t" +
                "(Type \"exit\" at any time to end the program)\n\t" +
                "1.View Students\n\t" + 
                "2.View Available Resources\n\t" +
                "3.View Student Accounts\n\t" +
                "4.Checkout Items\n\t" +
                "5.Return Items\n\t" +
                "6.Exit" +
                "");
            Console.WriteLine(menu);
           string input = Console.ReadLine();

            while (true)
            {
                if (input.Equals("exit", StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.Clear();
                    Console.WriteLine("Thank you for using We Can Code IT's Bootcamp Library Checkout System!");
                    Environment.Exit(0);
                }
                else if (input == "1")
                {
                    Console.Clear();
                    string one = "List of Students:\n";
                    Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
                    Console.WriteLine(one);
                    Console.WriteLine(menu);
                    input = Console.ReadLine();
                    continue;
                    
                }
                else if (input == "2")
                {
                    Console.Clear();
                    string two = "List of Available Resources:\n";
                    Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
                    Console.WriteLine(two);
                    Console.WriteLine(menu);
                    input = Console.ReadLine();
                    continue;
                }
                else if (input == "3")
                {
                    Console.Clear();
                    string three = "View Student Accounts:\n";
                    Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
                    Console.WriteLine(three);
                    Console.WriteLine(menu);
                    input = Console.ReadLine();
                    continue;
                }
                else if (input == "4")
                {
                    Console.Clear();
                    string four = "Checkout Item:\n";
                    Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
                    Console.WriteLine(four);
                    Console.WriteLine(menu);
                    input = Console.ReadLine();
                    continue;
                }
                else if (input == "5")
                {
                    Console.Clear();
                    string five = "Return Item:\n";
                    Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
                    Console.WriteLine(five);
                    Console.WriteLine(menu);
                    input = Console.ReadLine();
                    continue;
                }
                else if(input == "6")
                {
                    Console.Clear();
                    Console.WriteLine("Thank you for using We Can Code IT's Bootcamp Library Checkout System!");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Oops! You need to enter a vaild menu number!");
                    input = Console.ReadLine();
                }
            }

        }

        /*
        //http://www.c-sharpcorner.com/UploadFile/dacca2/many-to-one-relationship-in-C-Sharp-class/
        public void Main(string[] args)
        {
            Student s = new Student();
            s.StudentName = "Susy Studen";

            Resource a = new Resource();
            a.ResourceName = "C#";
            a.GetSetShop = s;

            Customer b = new Customer();
            b.ResourceName = "BookBook";
            b.GetSetShop = s;

            a.Print();
            b.Print();
            Console.ReadLine();
        }


        
    public void Main(string[] args)
    {

        List<Students> T = new List<Student>();
        Student s1 = new Student();
        s1.SName = "Susy Student";
        s1.subject = "Math";
        S.Add(s1);

        s1 = new Student();
        s1.SName = "Bob Builder";
        s1.subject = "computer";
        S.Add(s1);

        Book b = new Book();
        b.BName = "c#";
        b.getsetStudent = S;
        b.Print();
        Console.ReadLine();
    }

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
