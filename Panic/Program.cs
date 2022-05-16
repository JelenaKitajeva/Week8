using System;

namespace Panic
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "K33p C4lm";
           
            hello = hello.Replace('3', 'e');
            hello = hello.Replace('4', 'a');

            Console.WriteLine(hello);
            
        }
    }
}
