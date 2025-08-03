using oop04.assignment;

namespace Assignment
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

            #region Question04

            //Employee emp = new Employee();
            //emp.Works();

            //Console.WriteLine("=====================");

            //Manager mgr = new Manager();
            //mgr.Works();
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

            #region Part02
            Duration D1 = new Duration(1, 10, 15);
            Console.WriteLine(D1); // Output: Hours: 1, Minutes: 10, Seconds: 15

            Duration D2 = new Duration(7800);
            Console.WriteLine(D2); // Output: Hours: 2, Minutes: 10, Seconds: 0

            Duration D3 = new Duration(666);
            Console.WriteLine(D3); // Output: Minutes: 11, Seconds: 6

            D3 = D1 + D2;
            Console.WriteLine(D3); // Combined result

            D3 = D1 + 7800;
            Console.WriteLine(D3);

            D3 = 666 + D3;
            Console.WriteLine(D3);

            D3 = ++D1;
            Console.WriteLine(D3); // Should increase by 1 minute

            D3 = --D2;
            Console.WriteLine(D3); // Should decrease by 1 minute

            D1 = D1 - D2;
            Console.WriteLine(D1);

            if (D1 > D2) Console.WriteLine("D1 is greater");

            if (D1 <= D2) Console.WriteLine("D1 is smaller or equal");

            if (D1) Console.WriteLine("D1 is true (non-zero)");

            DateTime dt = (DateTime)D1;
            Console.WriteLine(dt.ToLongTimeString());
            #endregion


        }


    }

}
