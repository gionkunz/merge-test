// A Hello World! program in C#. 
using System;
namespace HelloWorld
{
    class Hello 
    {
        static void Main() 
        {
            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        static void WriteHelloWorld()
        {
            Console.WriteLine("Hello World!");
        }
    }
}