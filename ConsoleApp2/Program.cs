using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 maxNumber = 100;
            Random rng = new Random();
            Int32 numberToGuess = rng.Next(maxNumber);
            Int32 numberOfTries = (int)Math.Log(maxNumber) + 3;
            Console.WriteLine("Welcome to \"More or Less\" the game");
            Console.WriteLine("The Rules are simple:");
            Console.WriteLine("-A Random Number between 0 and {0} will be generated", maxNumber);
            Console.WriteLine("-You have {0} tries to guess the number", numberOfTries);
            Console.WriteLine("-At each unsuccessful attempt, you will be told if the number to guess is higher or lower than you last input");

            Int32 guess = int.Parse(Console.ReadLine());
            Int32 tries = 1;
            while (guess != numberToGuess)
            {
                Console.WriteLine(guess < numberToGuess ? "The number to guess is higher" : "The number to guess is lower");
                guess = int.Parse(Console.ReadLine());
                tries++;
                if (tries > numberOfTries) break;
            }
            Console.WriteLine(tries > numberOfTries ? "Too bad ! You can try again don't worry !" : "Congratz !! You made it !");
            Console.ReadLine();
        }
    }
}
