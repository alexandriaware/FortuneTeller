using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        { 
            //Oh look, a customer! Greet them!
            Console.WriteLine("Welcome to your personal fortune teller! \nPlease make yourself comfortable.");

            Console.WriteLine("Now, tell me your first name.");
            string firstName = Console.ReadLine();

            Console.WriteLine("And now your last name?");
            string surname = Console.ReadLine();

            //Now repeat their name so you don't mix it up like last time...
            Console.WriteLine("Hello, " + firstName + "!");

            //Horoscope time!
            Console.WriteLine("How old are you, dear?");
            int age = int.Parse(Console.ReadLine());

            if (age >= 29)
            {
                Console.WriteLine("What? No, you don't look a day over 25!");
            }
            else
            {
                Console.WriteLine("I knew it!");
            }

            Console.WriteLine("So, in which month were you born? Give me a number between 1 and 12.");
            int month = int.Parse(Console.ReadLine());

            Console.WriteLine("Perfect! What a lovely time of year.");

            //Colors
            Console.WriteLine("Almost done. What is your favorite color? Type \"help\" to list your options.");
            string color = Console.ReadLine();

            if (color == "help")
            {
                Console.WriteLine("You can choose either red, orange, yellow, green, blue, indigo, or violet.");
                color = Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Thank you.");
            }

            ////Family
            //Console.WriteLine("Finally, how many siblings do you have?");
            //int siblings = int.Parse(Console.ReadLine());
            

        }
    }
}
