using System;

class Program
{
    static void Main(string[] args)
    {
        // Call the welcome message
        DisplayWelcome();

        // Get user data via return values
        string userName = PromptUserName();
        int favoriteNumber = PromptUserNumber();

        // Get birth year using an 'out' parameter
        PromptUserBirthYear(out int birthYear);

        // Perform calculation
        int squaredNumber = SquareNumber(favoriteNumber);

        // Display the final results
        DisplayResult(userName, squaredNumber, birthYear);
    }

    // 1. DisplayWelcome - No parameters, no return
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // 2. PromptUserName - Returns a string
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    // 3. PromptUserNumber - Returns an integer
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    // 4. PromptUserBirthYear - Uses an 'out' parameter
    static void PromptUserBirthYear(out int birthYear)
    {
        Console.Write("Please enter the year you were born: ");
        birthYear = int.Parse(Console.ReadLine());
    }

    // 5. SquareNumber - Accepts an int, returns an int
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // 6. DisplayResult - Accepts multiple parameters
    static void DisplayResult(string name, int squaredNumber, int birthYear)
    {
        // Assuming current year is 2025 for age calculation
        int currentYear = DateTime.Now.Year;
        int age = currentYear - birthYear;

        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
        Console.WriteLine($"{name}, you will turn {age} this year.");
    }
}