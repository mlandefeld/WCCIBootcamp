using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.WeekEight
{
    class Office
    {
        string CompanyName = "We Can Code IT";
        string size;
        int[] contents = {1,2,3};

        public void Name()
        {
            size = "Large";
            Console.WriteLine(CompanyName + size);

        }

        public int[] NewContents(int[] contents)
        {

            foreach(int kjh in contents)
            {
                Console.WriteLine(kjh);
            }
            
            return contents;
        }

        
    }
}
