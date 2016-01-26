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
                new Resource("C#"),
                new Resource("ASP.NET MVC 5"),
                new Resource("The C# Player's Guide#"),
                new Resource("Eloquent JavaScript"),
                new Resource("SQL Queries"),
                new Resource("Javascript for Kids"),
                new Resource("Database Design"),
                new Resource("C# 5.0 for Dummies"),
                new Resource("Essential C# 6.0"),
                new Resource("Assembly Language Tutor"),
                new Resource("Mastering C Pointers"),
            };
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
