
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create an empty list to store the numbers
        List<int> numbers = new List<int>();

        // Ask the user to enter numbers
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int number = -1;

        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        // Check that the user entered at least one number
        if (numbers.Count > 0)
        {
            // Step 1: Calculate the sum
            int sum = 0;

            foreach (int item in numbers)
            {
                sum += item;
            }

            Console.WriteLine($"The sum is: {sum}");

            // Step 2: Calculate the average
            double average = (double)sum / numbers.Count;

            Console.WriteLine($"The average is: {average}");

            // Step 3: Find the largest number
            int largest = numbers[0];

            foreach (int item in numbers)
            {
                if (item > largest)
                {
                    largest = item;
                }
            }

            Console.WriteLine($"The largest number is: {largest}");

            // Stretch Challenge 1: Find the smallest positive number
            int smallestPositive = int.MaxValue;

            foreach (int item in numbers)
            {
                if (item > 0 && item < smallestPositive)
                {
                    smallestPositive = item;
                }
            }

            if (smallestPositive == int.MaxValue)
            {
                Console.WriteLine("There are no positive numbers in the list.");
            }
            else
            {
                Console.WriteLine($"The smallest positive number is: {smallestPositive}");
            }

            // Stretch Challenge 2: Sort and display the list
            numbers.Sort();

            Console.WriteLine("The sorted list is:");

            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
        }
        else
        {
            Console.WriteLine("You did not enter any numbers.");
        }
    }
}
