using System;
using System.Collections.Generic;
using System.Linq; // Needed for sorting and advanced operations

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int userNumber = -1;

        // Step 1: Collect numbers from the user
        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            string response = Console.ReadLine();
            userNumber = int.Parse(response);

            // Only add the number if it is not 0
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // --- Core Requirements ---

        // 1. Compute the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        // 2. Compute the average
        // Note: Casting sum to float/double to ensure decimal division
        double average = ((double)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // 3. Find the maximum
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The largest number is: {max}");

        // --- Stretch Challenges ---

        // 1. Find the smallest positive number
        int? smallestPositive = null; // Using a nullable int for safety

        foreach (int number in numbers)
        {
            if (number > 0)
            {
                if (smallestPositive == null || number < smallestPositive)
                {
                    smallestPositive = number;
                }
            }
        }
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");

        // 2. Sort the list
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}