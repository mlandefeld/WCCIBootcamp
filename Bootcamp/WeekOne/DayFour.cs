using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.WeekOne
{
    class DayFour
    {
        public void dayFour()
        {
            /*
          // Week 1 day 4 project 1
           Console.WriteLine("Company Name: ");
           string coName = (Console.ReadLine());


           Console.WriteLine("Company Address: ");
           string coAdd= (Console.ReadLine());

           Console.WriteLine("Company Phone Number: ");
           string coNum = (Console.ReadLine());

           Console.WriteLine("Company Fax Number: ");
           string coFaxNum = (Console.ReadLine());

           Console.WriteLine("Company Website: ");
           string coWeb = (Console.ReadLine());

           Console.WriteLine("Manager First Name: ");
           string manFirstName = (Console.ReadLine());

           Console.WriteLine("Manager Last Name: ");
           string manLastName = (Console.ReadLine());

           Console.WriteLine("Manager Phone Number: ");
           string manPhoneNumber = (Console.ReadLine());


           Console.WriteLine("Company Name: " + coName);
           Console.WriteLine("Company Address: " + coAdd);
           Console.WriteLine("Company Phone Number: "+ coNum);
           Console.WriteLine("Company Fax Number: " + coFaxNum);
           Console.WriteLine("Company Website: " + coWeb);
           Console.WriteLine("Manager First Name: " + manFirstName);
           Console.WriteLine("Manager Last Name: " + manLastName);
           Console.WriteLine("Manager Phone Number: " + manPhoneNumber); 


           //Week 1 day 4 project 2

           Console.WriteLine("Write 5 different numbers!");
           string numOne = (Console.ReadLine());
           string numTwo = (Console.ReadLine());
           string numThree = (Console.ReadLine());
           string numFour = (Console.ReadLine());
           string numFive = (Console.ReadLine());


           int a = Convert.ToInt32(numOne);
           int b = Convert.ToInt32(numTwo);
           int c = Convert.ToInt32(numThree);
           int d = Convert.ToInt32(numFour);
           int e = Convert.ToInt32(numFive);

           Console.WriteLine(a + b + c + d + e);
           Console.ReadLine(); 

           //Week 1 day 4 project 3 

           Console.WriteLine("What is the radius?");
           string radius = (Console.ReadLine());
           double r = Convert.ToInt32(radius);

           double p = Math.PI * 2 * r;
           double a = Math.PI * r * r;

           Console.WriteLine("Radius: " + p);
           Console.WriteLine("Area: " + a);
           Console.ReadLine(); 

          // Week 1 day 4 project 4 

           Console.WriteLine("\"Welcome To We Can Code IT\"");
           Console.ReadLine();

          // Week 1 day 4 project 5  */


            Console.WriteLine("Manager First Name: ");
            string manFirstName = (Console.ReadLine());

            Console.WriteLine("Manager Last Name: ");
            string manLastName = (Console.ReadLine());

            Console.WriteLine("Manager Phone Number: ");
            string manPhoneNumber = (Console.ReadLine());

            string[] names = { manFirstName + manLastName };

            string[] numbers = { manPhoneNumber };

            Console.WriteLine("{0,-20} {1,-20} {2,-20}", "First Name", "Last Name", "Phone Number");
            Console.WriteLine("{0,-20} {1,-20} {2,20}", manFirstName, manLastName, manPhoneNumber);
            Console.ReadLine();
        }
    }
}
