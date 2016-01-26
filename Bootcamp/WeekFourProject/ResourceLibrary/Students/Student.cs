using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.WeekFourProject.ResourceLibrary.Students
{
    class Student
    {
        public string name = "";

        public Student(string inputName)
        {
            name = inputName;
        }


        /// <summary>
        /// getter and setter for titles
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        
    }
}
