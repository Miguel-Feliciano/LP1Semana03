using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            string iS;
            char charToRemove;
            string oS = "";

            Console.WriteLine("Enter a string:");
            iS = Console.ReadLine();

            Console.WriteLine("Enter a character to remove:");
            charToRemove = (char)Console.Read();


            foreach (char c in iS)
            {
                if (c != charToRemove)
                {
                    oS += c;
                }
            }

            Console.WriteLine($"The string without the character '{charToRemove}' is: {oS}");
        }
    }

}

