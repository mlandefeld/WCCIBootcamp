using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.WeekSix
{
    class DayThree
    {
        public void Dictionary()
        {
            /*
            Dictionary<string, int> people = new Dictionary<string, int>();
            people.Add("Emmy", 4);
            people.Add("Abby", 10);
            people.Add("Cathy", 45);
            people.Add("Laffy", 13);
            people.Add("Daffy", 60);
            
            */
            //or

            Dictionary<string, int> people = new Dictionary<string, int>()
            {
                { "Emmy", 4},
                { "Abby", 10 },
                { "Cathy", 45},
                { "Laffy", 13},
                { "Daffy", 60 },
            };
            //two ways of checking if a key exists
            if(people.ContainsKey("Abby"))
            {
                int value = people["Abby"];
                Console.WriteLine(value);
            }

            int value2;
            if (people.TryGetValue("Laffy", out value2))
            {
                Console.WriteLine(value2);
            }

            //print out all keys and values
            foreach (KeyValuePair<string, int> pair in people)
            {
                Console.WriteLine("Key: " + pair.Key + " Value: " + pair.Value);
            }

            //or 

            foreach(string key in people.Keys)
            {
                Console.WriteLine("Key: " + key);
            }
            foreach(int value in people.Values)
            {
                Console.WriteLine("Value: " + value);
            }

            //get dictionary size
            Console.WriteLine(people.Count);
            //or 
            Console.WriteLine(people.Count());
        }


        //dictionaries ppt slide 12. Review
        public void NameAgeDictionary()
        {
            Dictionary<string, int> nameAge = new Dictionary<string, int>();

            while (true)
            {
                Console.WriteLine("Give me one name! ");
                string name = Console.ReadLine();
                Console.WriteLine("Give me one age! ");
                int age = int.Parse(Console.ReadLine());
                /*
                if (Console.ReadLine() == "")
                {
                    break;
                }
                else
                {
                    continue;
                }
                */

                nameAge.Add(name, age);

               
            }

            Console.WriteLine("Write a name to find out their age!");
            string find = Console.ReadLine();
            Console.WriteLine(nameAge[find]);

              
        }

        //dictionaries ppt slide 17
        public void IdDictionary()
        {
            Dictionary<int, string> idTitle = new Dictionary<int, string>();


            Console.WriteLine("Add a book ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Add a book title: ");
            string title = Console.ReadLine();

            idTitle.Add(id, title);

            foreach (int key in idTitle.Keys)
            {
                Console.WriteLine("Book ID: " + key);
            }
            foreach (string value in idTitle.Values)
            {
                Console.WriteLine("Book Title: " + value);
            }

        }
    }
}
