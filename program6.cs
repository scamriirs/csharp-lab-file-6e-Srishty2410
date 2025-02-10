Write a program to find the square of a number using pass by reference

using System;

class Program
{
    static void CalculateSquare(ref int number)
    {
        number = number * number;
        Console.WriteLine("Square (Pass-by-Reference): " + number);
    }

    static void Main(string[] args)
    {
        int num = 5;
        Console.WriteLine("Original Number: " + num);

        CalculateSquare(ref num);

        Console.WriteLine("Number after function call (Pass-by-Reference): " + num);
    }
}
