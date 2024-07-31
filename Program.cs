using System;

namespace MyFirstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Type an animal or type exit: ");
                string animal = Console.ReadLine();

                switch (animal.ToLower())
                {
                    case "cat":
                        Console.WriteLine("You chose a cat!");
                        Console.WriteLine();
                        Console.WriteLine("   ^   ^   ");
                        Console.WriteLine("  = ^.^ =  ");
                        Console.WriteLine("    U U   ");
                        break;

                    case "dog":
                        Console.WriteLine("You chose a dog!");
                        Console.WriteLine();
                        Console.WriteLine("    `(^x^)´ ");
                        Console.WriteLine("    (V   V)/ ");
                        break;

                    case "fish":
                        Console.WriteLine("You chose a fish!");
                        Console.WriteLine();
                        Console.WriteLine("    <¤)))><  ");
                        break;

                    case "bunny":
                        Console.WriteLine("You chose a bunny!");
                        Console.WriteLine();
                        Console.WriteLine("    /) /) ");
                        Console.WriteLine("   ( -.- ) ");
                        break;

                    case "mouse":
                        Console.WriteLine("You chose a mouse!");
                        Console.WriteLine();
                        Console.WriteLine("      ^ ^ ");
                        Console.WriteLine("    = >.< =");
                        break;

                    case "bird":
                        Console.WriteLine("You chose a bird!");
                        Console.WriteLine();
                        Console.WriteLine("   ___  ");
                        Console.WriteLine("  (`v´)   ");
                        Console.WriteLine(" ((___))  ");
                        Console.WriteLine("   ^ ^     ");
                        break;

                    case "exit":
                        Console.Clear();
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Please try another animal:)");
                        break;
                }
            }
        }
    }
}