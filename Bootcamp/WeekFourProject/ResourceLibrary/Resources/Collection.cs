using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Bootcamp.WeekFourProject.ResourceLibrary.Resources
{
    class Collection : IEnumerable
    {
        private Resource[] resources;

        //Create internal array in constructor.
        public Collection()
        {
            resources = new Resource[11]
            {
                new Resource("C#",1),
                new Resource("ASP.NET MVC 5",2),
                new Resource("The C# Player's Guide#",3),
                new Resource("Eloquent JavaScript",4),
                new Resource("SQL Queries",5),
                new Resource("Javascript for Kids",6),
                new Resource("Database Design",7),
                new Resource("C# 5.0 for Dummies",8),
                new Resource("Essential C# 6.0",9),
                new Resource("Assembly Language Tutor",10),
                new Resource("Mastering C Pointers",11),
            };
        }
        
        public Resource[] forStudentId(int student_id)
        {
            return this.resources.Where(c => c.student_id == student_id).ToArray();
        }
        
        public bool hasLessThanThree(int student_id)
        {
            if(this.forStudentId(student_id).Length < 3)
            {
                return true;
            }
            return false;
        }

        public Resource[] available()
        {
            return this.resources.Where(c => c.isAvailable()).ToArray();
        }
        /**
        * enumerator interface allows us to iterate over the collection
        * https://support.microsoft.com/en-us/kb/322022
        **/


        //private enumerator class
        private class MyEnumerator:IEnumerator
        {
            public Resource[] resourcelist;
            int position = -1;

            //constructor
            public MyEnumerator(Resource[] list)
            {
                resourcelist = list;
            }
            private IEnumerator getEnumerator()
            {
                return (IEnumerator)this;
            }


            //IEnumerator
            public bool MoveNext()
            {
                position++;
                return (position < resourcelist.Length);
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
                        return resourcelist[position];
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
            return new MyEnumerator(resources);
        }
    }
}
