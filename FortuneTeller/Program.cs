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
            Console.WriteLine("I knew it!");

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


            if (color == "red")
            {
                color = "Motorized Wheelchair";
            }
            else if (color == "orange")
            {
                color = "Arabian Stallion";
            }
            else if (color == "yellow")
            {
                color = "Ice Cream Truck";
            }
            else if (color == "green")
            {
                color = "Skateboard";
            }
            else if (color == "blue")
            {
                color = "Yacht";
            }
            else if (color == "indigo")
            {
                color = "Hover Car";
            }
            else if (color == "violet")
            {
                color = "Tesla Model S";
            }
            else
                color = "pair of roller skates";

            //Family
            Console.WriteLine("And finally, how many siblings do you have?");
            int siblings = int.Parse(Console.ReadLine());

            Console.WriteLine("Here is your fortune:");
            Console.WriteLine(firstName + " " + surname + " will retire in " + age + " years with " +   );
            



        }
    }
}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        