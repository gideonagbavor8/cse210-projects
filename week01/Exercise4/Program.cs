// Author: Gideon Komla Agbavor
// Purpose: Ask the user for a series of numbers, 
// and append each one to a list. Stop when they enter 0.

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        int input;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Collecting numbers from the user
        while (true)
        {
            Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());
            
            if (input == 0)
                break;

            numbers.Add(input);
        }

        // Core Requirements
        int sum = 0;
        int max = int.MinValue;
        foreach (int number in numbers)
        {
            sum += number;
            if (number > max)
                max = number;
        }

        double average = (double)sum / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");

        // Stretch Challenge
        int smallestPositive = int.MaxValue;
        foreach (int number in numbers)
        {
            if (number > 0 && number < smallestPositive)
                smallestPositive = number;
        }

        // Sorting the list
        numbers.Sort();

        Console.WriteLine($"The smallest positive number is: {(smallestPositive == int.MaxValue ? "None" : smallestPositive)}");
        Console.WriteLine("The sorted list is: " + string.Join(" ", numbers));
    }
}
