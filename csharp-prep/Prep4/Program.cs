using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // list to store numbers
        List<int> numbers = new List<int>();


        // ask th user for series of numbers and each one to the list. stop when enter 0
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        int number = 0;
        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }
        } while (number != 0);

        // add or total of number in the list
        int sum = numbers.Sum();

        // average of numbers in the list
        double average = numbers.Average();

        // looking for maximum or biggest number
        int max = numbers.Max();

        // showing the results
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The Largest number is: {max}");

        // list of positive numbers and minimum
        int smallestPositive = numbers.Where(n => n > 0).DefaultIfEmpty(0).Min();

        Console.WriteLine($"The smallest positive number is: {smallestPositive}");

        // sort numbers in the list and show new and sort list to put in ascending order
        numbers.Sort();

        // show sorted list
        Console.WriteLine("The sorted list is: ");
        foreach (int n in numbers)
        {
            Console.WriteLine(n);
        }
    }
}