using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = AddNumber(30, 40);
            Console.WriteLine("The number is :" + result);
            Console.WriteLine(AddNumber(20, 40));
            Console.ReadKey();
        }

        private static int AddNumber(int x, int y)
        {
            return x + y;
        }
    }
}
