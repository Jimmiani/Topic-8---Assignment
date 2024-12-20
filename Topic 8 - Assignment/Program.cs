﻿using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Topic_8___Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool done = false;
            string choice = "";
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            while (!done)
            {
                Console.Clear();
                Console.WriteLine("Welcome to my programming assignment for Lists! Select any option.");
                Console.WriteLine();
                Console.WriteLine("1. Colours");
                Console.WriteLine("2. Numbers");
                Console.WriteLine("Q. Quit");
                Console.WriteLine();
                Console.Write("Select option: ");
                choice = Console.ReadLine();
                if (choice == "1")
                {
                    Colours();
                }
                else if (choice == "2")
                {
                    RandomNumbers();
                }
                else if (choice.ToUpper().Trim() == "Q")
                {
                    done = true;
                }
                Console.WriteLine();
                Console.WriteLine("Hope you enjoyed your time!");
                Console.WriteLine("Goodbye Buckaroo!");
            }
        }
        public static void Colours()
        {
            Random generator = new Random();
            List<string> colours = new List<string>();
            string enteredColour;
            Console.Clear();
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter a colour: ");
                enteredColour = Console.ReadLine();
                colours.Add(enteredColour);
            }
            int randNum = generator.Next(1, colours.Count - 1);
            Console.WriteLine();
            for (int i = 0; i < colours.Count; i++)
            {
                if (i == (colours.Count - 1))
                    Console.Write(colours[i] + ".");
                else
                    Console.Write(colours[i] + ", ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Here's a random number, and it's corresponding colour: ");
            Console.WriteLine(randNum + ", " + colours[randNum - 1]);
            Console.WriteLine();
            Console.WriteLine("Press 'ENTER' to return to main menu.");
            Console.ReadLine();
        }
        public static void RandomNumbers()
        {
            Random generator = new Random();
            List <int> numbers = new List<int>();
            int maxValue, minValue, numOfNumbers, enteredNum, containNumber = 0, numReplaceZero;
            Console.Clear();
            Console.WriteLine("How many numbers would you like this list to contain?");
            Console.Write("Numbers needed: ");
            while (!int.TryParse(Console.ReadLine(), out numOfNumbers))
                Console.Write("Invalid Numeric Input. Try again: ");
            while (numOfNumbers <= 0)
            {
                Console.WriteLine("Cannot be less than or equal to zero");
                Console.Write("Try again: ");
                while (!int.TryParse(Console.ReadLine(), out numOfNumbers))
                    Console.Write("Invalid Numeric Input. Try again: ");
            }
            Console.WriteLine();
            Console.Write("Enter in a minimum value: ");
            while (!int.TryParse(Console.ReadLine(), out minValue))
                Console.Write("Invalid Numeric Input. Try again: ");
            Console.WriteLine();
            Console.Write("Enter in a maximum value: ");
            while (!int.TryParse(Console.ReadLine(), out maxValue))
                Console.Write("Invalid Numeric Input. Try again: ");
            while (maxValue < minValue)
            {
                Console.WriteLine("Maximum value cannot be less than minimum value");
                Console.Write("Try again: ");
                while (!int.TryParse(Console.ReadLine(), out maxValue))
                    Console.Write("Invalid Numeric Input. Try again: ");
            }
            for (int i = 0; i < numOfNumbers; i++)
            {
                numbers.Add(generator.Next(minValue, maxValue + 1));
            }
            Console.WriteLine();
            Console.Write("Here is the list: ");
            for (int i = 0; i < numOfNumbers; i++)
            {
                Console.Write(numbers[i] + ", ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Enter a number and I'll tell you how many times it appears in the list: ");
            while (!int.TryParse(Console.ReadLine(), out enteredNum))
                Console.Write("Invalid Numeric Input. Try again: ");
            for (int i = 0; i < numOfNumbers; i++)
            {
                if (numbers[i] == enteredNum)
                    containNumber++;
            }
            Console.WriteLine(enteredNum + " appeared in that list " + containNumber + " time(s)!");
            Console.WriteLine();
            Console.Write("Enter a number to replace with a zero: ");
            while (!int.TryParse(Console.ReadLine(), out numReplaceZero))
                Console.Write("Invalid Numeric Input. Try again: ");
            for (int i = 0; i < numOfNumbers; i++)
            {
                if (numbers[i] == numReplaceZero)
                {
                    numbers[i] = 0;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Removing all " + numReplaceZero + "s and replacing with zeros.");
            Console.Write("Here is the new list: ");
            for (int i = 0; i < numOfNumbers; i++)
            {
                Console.Write(numbers[i] + ", ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press 'ENTER' to continue.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Resetting all numbers in list. List will now have only zeros.");
            Console.Write("Here is the new list: ");
            for (int i = 0; i < numOfNumbers; i++)
            {
                numbers[i] = 0;
            }
            for (int i = 0; i < numOfNumbers; i++)
            {
                Console.Write(numbers[i] + ", ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press 'ENTER' to continue.");
            Console.ReadLine();
            Console.Clear();
            Console.Write("Here is a new list with new random numbers: ");
            for (int i = 0; i < numOfNumbers; i++)
            {
                numbers[i] = (generator.Next(minValue, maxValue));
            }
            for (int i = 0; i < numOfNumbers; i++)
            {
                Console.Write(numbers[i] + ", ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press 'ENTER' to return to main menu.");
            Console.ReadLine();
        }
    }
}
