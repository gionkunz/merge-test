// A Hello World! program in C#. 
using System;
namespace HelloWorld
{
    class Hello
    {
        static void Main() 
        {
            Console.WriteLine("Hello World!");

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            // Reading the console key so that the program awaits user input before closing
            Console.ReadKey();
        }
    }
}