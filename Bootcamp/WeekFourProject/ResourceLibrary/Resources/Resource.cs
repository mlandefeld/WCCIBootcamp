using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.WeekFourProject.ResourceLibrary.Resources
{
    class Resource
    {
        public string title="";
        public bool available = true;

        public Resource(string name)
        {
            title = name;
        }
            
   
        /// <summary>
        /// getter and setter for titles
        /// </summary>
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        /// <summary>
        /// getter and setter for available attribute
        /// </summary>
        public bool Available
        {
            get
            {
                return available;
            }
            set
            {
                available = value;
            }
        }

    }
}
