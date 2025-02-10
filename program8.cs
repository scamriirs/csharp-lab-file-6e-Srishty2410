// Write a program to find smallest part in an array

using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 5, 2, 8, 1, 3 };

        int smallest = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < smallest)
            {
                smallest = numbers[i];
            }
        }
        Console.WriteLine("Smallest Element: " + smallest);
    }
}
