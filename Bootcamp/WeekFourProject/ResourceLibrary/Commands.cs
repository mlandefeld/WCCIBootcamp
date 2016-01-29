using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Bootcamp.WeekFourProject.ResourceLibrary
{
    //TODO: Print "Nothing checked out" for view student accounts when student has none checked out
    //TODO: Validate Resources input, which should also ignore case. 
    //TODO: for checkout item, if student tries to check out an already checked out item, loop the error so it can ask for another title
    //TODO: check methods for zeroCheckedOut and hasTitle
    //TODO: for view student account, if nothing checked ouot to student say "No Resources are checked out to this student."
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
                Console.WriteLine("\t\t\t" + student.Name);
            }
        }

        public void viewAvailableResources()
        {
            Resources.Resource[] available = this.resources.available();
            if(available.Length == 0)
            {
                Console.WriteLine("\t\t\tAll resources are checked out");
            }
            else
            {
                foreach (Resources.Resource resource in available)
                {
                    Console.WriteLine("\t\t\t" + resource.Title);
                }
            }
        }

        /*
        public void viewStudentAccounts()
        {
            Console.Write("\tEnter Student Name: ");
            string inputName = Console.ReadLine();

            int student_id = 0;

            while (true)
            {
                if (this.students.hasName(inputName))
                {
                    break;
                }
                else
                {
                    Console.Write("Error: Request Unavailable");
                    inputName = Console.ReadLine();
                }

            }

            
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
                if(this.resources.zeroCheckedOut(student_id))
                {
                    Console.WriteLine("\n\t\t\tNo Resources are checked out to this student.");
                }
                else
                {
                    
                    Console.WriteLine("\n\t\t\t" + resource.Title);
                }
                
            }
    */


        //if no student accounts are printed say "No Resources are checked out to this student." see above
        public void viewStudentAccounts()
        {
            Console.Write("\tEnter Student Name: ");
            string inputName = Console.ReadLine();

            int student_id = 0;
            /*
               while (true)
            {
                    if (this.students.hasName(inputName))
                    {
                    break;
                    }
                    else
                    {
                        Console.WriteLine("Error: Request Unavailable");
                        inputName = Console.ReadLine();
                    }

            }
            */

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
                Console.WriteLine("\n\t\t" + resource.Title);
            }
        }


        //validate resources input
        public void checkoutItem() 
        {
            Console.Write("\tEnter Student Name: ");
            string inputName = Console.ReadLine();

            while (true)
            {
                    if (this.students.hasName(inputName))
                    {
                    break;
                    }
                    else
                    {
                        Console.WriteLine("Error: Request Unavailable");
                        inputName = Console.ReadLine();
                    }

            }

            Console.Write("\tEnter Title of Resource: ");
            string inputTitle = Console.ReadLine();
            /*
            while (true)
            {
                if (this.resources.hasTitle(inputTitle))
                {
                    
                }
                else
                {
                    Console.WriteLine("Error: Request Unavailable");
                    inputName = Console.ReadLine();
                }
                break;

            }
            */
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
                if(inputTitle == resource.Title)
                {
                    if(resource.isAvailable())
                    {
                        if(this.resources.hasLessThanThree(student_id))
                        {
                            resource.checkout(student_id);
                            Console.WriteLine("\n\t\t" + inputName + " checked out " + inputTitle + ".");
                        }
                        else
                        {
                            Console.WriteLine(inputName + " has checked out the max number of resources.");
                        }

                    }
                    else
                    {
                        Console.WriteLine("\tError: Request Unavailable");
                    }
                    
                }
            }
            
        }

        //make sure resource input is valid and returns error if not 
        public void returnItem()
        {
            Console.Write("\tEnter Student Name: ");
            string inputName = Console.ReadLine();

            while (true)
            {
                if (this.students.hasName(inputName))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Error: Request Unavailable");
                    inputName = Console.ReadLine();
                }

            }
            
            Console.Write("\tEnter Title of Resource to Return: ");
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
                    
                    if (resource.isCheckedOutBy(student_id))
                    {
                        resource.checkin();
                        Console.WriteLine("\n\t\t" +inputName + " returned " + inputTitle + ".");
                    }
                    else
                    {
                        Console.WriteLine("\n\tError: Request Unavailable");
                    }

                }
            }
        }

        public static void exit()
        {
            Console.Clear();
            Console.WriteLine("\tThank you for using We Can Code IT's Bootcamp Library Checkout System!");
            Environment.Exit(0);
        }
    }
}
