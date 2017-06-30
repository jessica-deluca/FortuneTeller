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

            Console.WriteLine("Please enter your first name.");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please enter your last name.");
            string lastName = Console.ReadLine();

            Console.WriteLine("Please enter your age.");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your birth month as a number.");
            int birthMonth = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your favorite ROYGBIV color. (Hint: If you do not know what \"ROYGBIV\" is, enter \"Help\" to get a list of color options.)");
            string userColor = Console.ReadLine();

            string colorLower = userColor.ToLower();

            if (colorLower == "help")
            {
                Console.WriteLine("Color options: red, orange, yellow, green, blue, indigo, violet");
                userColor = Console.ReadLine();
            }

            Console.WriteLine("Please enter the number of siblings.");
            int numberOfSiblings = int.Parse(Console.ReadLine());

            //Part 2

            int yearsUntilRetirement;

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
                vacationHome = "Cleveland"; // If user’s siblings is 0, then they will have a vacation home in ____(location)
            }
            else if (numberOfSiblings == 1)
            {
                vacationHome = "Florida"; // If user’s siblings is 1, then they will have a vacation home in ____(location)
            }
            else if (numberOfSiblings == 2)
            {
                vacationHome = "Italy"; // If user’s siblings is 2, then they will have a vacation home in ____(location)
            }
            else if (numberOfSiblings == 3)
            {
                vacationHome = "Hawaii"; // If user’s siblings is 3, then they will have a vacation home in ____(location)
            }
            else if (numberOfSiblings > 3)
            {
                vacationHome = "Paris"; // If user’s siblings is more than 3, then they will have a vacation home in ____(location)
            }
            else if (numberOfSiblings <= 0)
            {
                vacationHome = "Garbage truck"; // If user’s siblings is anything other than a number greater than or equal to 0, they should get a bad vacation home!
            }

            string modeOfTransportation = "";

            switch (userColor) // Depending on which ROYGBIV color is the user’s favorite, they will have a specific mode of transportation
            {
                case "red":
                    modeOfTransportation = "car";
                    break;
                case "orange":
                    modeOfTransportation = "bus";
                    break;
                case "yellow":
                    modeOfTransportation = "boat";
                    break;
                case "green":
                    modeOfTransportation = "plane";
                    break;
                case "indigo":
                    modeOfTransportation = "bicycle";
                    break;
                case "violet":
                    modeOfTransportation = "skateboard";
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

            Console.WriteLine(firstName + " " + lastName + " will retire in " + yearsUntilRetirement + " years with $" + moneyInBank + ", a vacation home in " + vacationHome + " and a " + modeOfTransportation + ".");


            // stretch branch
        }
    }
}
