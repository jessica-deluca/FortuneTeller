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
            // Part 1

            Console.WriteLine("Welcome to Fortune Teller!\nTo know your future, answer the questions when prompted. Select [Enter] on your keyboard after each answer to proceed to the next question.\nWhat is your first name?");
            string firstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();

            Console.WriteLine("What is your current age?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your birth month? Please enter it as a number.\n(For example, if your birth month is August, enter the number \"8\".)");
            int birthMonth = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your favorite ROYGBIV color.\n(If you do not know what \"ROYGBIV\" is, enter \"Help\" to get a list of color options.)");
            string userColor = Console.ReadLine();

            string colorLower = userColor.ToLower();

            if (colorLower == "help")
            {
                Console.WriteLine("Color options: red, orange, yellow, green, blue, indigo, violet");
                colorLower = Console.ReadLine();
            }

            Console.WriteLine("How many siblings do you currently have?");
            int numberOfSiblings = int.Parse(Console.ReadLine());

            //Part 2

            int yearsUntilRetirement; // don't need to add a new variable here but decided to keep it consistant with code pattern & helps readability of final line of code for printing

            if (age % 2 == 0)
            {
                yearsUntilRetirement = 20; // If the user’s age is an even number, then they will retire in ____ years.
            }
            else // If the user’s age is an odd number, then they will retire in ____ years.
            {
                yearsUntilRetirement = 35;
            }

            string vacationHome = "";

            if (numberOfSiblings == 0)
            {
                vacationHome = "Paris"; // If user’s siblings is 0, then they will have a vacation home in ____(location)
            }
            else if (numberOfSiblings == 1)
            {
                vacationHome = "Tuscany"; // If user’s siblings is 1, then they will have a vacation home in ____(location)
            }
            else if (numberOfSiblings == 2)
            {
                vacationHome = "Hawaii"; // If user’s siblings is 2, then they will have a vacation home in ____(location)
            }
            else if (numberOfSiblings == 3)
            {
                vacationHome = "Alaska"; // If user’s siblings is 3, then they will have a vacation home in ____(location)
            }
            else if (numberOfSiblings > 3)
            {
                vacationHome = "Cleveland"; // If user’s siblings is more than 3, then they will have a vacation home in ____(location)
            }
            else if (numberOfSiblings < 0)
            {
                vacationHome = "a cardboard box"; // If user’s siblings is anything other than a number greater than or equal to 0, they should get a bad vacation home!
            }

            string modeOfTransportation = ""; // don't need to add a new variable here but decided to keep it consistant with code pattern & helps readability of final line of code for printing

            switch (colorLower) // Depending on which ROYGBIV color is the user’s favorite, they will have a specific mode of transportation
            {
                case "red":
                    modeOfTransportation = "Mercedes-Benz";
                    break;
                case "orange":
                    modeOfTransportation = "mini van";
                    break;
                case "yellow":
                    modeOfTransportation = "luxury yacht";
                    break;
                case "green":
                    modeOfTransportation = "private jet";
                    break;
                case "indigo":
                    modeOfTransportation = "tricycle";
                    break;
                case "violet":
                    modeOfTransportation = "hoverboard";
                    break;
            }

            double moneyInBank;

            if (birthMonth >= 1 && birthMonth <= 4) // If the user’s birth month is 1-4, they will have $____ in the bank
            {
                moneyInBank = 10000d;
            }
            else if (birthMonth >= 5 && birthMonth <= 8) // If the user’s birth month is 5-8, they will have $____ in the bank
            {
                moneyInBank = 50000d;
            }
            else if (birthMonth >= 9 && birthMonth <= 12) // If the user’s birth month is 9-12, they will have $____ in the bank
            {
                moneyInBank = 100000d;
            }
            else // If the user’s birth month is something other than 1-12, they will have $0.00 in the bank
            {
                moneyInBank = 0d;
            }

            // Part 3
            // Print: [First Name] [Last Name] will retire in [# of Years] with [Amount of Money] in the bank, a vacation home in [Location] and a [Mode of Transportation].

            Console.WriteLine(firstName + " " + lastName + " will retire in " + yearsUntilRetirement + " years with $" + moneyInBank + ", a vacation home in " + vacationHome + " and a " + modeOfTransportation + ".\nThanks for playing!");
            
        }
    }
}
