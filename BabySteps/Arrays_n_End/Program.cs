using System;

namespace Arrays_n_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fraudulentOrderIDs = new string[3];

            fraudulentOrderIDs[0] = "A123";
            fraudulentOrderIDs[1] = "B456";
            fraudulentOrderIDs[2] = "C789";
            // fraudulentOrderIDs[3] = "D000";

            Console.WriteLine($"First: {fraudulentOrderIDs[0]} \nSecond: {fraudulentOrderIDs[1]} \nThird: {fraudulentOrderIDs[2]}");

            //! Re assign  and declare
            string[] fraudID = { "A123", "B456", "C789" };

            Console.WriteLine($"First: {fraudID[0]}");
            Console.WriteLine($"Second: {fraudID[1]}");
            Console.WriteLine($"Third: {fraudID[2]}");

            fraudID[0] = "F000";

            Console.WriteLine($"Reassign First: {fraudID[0]}");

            Console.WriteLine("\nforeach function");

            /*
                        * The foreach statement loops through each element in an array, running the code block below its declaration
                        * substituting the value in a temporary variable for the value of the array that the current loop represents. 
            */
            string[] names = { "Bob", "Conrad", "Grant" };
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            int[] inventory = { 200, 450, 700, 175, 250 };
            int sum = 0;
            int bin = 0;
            foreach (int items in inventory)
            {
                sum += items;
                bin++;
                Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
            }
            Console.WriteLine($"We have {sum} items in inventory.");

            // Test
            Console.Write("\n\nTest\n");
            string[] ids = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };
            foreach (string id in ids)
            {
                if (id.StartsWith("B"))
                {
                    Console.WriteLine(id);
                }
            }

            string str = "The quick brown fox jumps over the lazy dog.";
            int x = 0;

            // convert the message into a char array
            char[] charMessage = str.ToCharArray();

            // Reverse the chars
            Array.Reverse(charMessage);

            // count the o's
            foreach (char i in charMessage)
            {
                if (i == 'o') { x++; }
            }

            // convert it back to a string
            string new_message = new String(charMessage);

            // print it out
            Console.WriteLine(new_message);
            Console.WriteLine($"'o' appears {x} times.");
        }
    }
}
