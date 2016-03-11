using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.WeekTen
{
    class Day4
    {

        public void Exception()
        {
            try
            {
                Console.WriteLine("Enter a number: ");
                string numberText = Console.ReadLine();
                int number = int.Parse(numberText);
                Console.WriteLine("Your number is " + number);
            }
            catch (FormatException objectName)
            {
                Console.WriteLine("That is not a valid number");
            }

        }

        public void NewException()
        {
            try
            {
                Console.WriteLine("Enter a number: ");
                string numberText = Console.ReadLine();
                int number = int.Parse(numberText);
                Console.WriteLine("Your number is " + number);
            }
            catch
            {
                Console.WriteLine("hi");
            }
            finally
            {
                Console.WriteLine("Thanks for playing!");
            }

        }

        public void OtherException()
        {
            Console.Write("Enter a number: ");
            try
            {
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine(num * num);
            }
            catch(Exception)
            {
                Console.WriteLine("Oops! You need to enter a real number!");
            }

        }
    }
}
