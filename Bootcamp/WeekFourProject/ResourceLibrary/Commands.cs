using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

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

        public void viewStudentAccounts()
        {
            Console.WriteLine("\tEnter Student Name: ");
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

        public void checkoutItem() //(string validationType, string isValidName)
        {
            Console.Write("\tEnter Student Name: ");
            string inputName = Console.ReadLine();
            
            //make sure input ignores case
            //loop back or continue if request unavailable so they can input it again. 
            //upper case first index of first and last name

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
                

        public void returnItem()
        {
            Console.Write("\tEnter Student Name: ");
            string inputName = Console.ReadLine();
            //only validate if inputName is a student name. If student name does not exist, print "Error: Request Unavailable"
            //make sure input ignores case
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
                        Console.WriteLine("\n\t\t" +inputName + " checked in " + inputTitle + ".");
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
