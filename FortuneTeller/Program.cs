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

            Console.WriteLine("Welcome to Fortune Teller!\nTo know your future, answer the questions when prompted. Select [Enter] on your keyboard after each answer to proceed to the next question.\nTo exit at any time, type \"Quit\" then select [Enter].\nWhat is your first name?");
            string firstName = Console.ReadLine();

            string quitAtFirstNameLower = firstName.ToLower(); // covert string to lowercase to account for QUIT

            if (quitAtFirstNameLower == "quit")
            {
                Console.WriteLine("Nobody likes a quitter...");
                return;
            }

            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();

            string quitAtLastNameLower = lastName.ToLower(); // covert string to lowercase to account for QUIT

            if (quitAtLastNameLower == "quit")
            {
                Console.WriteLine("Nobody likes a quitter...");
                return;
            }

            Console.WriteLine("What is your current age?");
            string age = Console.ReadLine(); // originially had int but changed to string to account for "quit" // will convert to int later
            
            string quitAtAgeLower = age.ToLower(); // covert string to lowercase to account for QUIT

            if (quitAtAgeLower == "quit")
            {
                Console.WriteLine("Nobody likes a quitter...");
                return;
            }

            Console.WriteLine("What is your birth month? Please enter it as a number.\n(For example, if your birth month is August, enter the number \"8\".)");
            string birthMonth = Console.ReadLine(); // originially had int but changed to string to account for "quit" // will convert to int later
            
            string quitAtBirthMonthLower = birthMonth.ToLower(); // covert string to lowercase to account for QUIT

            if (quitAtBirthMonthLower == "quit")
            {
                Console.WriteLine("Nobody likes a quitter...");
                return;
            }

            Console.WriteLine("What is your favorite ROYGBIV color.\n(If you do not know what \"ROYGBIV\" is, enter \"Help\" to get a list of color options.)");
            string userColor = Console.ReadLine();

            string colorLower = userColor.ToLower(); // covert string to lowercase to account for QUIT and HELP

            if (colorLower == "quit")
            {
                Console.WriteLine("Nobody likes a quitter...");
                return;
            }

            if (colorLower == "help")
            {
                Console.WriteLine("Color options: red, orange, yellow, green, blue, indigo, violet");
                colorLower = Console.ReadLine();
                string quitColorLower = colorLower.ToLower(); // covert string to lowercase to account for QUIT
                {
                    if (quitColorLower == "quit")
                    {
                        Console.WriteLine("Nobody likes a quitter...");
                        return;
                    }
                }
            }

            Console.WriteLine("How many siblings do you currently have?");
            string numberOfSiblings = Console.ReadLine(); // originially had int but changed to string to account for "quit" // will convert to int later

            string quitAtNumberOfSiblingsLower = numberOfSiblings.ToLower(); // covert string to lowercase to account for QUIT

            if (quitAtNumberOfSiblingsLower == "quit")
            {
                Console.WriteLine("Nobody likes a quitter...");
                return;
            }

            //Part 2

            // age determines years until retirement
            int ageConvertedToInt = Convert.ToInt16(age); // convert age to int
            int yearsUntilRetirement; // don't need to add a new variable here but decided to keep it consistant with code pattern & helps readability of code for printing of fortune

            if (ageConvertedToInt % 2 == 0) // if age is even number...
            {
                yearsUntilRetirement = 20; // ... retire in 20 years
            }
            else // if age is odd number...
            {
                yearsUntilRetirement = 35; // ... retire in 35 years
            }

            // number of siblings determines vacation home
            decimal numberOfSiblingsConvertedToDecimal = Convert.ToDecimal(numberOfSiblings); // convert age to decimal // decided to use decimal instead of int because directions state "if user enters a number less than 0, they should get a bad vacation home" so if user enters -.5 (for example) they will still get a bad vacation home
            string vacationHome = "";

            if (numberOfSiblingsConvertedToDecimal == 0m)
            {
                vacationHome = "Paris";
            }
            else if (numberOfSiblingsConvertedToDecimal == 1m)
            {
                vacationHome = "Tuscany";
            }
            else if (numberOfSiblingsConvertedToDecimal == 2m)
            {
                vacationHome = "Hawaii";
            }
            else if (numberOfSiblingsConvertedToDecimal == 3m)
            {
                vacationHome = "Alaska";
            }
            else if (numberOfSiblingsConvertedToDecimal > 3m)
            {
                vacationHome = "Cleveland";
            }
            else if (numberOfSiblingsConvertedToDecimal < 0m)
            {
                vacationHome = "a cardboard box"; // if user entered negative number, they get a bad vacation home
            }

            // ROYGBIV color determines transportation
            string modeOfTransportation = ""; // don't need to add a new variable here but decided to keep it consistant with code pattern & helps readability of final line of code for printing

            switch (colorLower)
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

            // birth month determines money in bank
            int birthMonthConvertedToInt = Convert.ToInt16(birthMonth); // convert age to int
            double moneyInBank;

            if (birthMonthConvertedToInt >= 1 && birthMonthConvertedToInt <= 4)
            {
                moneyInBank = 10000d;
            }
            else if (birthMonthConvertedToInt >= 5 && birthMonthConvertedToInt <= 8)
            {
                moneyInBank = 50000d;
            }
            else if (birthMonthConvertedToInt >= 9 && birthMonthConvertedToInt <= 12)
            {
                moneyInBank = 100000d;
            }
            else
            {
                moneyInBank = 0d;
            }

            // Part 3
            // Print: [First Name] [Last Name] will retire in [# of Years] with [Amount of Money] in the bank, a vacation home in [Location] and a [Mode of Transportation].

            Console.WriteLine(firstName + " " + lastName + " will retire in " + yearsUntilRetirement + " years with $" + moneyInBank + " in the bank, a vacation home in " + vacationHome + " and a " + modeOfTransportation + ".\nThanks for playing!");

        }
    }
}
