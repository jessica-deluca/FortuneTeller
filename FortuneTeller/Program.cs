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
            }
            else
            {

            }
          

            //Ask the user for the number of siblings the user has







        }
    }
}
