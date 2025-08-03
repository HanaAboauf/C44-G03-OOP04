using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop04.assignment
{
    public class BaseClass
    {

        /*
         *

b) Create a derived class DerivedClass1 that overrides the DisplayMessage method using the override keyword.

C) Create another derived class DerivedClass2 that hides the DisplayMessage method using the new keyword.

         */


        public virtual void DisplayMessage()
        {
            Console.WriteLine("Message from BaseClass");
        }
    }
}
