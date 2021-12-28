using System;

namespace LearnDebug
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Fibbonachi(5);
            //Console.Write($"The numbers are {result}");
            Console.Write(result);
        }
        static int Fibbonachi(int n)
        {
            int num1 = 0;
            int num2 = 1;
            int sum = 0;

            for (int i = 2; i <= n; i++)
            {
                sum = num1 + num2;
                num1 = num2;
                num2 = sum;
            }

            return n == 0 ? num1 : num2;

        }
    }
}