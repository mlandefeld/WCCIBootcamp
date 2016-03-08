using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.WeekEight
{
    class Student
    {
        //Defining classes slide 63-66

        //needs to be in static main Student fullNmame = new Student();

            //below is based off slide 41

        public string fullName;
        private string course;
        private string subject;
        private string university;
        private string email;
        private string phoneNumber;


        public Student()
        {
            this.fullName = "Margaret Landefeld";
            this.course = "History";
        }

        public Student(string fullName)
        {
            this.fullName = fullName;
        }

        public Student(string fullName, string course)
        {
            this.fullName = fullName;
            this.course = course;

        }

        public Student(string fullName, string course, string subject)
        {
            this.fullName = fullName;
            this.course = course;
            this.subject = "Today";
        }

        public Student(string fullName, string course, string subject, string univeristy, string email, int phoneNumber)
        {
            this.fullName = fullName;
            this.course = course;
            this.subject = subject;
            this.university = "CWRU";
            this.email = "m@m.com";
            this.phoneNumber = "5555555";
        }

        public string Email
        {
            get { return this.email; }
        }


    }
}
