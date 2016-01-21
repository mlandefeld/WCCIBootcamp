using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.WeekTwo
{
    class WkTwoDayTwo
    {
        
        public void ageDist()
        {
            //code eval age distribution
            string line = Console.ReadLine();
            int ageAsInt = Convert.ToInt32(line);

            if (ageAsInt >= 0 && ageAsInt <= 2)
            {
                Console.WriteLine("Still in Mama's arms");
            }

            else if (ageAsInt == 3 && ageAsInt == 4)
            {
                Console.WriteLine("Preschool Maniac");
            }

            else if (ageAsInt >= 5 && ageAsInt <= 11)
            {
                Console.WriteLine("Elementary School");
            }

            else if (ageAsInt >= 12 && ageAsInt <= 14)
            {
                Console.WriteLine("Middle School");
            }
            else if (ageAsInt >= 15 && ageAsInt <= 18)
            {
                Console.WriteLine("High School");
            }
            else if (ageAsInt >= 19 && ageAsInt <= 22)
            {
                Console.WriteLine("College");
            }
            else if (ageAsInt >= 23 && ageAsInt <= 65)
            {
                Console.WriteLine("Working for the man");
            }
            else if (ageAsInt >= 66 && ageAsInt <= 100)
            {
                Console.WriteLine("The Golden Years");
            }

            else
            {
                Console.WriteLine("This program is for humans");
            }
        }
            
                        
    }
}
