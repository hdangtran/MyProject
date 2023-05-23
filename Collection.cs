using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Linq.Expressions;

namespace MyProject
{
    internal class Collection
    {
        static void Main(string[] args)
        {
            var classes = new List<String>();
            ArrayList myCollection = new ArrayList();
            classes.Add("a");
            classes.Add("b");
            classes.Add("c");
            classes.Add("d");

            foreach (var c in classes) {
                Console.WriteLine(c);
            }


            // collection can hold many data types


            myCollection.Add("c");
            myCollection.Add("this is a string");
            myCollection.Add(3.4);
            Console.WriteLine("New commit");

            foreach (var c in myCollection) {
                Console.WriteLine(c);
            }

            

        }



    }
}
