
using System;

class Program
{
    static void Main(string[] args)
    {
        // Display the welcome message
        DisplayWelcome();

        // Ask for the user's name
        string name = PromptUserName();

        // Ask for the user's favorite number
        int number = PromptUserNumber();

        // Calculate the square of the number
        int square = SquareNumber(number);

        // Display the final result
        DisplayResult(name, square);
    }

    // Function 1: Display a welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    // Function 2: Ask for and return the user's name
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    // Function 3: Ask for and return the user's favorite number
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    // Function 4: Calculate and return the square of a number
    static int SquareNumber(int number)
    {
        int square = number * number;

        return square;
    }

    // Function 5: Display the user's name and squared number
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}
