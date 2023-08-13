using System.Security.Cryptography;

namespace Terningen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int dice = random.Next(1, 7);
            if (dice == 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You rolled a 1");
            }
            else if (dice == 2)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("You rolled a 2");
            }
            else if (dice == 3)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You rolled a 3");
            }
            else if (dice == 4)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("You rolled a 4");
            }
            else if (dice == 5)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("You rolled a 5");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("You rolled a 6");
            }
            Console.Read();
        }
    }
}