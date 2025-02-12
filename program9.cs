//Create a program to show the concept of method overloading

using System;

class Program
{
    static void Display()
    {
        Console.WriteLine("Display method with no parameters.");
    }

    static void Display(int a)
    {
        Console.WriteLine("Display method with one integer parameter: " + a);
    }

    static void Display(string message)
    {
        Console.WriteLine("Display method with one string parameter: " + message);
    }

    static void Display(int a, int b)
    {
        Console.WriteLine("Display method with two integer parameters: " + a + ", " + b);
    }

    static void Main(string[] args)
    {
        Display();
        Display(10);
        Display("Hello, World!");
        Display(5, 15);

        Console.ReadLine();
    }
}
