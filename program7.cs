// Write a program to find the integer & fractional part of a number using out keyword

using System;

class Program
{
    static void SeparateParts(double number, out int integerPart, out double fractionalPart)
    {
        integerPart = (int)number;
        fractionalPart = number - integerPart;
    }

    static void Main(string[] args)
    {
        double num = 12.345; 

        int intPart;
        double fracPart;

        SeparateParts(num, out intPart, out fracPart);

        Console.WriteLine("Original Number: " + num);
        Console.WriteLine("Integer Part: " + intPart);
        Console.WriteLine("Fractional Part: " + fracPart);
    }
}
