using System.Globalization;

namespace Topic_8___Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            
            List <string> colours = new List <string>();
            string enteredColour;
            int numOfColours = 5, randNum = generator.Next(numOfColours - 1);;
            for (int i = 0; i < numOfColours; i++)
            {
                Console.Write("Enter a colour: ");
                enteredColour = Console.ReadLine();
                colours.Add(enteredColour);
            }
            Console.WriteLine();
            for (int i = 0; i < numOfColours;i++)
            {
                if (i == (numOfColours - 1))
                    Console.Write(colours[i] + ".");
                else
                    Console.Write(colours[i] + ", ");
            }
            Console.WriteLine();
            Console.Write("Here's a random number, and it's corresponding colour: ");
            Console.WriteLine(randNum + ", " + colours[randNum]);
            Console.ReadLine();
        }
    }
}
