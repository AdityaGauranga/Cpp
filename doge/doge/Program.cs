using System;

namespace doge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hey " + name + "! How do you do?");
            Console.ReadLine();
            Console.Write("Oh that's good to know. How old are you? ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(age + " huh? Ah the youth :)");

        }
    }
}
