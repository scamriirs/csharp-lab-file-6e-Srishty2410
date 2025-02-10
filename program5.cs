// Write the program to find the square of a number using pass by value

using System;

class Program
{
    static void CalculateSquare(int number)
    {
        number = number * number;
        Console.WriteLine("Square (Pass-by-Value): " + number);
    }

    static void Main(string[] args)
    {
        int num = 5;
        Console.WriteLine("Original Number: " + num);

        CalculateSquare(num);

        Console.WriteLine("Number after function call (Pass-by-Value): " + num);
    }
}
