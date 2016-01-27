using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.WeekFourProject.ResourceLibrary
{
    class Commands
    {
        public Students.Collection students;
        public Resources.Collection resources;

        public Commands()
        {
            students = new Students.Collection();
            resources = new Resources.Collection();
        }



        public void viewStudents()
        {
            foreach (Students.Student student in this.students)
            {
                Console.WriteLine(student.Name);
            }
        }

        public void viewAvailableResources()
        {
            Resources.Resource[] available = this.resources.available();
            foreach (Resources.Resource resource in available)
            {
                Console.WriteLine(resource.Title);
            }
        }

        public void viewStudentAccounts()
        {
            Console.WriteLine("Enter Student Name: ");
            string inputName = Console.ReadLine();

            int student_id = 0;

            foreach (Students.Student student in this.students)
            {
                if (inputName == student.Name)
                {
                    student_id = student.Id;
                }
            }

            Resources.Resource[] resources = this.resources.forStudentId(student_id);
            foreach (Resources.Resource resource in resources)
            {
                Console.WriteLine(resource.Title);
            }


        }

        public void checkoutItem()
        {
            Console.WriteLine("Enter Student Name: ");
            string inputName = Console.ReadLine();
            Console.WriteLine("Enter Title of Resource: ");
            string inputTitle = Console.ReadLine();

            int student_id = 0;

            foreach (Students.Student student in this.students)
            {
                if(inputName == student.Name)
                {
                    student_id = student.Id;
                }
            }
            
            foreach (Resources.Resource resource in this.resources)
            {
                if(inputTitle == resource.Title)
                {
                    if(resource.isAvailable())
                    {
                        resource.checkout(student_id);
                        Console.WriteLine(inputName + " checked out " + inputTitle);
                    }
                    else
                    {
                        Console.WriteLine("Error: Request Unavailable");
                    }
                    
                }
            }

            
        }

        public void returnItem()
        {
            Console.WriteLine("Enter Student Name: ");
            string inputName = Console.ReadLine();
            Console.WriteLine("Enter Title of Resource to Return: ");
            string inputTitle = Console.ReadLine();

            int student_id = 0;

            foreach (Students.Student student in this.students)
            {
                if (inputName == student.Name)
                {
                    student_id = student.Id;
                }
            }

            foreach (Resources.Resource resource in this.resources)
            {
                if (inputTitle == resource.Title)
                {
                    if (!resource.isAvailable())
                    {
                        resource.checkin();
                        Console.WriteLine(inputName + " checked in " + inputTitle);
                    }
                    else
                    {
                        Console.WriteLine("Error: Request Unavailable");
                    }

                }
            }
        }

        public static void exit()
        {
            Console.Clear();
            Console.WriteLine("Thank you for using We Can Code IT's Bootcamp Library Checkout System!");
            Environment.Exit(0);
        }
    }
}
