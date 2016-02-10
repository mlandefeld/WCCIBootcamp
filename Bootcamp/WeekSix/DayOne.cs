using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.WeekSix
{
    class DayOne
    {
        static void Main(string[] args)
        {
            /*
            StreamWriter writer = new StreamWriter("Answers.txt");


            using (writer)
            {
                //loop from 1-20 and write a number to the line
                for(int i = 1; i<=20; i++)
                {
                    writer.WriteLine(i);
                }
                
            }
            

            string fileName = @"Answers.txt";
            try
            {
                StreamReader reader = new StreamReader(fileName);
                Console.WriteLine("File {0} successfully opened.", fileName);
                Console.WriteLine("file contents:");
                using (reader)
                {
                    Console.WriteLine(reader.ReadToEnd());
                }
            }
            catch(FileNotFoundException)
            {
                Console.Error.WriteLine("Cannot find file {0}");
            }
            catch(DirectoryNotFoundException)
            {
                Console.Error.WriteLine("Invalid directory in the file path.");
            }
            catch(IOException)
            {
                Console.Error.WriteLine("Cannot open the file {0}", fileName);
            }
            
    */

            StreamWriter writer = new StreamWriter("Names.txt");
            List<string> list = new List<string>() { "Adam", "Ben", "Carly", "Dana", "Eric", "Fred" };
            list.Add("George");
            list.Add("Heather");
            list.Add("Ike");
            list.Add("Jake");

            list.Insert(0, "a");
            foreach (var name in list)
            {


                Console.WriteLine(name);
            }
            //list.Clear();
            //Console.WriteLine(list.Count);


            /*
               using (writer)
               {
                   foreach (var name in list)
                   {
                       writer.WriteLine(name);
                       Console.WriteLine(name);

                   }
               }

               StreamReader 




          int[] arr = new int[3];
           arr[0] = 2;
           arr[1] = 3;
           arr[2] = 5;
           List<int> list = arr.ToList();
           Console.WriteLine(list.Count);



           //why does this not work?
           string[] arr = new string[] { "a", "b", "c" };
           List<string> list = new List<int>(arr);
           Console.WriteLine(list);


           //how do you print items in array?
           int[] arr = new int[3];
           arr[0] = 2;
           arr[1] = 3;
           arr[2] = 5;
           List<int> list = new List<int>(arr);
           Console.WriteLine(list.Count);
           int[] convertedArray = list.ToArray();


           //practice slide in DataStructures

           List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
           list.Add(6);
           */

        }
    }
}
