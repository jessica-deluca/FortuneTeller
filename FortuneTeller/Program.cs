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
            // Ask the user for the user’s first name

            Console.WriteLine("Please enter your first name.");
            string firstName = Console.ReadLine();

            // Ask the user for the user’s last name

            Console.WriteLine("Please enter your last name.");
            string lastName = Console.ReadLine();

            // Ask the user for the user’s age

            Console.WriteLine("Please enter your age.");
            int age = int.Parse(Console.ReadLine());

            // Ask the user for the user’s birth month(as an 'int')

            Console.WriteLine("Please enter your birth month as a number.");
            int birthMonth = int.Parse(Console.ReadLine());

            // Ask the user for the user’s favorite ROYGBIV color
            // If the user does not know what ROYGBIV is, ask them to enter “Help” to get a list of the ROYGBIV colors

            Console.WriteLine("Please enter your favorite ROYGBIV color. (Hint: If you do not know what \"ROYGBIV\" is, enter \"Help\" to get a list of color options.)");
            string userColor = Console.ReadLine();

            string colorLower = userColor.ToLower();

            if (colorLower == "help")
            {
                Console.WriteLine("Color options: red, orange, yellow, green, blue, indigo, violet");
                userColor = Console.ReadLine();
            }

            //Ask the user for the number of siblings the user has

            Console.WriteLine("Please enter the number of siblings.");
            int numberOfSiblings = int.Parse(Console.ReadLine());

            // If the user’s age is an odd number, then they will retire in ____ years, or ___ years if their age is an even number.
            // If the user’s number of siblings is 0, then they will have a vacation home in ____(location), or 1 then they will have a vacation home in ____(location), or 2 then they will have a vacation home in ____(location), or 3 then they will have a vacation home in ____(location), or more than 3 then they will have a vacation home in ____(location).If the user enters anything other than a number greater than or equal to 0, they should get a bad vacation home!
            // Depending on which ROYGBIV color is the user’s favorite, they will have a specific mode of transportation(i.e.car, boat, plane, etc.)
            // If the user’s birth month is 1 - 4, they will have $____ in the bank; if the user's birth month is 5-8, they will have $____ in the bank; and if it is 9-12, then they will have $____ in the bank. If the user enters something other than 01-12 as their birth month, they will have $0.00 in the bank.        








        }
    }
}
