using System;

namespace GroupTestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int y = 2;

            //Expected -1
            Console.WriteLine(subber(x,y));
        }

        static int adder(int num1, int num2)
        {
            return 0;
        }

        static int subber(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}
