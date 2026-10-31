using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        string answer = Console.ReadLine();
        int grade = int.Parse(answer);

        // Step 1: Determine the letter grade
        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Step 2: Determine the grade sign (+ or -)
        string sign = "";
        int lastDigit = grade % 10;

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }

        // Step 3: Handle exceptional grades
        // There is no A+ grade
        if (letter == "A" && sign == "+")
        {
            sign = "";
        }

        // There is no F+ or F- grade
        if (letter == "F")
        {
            sign = "";
        }

        // Step 4: Display the final letter grade
        Console.WriteLine($"Your grade is {letter}{sign}");

        // Step 5: Determine whether the student passed
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Keep working hard. You can do better next time!");
        }


    }
}