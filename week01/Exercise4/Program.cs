using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int new_number = -1;
        List<int> numbers = new List<int>();

        do
        {
            Console.Write("Enter number: ");
            new_number = int.Parse(Console.ReadLine());
            if (new_number != 0)
            {
                numbers.Add(new_number);
            }
        } while (new_number != 0);

        // Sum, Average, and Largest Number
        int sum = 0;
        int average = 0;
        int largest_number = -(2 ^ 31);
        for (int i = 0; i < numbers.Count; i++)
        {
            sum += numbers[i];
            if (numbers[i] > largest_number)
            {
                largest_number = numbers[i];
            }
        }
        average = sum / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The sum is: {average}");
        Console.WriteLine($"The sum is: {largest_number}");
    }
}