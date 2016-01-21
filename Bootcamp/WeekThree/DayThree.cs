using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.WeekThree
{
    class DayThree
    {
        public void stringSlide()
        {
            Console.WriteLine("What is your name? ");
            string x = (Console.ReadLine());
            int name = x.Length;
            for (int i = 0; i < name; i++)
            {
                Console.WriteLine(x[i]);
            }
        }

        public void bellSound()
        {
            Console.WriteLine("\a \"North by Northwest\"");
            Console.Write("\t Margaret \n Landefeld");
        }

        public void upperLower()
        {
            string line = "A letter";

            string newLine ="";
            for (int i = 0; i <= line.Length - 1; i++)
            {
                if (Char.IsUpper(line[i]))
                {
                    newLine = newLine + char.ToLower(line[i]);
                } 

                else
                {
                    newLine = newLine + char.ToUpper(line[i]);

                }
                
            }
            Console.WriteLine(newLine);

        }

        public void equals()
        {
            string one = "Hello";
            string two = "hello";

            bool strEq2 = one.Equals(two, StringComparison.CurrentCultureIgnoreCase);
            Console.WriteLine(strEq2);
        }

        public void string2()
        {
            //Strings slide 23
            string nameOne = "Zabby";
            string nameTwo = "Maysdfsdfs";

           Console.WriteLine(nameOne.CompareTo(nameTwo));

        }

        public void ignoreCase()
        {
            Console.WriteLine(string.Compare("a", "A", true));
            
        }

        public void conCat()
        {
            string firstname = "John";
            string lastname = "Smith";
            string fullname = string.Concat(firstname, " ", lastname);

            int age = 28;
            string nameAndAge = "Name: " + fullname + "\nAge: " + age;

            Console.WriteLine(nameAndAge);
        }

        public void multTable()
        {

            int n = 12;

            for (int a = 1; a <= n; a++)
            {
                for (int b = 1; b <= n; b++)
                {
                    Console.Write(a * b + " ");
                }

                Console.WriteLine();
            }
        }

        public void passwords()
        {
            string pass1 = "PAssWord";
            string pass2 = "passWorD";
            string pass3 = "PAssWORD";

            if(pass1.ToUpper()=="PASSWORD" && pass2.ToUpper() == "PASSWORD" && pass3.ToUpper() == "PASSWORD")
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }

    }
}
