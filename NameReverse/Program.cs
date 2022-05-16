using System;

namespace NameReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is you name?");
            string hello = Console.ReadLine();
            



            for (int i = hello.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(hello[i]);
            }

        }
    }
}
