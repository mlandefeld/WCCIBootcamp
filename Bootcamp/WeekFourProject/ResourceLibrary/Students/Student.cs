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
        public string id = "";

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

        /// <summary>
        /// getter and setter assign number to name
        /// </summary>
        public string Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

    }
}
