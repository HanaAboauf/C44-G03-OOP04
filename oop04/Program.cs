using oop04.assignment;

namespace oop04
{
    internal class Program
    {

        public static void dispaly(BaseClass? baseClass)
        {

            baseClass?.DisplayMessage();

        }
        static void Main(string[] args)
        {
            #region Question03
            //Complex c1 = new Complex(5, 2);

            //Complex c2 = new Complex(1, 1);

            //Complex c3 = c1 + c2;

            //Complex c4 = c1 - c2;

            //Console.WriteLine($"c3: {c3}");

            //Console.WriteLine($"c4: {c4}");
            #endregion

            #region Question05

            //DerivedClass1 derivedClass1 = new DerivedClass1();

            //dispaly(derivedClass1);

            //DerivedClass2 derivedClass2 = new DerivedClass2();

            //dispaly(derivedClass2);

            /* using new keyword means that I hide the behavior of the base class method and implement my own.
             * this called static binding and determined through compile time.
             */

            /*
             * using override keyword means that I change the behavior of the base class method and implement my own.
             * this called dynamic binding and determined through clr.
             */





            #endregion
        }
    }
}
