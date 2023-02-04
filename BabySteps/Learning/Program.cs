using System;

namespace Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            // Yea its a C++ style
            char userOption;
            userOption = 'U';
            int gameScore = 69;
            decimal particlesPerMillion = 800.50m;
            bool processedCustomer;
            processedCustomer = false;

            Console.WriteLine(userOption);
            Console.WriteLine(gameScore);
            Console.WriteLine(particlesPerMillion); Console.WriteLine(processedCustomer);

            var Message = "Var must be Initialized and can be anything, ONCE";
            Console.WriteLine($"\n{Message}");
            Message = "Word";
            Console.WriteLine(Message);
            //* Message = 50;
            Message = "WOrdsss";
            Console.WriteLine(Message);

            //! To print: Hello, Bob! You have 3 in your inbox. The temperature is 34.4 celsius.
            var name = "Bob";
            int mail = 3;
            decimal temp = 34.4m;

            //? $ allows you to concatenate like f strings in Python 
            Console.WriteLine($"\nHello, {name}! You have {mail} in your inbox. The temperature is {temp} celsius");

            /*
            * A verbatim string literal will keep all whitespace and characters without 
            * the need to escape the backslash. To create a verbatim string, use the @ directive before the literal string.
            */
            Console.WriteLine("\nC:\\Source\\repos");
            Console.WriteLine(@"C:\Source\repos
(this is where your code goes)");

            //! Using unicode to print
            // Kon'nichiwa World
            Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!, \u0906\u0908\u090F");

            //* COMbimationnnn
            string projectName = "First-Project";
            Console.WriteLine($@"\nC:\Output\{projectName}\Data is immune to \n"); //! immune to \n


            Console.Write("\n\nGoing to numbers\n");
            int value = 1;

            value = value + 1;
            Console.WriteLine("First increment: " + value);

            value += 1;
            Console.WriteLine("Second increment: " + value);

            value++;
            Console.WriteLine("Third increment: " + value);

            value = value - 1;
            Console.WriteLine("First decrement: " + value);

            value -= 1;
            Console.WriteLine("Second decrement: " + value);

            value--;
            Console.WriteLine("Third decrement: " + value);

        }
    }
}
