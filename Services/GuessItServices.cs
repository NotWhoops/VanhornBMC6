using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VanhornBMC6.Services
{
    public class GuessItServices
    {
        bool playAgain = true;

        // do
        // {
        //     bool playAgain1 = true;
        //     Console.Clear();
        //     int min = 1;
        //     int max = 10;
        //     Console.WriteLine("Welcome to the Guessing Game. Please Choose Easy, Medium, Hard or Custom");
        //     string? userInput = Console.ReadLine();
        //     Random random = new Random();
        //     int NumberOfGuesses = 0;

        //     while (playAgain)
        //     {
        //         switch (userInput)
        //         {
        //             case "Easy":
        //                 Easy();
        //                 min = 1; max = 10;
        //                 break;
        //             case "Medium":
        //                 Medium();
        //                 min = 1; max = 50;
        //                 break;
        //             case "Hard":
        //                 Hard();
        //                 min = 1; max = 100;
        //                 break;
        //             case "Custom":
        //                 Custom();
        //                 break;
        //             default:
        //                 Console.WriteLine("Invalid input");
        //                 CustomFunction();
        //                 break;
        //         }
        //     }


        //     void Easy()
        //     {
        //         int randomNumber = random.Next(1, 11);
        //         while (playAgain == true)
        //         {
        //             Console.WriteLine("Please guess a number between 1 and 10");
        //             string? userSelection = Console.ReadLine();
        //             bool isNum2 = int.TryParse(userSelection, out int num1);

        //             if (isNum2)
        //             {
        //                 NumberOfGuesses++;
        //                 if (num1 < randomNumber)
        //                 {
        //                     Console.WriteLine($"{num1} is to low");
        //                 }
        //                 else if (num1 > randomNumber)
        //                 {
        //                     Console.WriteLine($"{num1} is to high");
        //                 }

        //                 else if (num1 == randomNumber)
        //                 {
        //                     Console.WriteLine($"{num1} is correct in {NumberOfGuesses} guesses");
        //                     playAgain = false;
        //                 }
        //             }
        //             else
        //             {
        //                 Console.WriteLine("Invalid input, please enter a number");
        //             }
        //         }
        //     }

        //     void Medium()
        //     {
        //         int randomNumber2 = random.Next(1, 51);
        //         while (playAgain == true)
        //         {

        //             Console.WriteLine("Please guess a number between 1 and 50");
        //             string? userSelection = Console.ReadLine();
        //             bool isNum2 = int.TryParse(userSelection, out int num1);

        //             if (isNum2)
        //             {
        //                 NumberOfGuesses++;
        //                 if (num1 < randomNumber2)
        //                 {
        //                     Console.WriteLine($"{num1} is to low");
        //                 }
        //                 else if (num1 > randomNumber2)
        //                 {
        //                     Console.WriteLine($"{num1} is to high");
        //                 }

        //                 else if (num1 == randomNumber2)
        //                 {
        //                     Console.WriteLine($"{num1} is correct in {NumberOfGuesses} guesses");
        //                     playAgain = false;
        //                 }
        //             }
        //         }
        //     }
        //     void Hard()
        //     {
        //         int randomNumber3 = random.Next(1, 101);
        //         while (playAgain == true)
        //         {

        //             Console.WriteLine("Please guess a number between 1 and 100");
        //             string? userSelection = Console.ReadLine();
        //             bool isNum2 = int.TryParse(userSelection, out int num1);

        //             if (isNum2)
        //             {
        //                 NumberOfGuesses++;
        //                 if (num1 < randomNumber3)
        //                 {
        //                     Console.WriteLine($"{num1} is to low");
        //                 }
        //                 else if (num1 > randomNumber3)
        //                 {
        //                     Console.WriteLine($"{num1} is to high");
        //                 }

        //                 else if (num1 == randomNumber3)
        //                 {
        //                     Console.WriteLine($"{num1} is correct in {NumberOfGuesses} guesses");
        //                     playAgain = false;
        //                 }
        //             }
        //         }
        //     }
        //     void Custom()
        //     {
        //         Console.WriteLine("Enter minimum number:");
        //         int.TryParse(Console.ReadLine(), out min);

        //         Console.WriteLine("Enter maximum number:");
        //         int.TryParse(Console.ReadLine(), out max);
        //         int randomNumber4 = random.Next(min, max + 1);

        //         while (playAgain == true)
        //         {
        //             Console.WriteLine("Please guess a number ");
        //             string? userSelection = Console.ReadLine();
        //             bool isNum2 = int.TryParse(userSelection, out int num1);

        //             if (isNum2)
        //             {
        //                 NumberOfGuesses++;
        //                 if (num1 < randomNumber4)
        //                 {
        //                     Console.WriteLine($"{num1} is to low");
        //                 }
        //                 else if (num1 > randomNumber4)
        //                 {
        //                     Console.WriteLine($"{num1} is to high");
        //                 }

        //                 else if (num1 == randomNumber4)
        //                 {
        //                     Console.WriteLine($"{num1} is correct in {NumberOfGuesses} guesses");
        //                     playAgain = false;
        //                 }
        //             }
        //         }
        //     }
        //     void CustomFunction()
        //     {
        //         Console.WriteLine("Please enter: Easy, Medium, Hard or Custom");
        //         userInput = Console.ReadLine();
        //     }


        //     while (playAgain1)
        //     {
        //         Console.WriteLine("Do you want to play again, Yes or No?");
        //         string? userSelection = Console.ReadLine();

        //         if (userSelection == "yes")
        //         {
        //             Console.WriteLine("Have fun");
        //             playAgain1 = false;
        //             playAgain = true;
        //         }
        //         else if (userSelection == "no")
        //         {
        //             Console.WriteLine("See you later");
        //             playAgain1 = false;
        //             playAgain = false;
        //         }

        //         if (userSelection != "yes" && userSelection != "no")
        //         {
        //             Console.WriteLine("Try Again. Please enter 'yes' or 'no' ");
        //         }
        //     }
        // } while (playAgain);
    }
}