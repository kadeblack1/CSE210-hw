using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();
        string userName = PromptUserName();
        int userNumber = PromptFavoriteNumber();
        int squaredNumber = SquareNumber(userNumber);
        

        DisplayResult(userName, userNumber, squaredNumber);
    }
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program! ");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }
    static int PromptFavoriteNumber()
    {
        Console.WriteLine("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }
    static void DisplayResult(string userName, int userNumber, int squareNumber)
    {
        Console.WriteLine($"{userName}, the square of your number {userNumber} is {squareNumber}");
    }
}