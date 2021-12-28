using System;
using System.Diagnostics;
// See https://aka.ms/new-console-template for more information

namespace ExampleCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Fibbonachi(5);
            Console.Write($"The number is {result}");
        }

        static void Examples()
        {

            Console.WriteLine("A readable text.");
            System.Diagnostics.Trace.WriteLine("Trace message for tracing");
            System.Diagnostics.Debug.WriteLine("This is a debug message for devs");
            int Count = 0;
            if (Count == 0)
            {
                System.Diagnostics.Debug.WriteLine("Count is 0 omg. May cause exception");
            }
            // ! Thats the same as

            System.Diagnostics.Debug.WriteLineIf(Count == 0, "The Count is Zero, wow.");


            /*
            * You can also use these conditions with Trace 
            * and with flags that you define in your application.
            */
            bool errorFlag = false;
            System.Diagnostics.Trace.WriteIf(errorFlag, "Error in AppendData procedure.");
            System.Diagnostics.Debug.WriteIf(errorFlag, "Transaction abandoned.");
            System.Diagnostics.Trace.Write("Invalid value for data requested.");

        }


        static int Fibbonachi(int n)
        {
            Debug.WriteLine($"Entering {nameof(Fibbonachi)} method");
            Debug.WriteLine($"We're looking for the {n}th number");
            int num1 = 0;
            int num2 = 1;
            int sum = 0;

            for (int i = 2; i <= n; i++)
            {
                sum = num1 + num2;
                num1 = num2;
                num2 = sum;
                Debug.WriteLineIf(sum == 1, $"sum is 1, 1st is {num1}, n2 is {num2}");
            }

            // If n2 is 5 continue, else break.
            Debug.Assert(num2 == 5, "The return value is not 5 and it should be.");
            return n == 0 ? num1 : num2;

        }
    }
}