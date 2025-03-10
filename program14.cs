//Write a program to show the concept of overriding

using System;

class Program
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    public double Add(double a, double b)
    {
        return a + b;
    }

    static void Main(string[] args)
    {
        Program program = new Program();

        Console.WriteLine("Sum of 2 and 3: " + program.Add(2, 3));

        Console.WriteLine("Sum of 1, 4, and 5: " + program.Add(1, 4, 5));

        Console.WriteLine("Sum of 2.5 and 3.5: " + program.Add(2.5, 3.5));
    }
}
