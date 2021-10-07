using System;

namespace GroupTestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(adder(1,2));
        }

        static int adder(int num1, int num2)
        {
            return num1 + num2;
        }

        static int subber(int num1, int num2)
        {
            return 0;
        }
    }
}
