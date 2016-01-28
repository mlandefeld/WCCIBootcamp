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
            //TODO: if all books are checked out, print "All resources are checked out"
            Resources.Resource[] available = this.resources.available();
            foreach (Resources.Resource resource in available)
            {
                /*
                if (Resource == 0)
                {
                    Console.WriteLine("\t\t\tAll resources are checked out");
                }
                else
                {
                    Console.WriteLine("\t\t\t" + resource.Title);
                }
                */
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
            //only validate if inputName is a student name. If student name does not exist, print "Error: Request Unavailable"
            //make sure each student can only check out three resources. 
            //If student already has three items, print: "[student name] has checked out the max number of resources"
            //make sure input ignores case
            //TODO: if all books are checked out, print "All resources are checked out"
            //loop back or continue if request unavailable so they can input it again. 


            /*    if(Resources.Collection == inputName)
               {

               }

          while (true)
           {
               if (validationType == isValidName)
               {
                   if (!isValidName(inputName))
                   {
                       Console.WriteLine("Your input didn't validate! Try again! ");
                       inputName = Console.ReadLine();
                   }
                   else
                   {
                       break;
                   }
               }
           } */
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
                        resource.checkout(student_id);
                        Console.WriteLine("\n\t\t" + inputName + " checked out " + inputTitle);
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
            //make sure student can only check in resource that they checked out. 
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
                    //make sure student can only check in resource that they checked out. 
                    if (!resource.isAvailable())
                    {
                        resource.checkin();
                        Console.WriteLine("\n\t\t" +inputName + " checked in " + inputTitle);
                    }
                    else
                    {
                        Console.WriteLine("\tError: Request Unavailable");
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
