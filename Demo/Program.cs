namespace Demo
{
    internal class Program
    {

        #region MethodOverrloading

        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        public double Add(double a, double b)
        {
            return a + b;
        }
        #endregion




        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
