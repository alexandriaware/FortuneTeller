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

            Console.WriteLine("So, what month would that be? Give me a number between 1 and 12.");
            int month = int.Parse(Console.ReadLine());

            Console.WriteLine("Perfect!");
            

        }
    }
}
