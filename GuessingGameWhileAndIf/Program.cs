using System;

namespace GuessingGameWhileAndIf
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNumber = new Random();
            int guesses = 0, userGuess = 1, numberToGuess;
            numberToGuess = randomNumber.Next(100);

            Console.WriteLine("Welcome to the number guessing game please pick a number between 0 and 100 : ");

            while (userGuess != numberToGuess)
            {
                userGuess = int.Parse(Console.ReadLine());

                if (userGuess > numberToGuess)
                {
                    Console.WriteLine("Number to high!");
                }
                else if (userGuess < numberToGuess)
                {
                    Console.WriteLine("Number to low!");
                }
                else
                {
                    guesses++;
                    Console.WriteLine("You are correct, the number is : " + numberToGuess);
                    Console.WriteLine("You guessed it in " + guesses + " tries!");
                }
            }  
        }
    }
}
