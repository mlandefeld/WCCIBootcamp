using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.WeekFive
{
    class DayFour
    {
        public void ReadMore()
        {
            string line = "Amy Lawrence was proud";
            char[] trimLine;
            trimLine = line.ToCharArray();
            for(int i = 0; i<trimLine.Length; i++)
            {
                if (trimLine.Length <= 55)
                {
                    Console.Write(trimLine[i]);

  
                }
                else if(trimLine.Length>55)
                {
                    Console.WriteLine("false");
                    break;
                }
                else
                {
                    break;
                    
                }
            }
            
        }

    }
}
