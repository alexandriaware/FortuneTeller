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
            string firstName = Console.ReadLine().ToUpper();

            Console.WriteLine("And now your last name?");
            string surname = Console.ReadLine().ToUpper();

            //Now repeat their name so you don't mix it up like last time...
            Console.WriteLine("Hello, " + firstName + "!");



            //Horoscope time!
            Console.WriteLine("How old are you, dear?");
            int years = int.Parse(Console.ReadLine());
            int retirement;

            if (years <= 29)
            {
                Console.WriteLine("I knew it!");
            }
            else if (years >= 30)
            {
                Console.WriteLine("What? You don't look a day over 25!");
            }

            if ((years % 2) == 0)
            {
                retirement = 12;
            }
            else
            {
                retirement = 20;
            }



            Console.WriteLine("So, in which month were you born? Give me a number between 1 and 12.");
            int month = int.Parse(Console.ReadLine());

            Console.WriteLine("Perfect! What a lovely time of year.");
            string money;

            if (month >= 1 && month <= 4)
            {
                month = 100;
                money = "100 million dollars";
            }
            else if (month >= 5 && month <= 8) 
            {
                month = 1;
                money = "one thousand dollars";
            }
            else if (month >=9 && month <= 12)
            {
                month = 69;
                money = "sixty-nine cents";
            }
            else
            { 
                money = "nothing";
            }

            
            
            //Ask their favorite color, too, just for the hell of it. You're bored and deserve some fun.
            Console.WriteLine("Almost done. What is your favorite color? Type \"help\" to list your options.");
            string color = Console.ReadLine().ToLower();

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

            
            //Birth order affects personality...easy way to impress...
            Console.WriteLine("And finally, how many siblings do you have?");
            int siblings = int.Parse(Console.ReadLine());
            string city;

            if (siblings == 0)
            {
                city = "Amsterdam";
            }
            else if (siblings == 1)
            {
                city = "New York";
            }
            else if (siblings == 2)
            {
                city = "London";
            }
            else if (siblings == 3)
            {
                city = "Dublin";
            }
            else if (siblings > 3)
            {
                city = "Orlando";
            }
            else
            {
                city = "WWII Germany";
            }



            //Time to shine! They'll eat this up.
            Console.WriteLine("Here is your fortune:");
            Console.WriteLine(firstName + " " + surname + " will retire in " + retirement + " years with "
                + money + " in the bank, a \nvacation home in " + city + ", and a " + color + ".");
            



        }
    }
}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        