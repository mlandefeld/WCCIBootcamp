using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.WeekFourProject.ResourceLibrary
{
    class Commands
    {
        public static void viewStudents()
        {
            Students.Collection students = new Students.Collection();
            foreach(Students.Student student in students)
            {
                Console.WriteLine(student.Name);
            }
        }

        public static void viewAvailableResources()
        {
            Resources.Collection collection = new Resources.Collection();
            foreach(Resources.Resource resource in collection)
            {
                Console.WriteLine(resource.Title);
            }
        }

        public static void viewStudentAccounts()
        {

        }

        public static void checkoutItem()
        {

        }

        public static void returnItem()
        {

        }

        public static void exit()
        {
            Console.Clear();
            Console.WriteLine("Thank you for using We Can Code IT's Bootcamp Library Checkout System!");
            Environment.Exit(0);
        }
    }
}
