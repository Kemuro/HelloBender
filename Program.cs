using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome, {0}! We would like to get to know a little more about you.", name);
            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();
           
            Console.WriteLine("What is your favorite element?");
            string element = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            string animal = Console.ReadLine();
            
            Console.WriteLine("");
            Console.WriteLine("Character Sheet:");
            Console.WriteLine("    Name: " + name);
            Console.WriteLine("    Favorite color: " + color);
            Console.WriteLine("    Favorite element: " + element);
            Console.WriteLine("    Favorite animal: " + animal);

            if(color == "Gold")
                color = "Golden";

            Console.WriteLine("");

            Console.WriteLine("Avatar Character: {0} the {1}-bender, master of the {2} {3} technique!",name, element, color, animal);

        }
    }
}
