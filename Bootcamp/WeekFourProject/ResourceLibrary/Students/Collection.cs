using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Bootcamp.WeekFourProject.ResourceLibrary.Students
{
    class Collection : IEnumerable
    {
        private Student[] students;

        //Create internal array in constructor.
        public Collection()
        {
            students = new Student[6]
            {
                new Student("Susy Student"),
                new Student("Chris Collins"),
                new Student("Amy Apple"),
                new Student("Matt Martins"),
                new Student("Betty Blue"),
                new Student("Joe Jones"),
            };
        }

        /*
         enumerator interface allows us to iterate over the collection
         https://support.microsoft.com/en-us/kb/322022
        */


        //private enumerator class
        private class MyEnumerator : IEnumerator
        {
            public Student[] studentlist;
            int position = -1;

            //constructor
            public MyEnumerator(Student[] list)
            {
                studentlist = list;
            }
            private IEnumerator getEnumerator()
            {
                return (IEnumerator)this;
            }


            //IEnumerator
            public bool MoveNext()
            {
                position++;
                return (position < studentlist.Length);
            }

            //IEnumerator
            public void Reset()
            { position = -1; }

            //IEnumerator
            public object Current
            {
                get
                {
                    try
                    {
                        return studentlist[position];
                    }

                    catch (IndexOutOfRangeException)
                    {
                        throw new InvalidOperationException();
                    }
                }
            }
        }  //end nested class

        public IEnumerator GetEnumerator()
        {
            return new MyEnumerator(students);
        }
    }
}
