using System;

namespace HelloName
{
    class HelloName
    {
        static void Main()
        {
            var name = Console.ReadLine();
            hello(name);
        }
        static void hello(string name)
        {
            Console.WriteLine("Hello, " + name + "!");
        }
    }
}
