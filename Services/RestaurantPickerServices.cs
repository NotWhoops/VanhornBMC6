using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VanhornBMC6.Services
{
    public class RestaurantPickerServices
    {
        bool playAgain = true;
        bool playAgain1 = true;

        string[] FastFood = {
        "TacoBell",
        "Carl's Jr",
        "McDonald's",
        "Subway",
        "Burger King",
        "In n Out",
        "Sonic",
        "Chick fil A",
        "Wendy's",
        "Wing stop"
        };

        string[] Pizza = {
        "Mountain Mike's Pizza",
        "Little Caesars",
        "Papa Johns",
        "Marcos Pizza",
        "Smack Pie",
        "Dominos Pizza",
        "Strattons Pizza",
        "Pizza Guys",
        "Round Table Pizza",
        "Papa Murphy's",
        };

        string[] Restaurants ={
        "Olive Garden",
        "Red Lobster",
        "Texas Roadhouse",
        "Velvet Grill and Creamery",
        "El Rancho Steak & Lobster",
        "BJ Restaurant and Brewhouse",
        "Cheesecake Factory",
        "The Old Spaghetti Factory",
        "The Firehouse Steakhouse",
        "Magpie Cafe",
        };
// do
// {
//     Random rand = new Random();
//         int index1 = rand.Next(FastFood.Length);
//         int index2 = rand.Next(Pizza.Length);
//         int index3 = rand.Next(Restaurants.Length);

//         do
//         {
//         Console.WriteLine("Please pick a restaurant category: FastFood, Pizza or Restaurants");
//         string? userInput = Console.ReadLine()?.ToLower();

//         if (userInput == "fastfood")
//         {
//             Console.WriteLine($"Here is your choice: {FastFood[index1]}");
//             playAgain = false;
//         }
//         else if (userInput == "pizza")
//         {
//             Console.WriteLine($"Here is your choice: {Pizza[index2]}");
//             playAgain = false;
//         }
//         else if (userInput == "restaurants")
//         {
//         Console.WriteLine($"Here is your choice: {Restaurants[index3]}");
//         playAgain = false;
//         }
//         else
//         {
//         Console.WriteLine("Please enter a valid restaurant choice");
//         }
//         } while (playAgain == true) ;
//         playAgain1 = true;
//         while (playAgain) ;
     }
 }