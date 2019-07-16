using System;

namespace SingASong
{
    class Program
    {
        static void SingaSong(string title)
        {
            Console.WriteLine($"Lets sing {title}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SingaSong("Baby Shark!");
        }
    }
}
