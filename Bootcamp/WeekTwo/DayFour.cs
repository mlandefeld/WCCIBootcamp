using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.WeekTwo
{
    class DayFour
    {
        public void dayFour()
        {
            /*
           Console.WriteLine("Enter a number");
           int firstNum = int.Parse(Console.ReadLine());

           Console.WriteLine("enter another number");
           int secondNum = int.Parse(Console.ReadLine());

           int result = 1;
           for (int i = 0; i < firstNum; i++)
           {
               result += secondNum;
           }
           Console.WriteLine(result);
       }


           int n = int.Parse(Console.ReadLine());
           int sum = 0;

           for(int i = 1; i<= n; i ++)
           {
               if (i % 6 == 0)
               {
                   continue;
               }

               else if (i % 2 ==0)
               {
                   sum += i;
               }

           }
           Console.WriteLine("sum=" + sum);



           int n = int.Parse(Console.ReadLine());

           for(int row=1; row <=n; row++)
           {
               for(int col=1;col<=row; col++)
               {
                   Console.Write(col + " ");
               }
               Console.WriteLine();
           }


           //Write a program that prints a multiplication table (5 x 5, for example) using a nested loops. Loops slide 42

           int n = int.Parse(Console.ReadLine());

           for(int a = 1; a <= n; a++)
           {
               for(int b = 1; b<= n; b++ )
               {
                   Console.Write(a * b + " ");
               }

               Console.WriteLine();
           }


           //Write a program that prints on the console the numbers from 1 to n (get from user) which are NOT divisible by 3 and 7 simultaneously. 
           // Which loop type is best? loops slide 44

           int n = int.Parse(Console.ReadLine());

           for (int i = 0; i<= n; i++)
           {
               if ( i % 7 == 0 && i % 3 == 0 )
               {
                   continue;

               }

               Console.WriteLine(i);
           }


           for (int a = 0; a <= 3; a++)
           {
               for (int b = 1; b <= 4; b++)
               {
                   Console.Write(a + b + " ");
               }

               Console.WriteLine();
           }



           //Write a console application that asks the user for an integer. If that integer is evenly divisible by 3, 
           //then write “You Won!” If it isn’t, write “You Lost.” Keep asking them for a number (looping) until they win. Loops slide 47


           while (true)
           { 

            int n = int.Parse(Console.ReadLine());

               if (n % 3 == 0)
                  {
                     Console.WriteLine("You Won!");
                     break;
                 }  
            else 
               {
                   Console.WriteLine("You Lost");

               }

           }

   */

            string line = "2 7 15";
            string[] separate = line.Split(new char[] { ' ' });

            int X = Convert.ToInt32(separate[0]);
            int Y = Convert.ToInt32(separate[1]);
            int N = Convert.ToInt32(separate[2]);



            for (int i = 1; i <= N; i++)
            {
                if (i % X == 0 && i % Y == 0)
                {
                    Console.Write("FB");
                }

                else if (i % X == 0)
                {
                    Console.Write("F");
                }

                else if (i % Y == 0)
                {
                    Console.Write("B");
                }

                else
                {
                    Console.Write(i);
                }
            }

            Console.WriteLine();


        }

    }
}
