using oop04.assignment;

namespace oop04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question03
            Complex c1 = new Complex(5, 2);

            Complex c2 = new Complex(1, 1);

            Complex c3 = c1 + c2;

            Complex c4 = c1 - c2;

            Console.WriteLine($"c3: {c3}");

            Console.WriteLine($"c4: {c4}"); 
            #endregion
        }
    }
}
