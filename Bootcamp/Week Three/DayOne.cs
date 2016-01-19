using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.WeekThree
{
    class DayOne
    {
        public void sumLine()
        {
            //string line = (Console.ReadLine());

            int sum = 0, n, i = 0;
            n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            do
            {
                Console.Write("Values[{0}", i + "]:");
                arr[i] = int.Parse(Console.ReadLine());
                sum += arr[i];
                i += 1;
            } while (i < n);
            Console.WriteLine("Total:{0}", sum);

        }

        public void dayOne()
        {
            /*

              //string[] myArray = { "Monday", "Tues", "Weds", "Thurs", "Fri" };
              // Console.WriteLine(myArray[0]);


              //Arrays, Slide 12 - use "New" keyword
              int[] studentAge = new int[5];
              studentAge[0] = 5;
              studentAge[1] =3;
              studentAge[2] =8;
              studentAge[3] =4;
              studentAge[4] =10;

              int min = studentAge.Min();
              Console.WriteLine(min); 

              // string[] daysOfWeek = { "Monday", "Tues", "Weds", "Thurs", "Fri", "Sat", "Sun" };
              //Console.WriteLine(daysOfWeek.Length);


              // string[] lastName = { "L", "a", "n", "d", "e", "f", "e", "l", "d" };
              // Console.WriteLine(lastName.Length);

             string[] firstName = { "M", "a", "r", "g", "a", "r", "e", "t" };
             Console.WriteLine(firstName[firstName.Length - 2]);


              string[] firstNames = { "Joe", "Bob", "Bill", "Tom", "Fred" };
              Console.WriteLine(Array.IndexOf(firstNames, "Bill"));


              //answer is 5
              int[] numbers = { 2, 5, 9, 4, 3, 4, 5, 6 };
              Console.WriteLine(Array.LastIndexOf(numbers, 4));


              int[] luckyNum = { 5, 10, 15, 20, 25, 30, 5, 10, 15, 20, 25, 30 };
              Console.WriteLine(Array.LastIndexOf(luckyNum, 10));

      


            string[] alphabet = { "a","b","c","d", "e" };
            Array.Reverse(alphabet);
            Console.WriteLine(alphabet[0]);

    */
        }

        public void num()
        {
            Console.WriteLine("What is your fav num?");
            string[] read = Console.ReadLine().Split();
            int[] numbers = new int[read.Length - 1];

            for (int i = 0; i < read.Length - 1; i++)
            {
                numbers[i] = int.Parse(read[i]);
            }

            Array.Sort(numbers);
            Console.WriteLine(numbers[0] + " " + numbers[numbers.Length - 1]);
        }

        public void names()
        {
            string[] names = { "Margaret", "Jane", "Stella", "May" };
            Array.Sort(names);
            Console.WriteLine(names[0] + " " + names[names.Length - 1]);
        }

        public void longestWord()
        {
            string line = "a bb ccc ddd eee";
            string[] arrline = line.Split();

            string longest = "";
            for (int i = 0; i < arrline.Length; i++)
            {
                if (longest.Length < arrline[i].Length)
                {
                    longest = arrline[i];
                }

            }

            Console.WriteLine(longest);
        } 

        public void penultimateWord()
        {
            string line = "a bb ccc ddd eee";
            string[] arrline = line.Split();

            Console.WriteLine(arrline[arrline.Length - 2]);
        }

        

    }
}
