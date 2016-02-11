using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp
{
    class Program
    {
        static void Main(string[] args)
        {

            //Week Two Day One 
            //WeekTwo.DayOne WeekTwoDayOne = new WeekTwo.DayOne();
            //WeekTwoDayOne.old();

            //Week Two Day Three - Fizz Buzz
            //WeekTwo.DayThree WeekTwoDayThree = new WeekTwo.DayThree();
            //WeekTwoDayThree.fizzBuzz();

            //Week Two Day Three - Factorial Problem
            //WeekTwoDayThree.multiplyRange();

            //Week Two Day Four - 
            // WeekTwo.DayFour WeekTwoDayFour = new WeekTwo.DayFour();
            //WeekTwoDayFour.dayFour();

            //Week Three Day One - 
            // WeekThree.DayOne WeekThreeDayOne = new WeekThree.DayOne();
            // WeekThreeDayOne.num();

            //Week Three Day Two - 
            //WeekThree.DayTwo WeekThreeDayTwo = new WeekThree.DayTwo();
            //WeekThreeDayTwo.sumOfDigits();

            //Week Three Day Three - 
            //WeekThree.DayThree WeekThreeDayThree = new WeekThree.DayThree();
            //WeekThreeDayThree.upperLower();

            //Week Three Day Four - 
            /*WeekThree.ProjectDay WeekThreeProjectDay = new WeekThree.ProjectDay();
              while (true)
              {
                  try
                  {
                      WeekThreeProjectDay.Project();
                      break;
                  }
                  catch (Exception e)
                  {

                  }
              }
              */

            //Week Four Project Week - 
            //WeekFourProject.ProjectWeekOne WeekFourProjectProjectWeekOne = new WeekFourProject.ProjectWeekOne();
            //WeekFourProjectProjectWeekOne.Project();

            //Week Five Day 1 and 2 -
            //WeekFive.Day1and2 WeekFiveDay1and2 = new WeekFive.Day1and2();
            //WeekFiveDay1and2.validateEmail();

            //Week Five Day Three - 
            // WeekFive.DayThree WeekFiveDayThree = new WeekFive.DayThree();
            // WeekFiveDayThree.Add();

            //WeekFive Day Four - 
            //WeekFive.DayFour WeekFiveDayFour = new WeekFive.DayFour();
            //WeekFiveDayFour.ReadMore();

            //WeekSix Day Three - 
            WeekSix.DayThree WeekSixDayThree = new WeekSix.DayThree();
            WeekSixDayThree.IdDictionary();

         //Main   
        }




        /*

        static string[] ReturnInt(string[] newInt)
        {
            int[] test = int.Parse(newInt);
            for (int i = 0; i > 1; i++)
            {

            }


            int[] x = int.Parse(newInt);
            return intArray;
        }




        static string ReverseNum(string test)
        {
            StringBuilder newnum = new StringBuilder();
            for (int i = test.Length - 1; i >= 0; i--)
            {
                newnum.Append(test[i]);
            }
            string newString = newnum.ToString();
            return newString;

        }



      
    static void Main()
    {
       string text = "EM edit";
        //string reversed = ReverseText(text);
        //Console.WriteLine(reversed);
        string caps = ExtractCapitals(text);
        Console.WriteLine(caps);
    }

    static string ExtractCapitals(string str)
    {
        StringBuilder result = new StringBuilder();
        for(int i = 0; i<str.Length;i++)
        {
            char ch = str[i];
            if(char.IsUpper(ch))
            {
                result.Append(ch);
            }
        }
        return result.ToString();
    }
    */
    }
}
