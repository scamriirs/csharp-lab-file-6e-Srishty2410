//Create a program to show the concept of method overloading

using System;

class Program
{
    static void display()
    {
        Console.WriteLine("Hello!");
    }

    static void display(string name)
    {
        Console.WriteLine("Hello, " + name + "!");
    }

    static void display(string name, int age)
    {
        Console.WriteLine("Hello, " + name + "! You are " + age + " years old.");
    }

    static void Main(string[] args)
    {
        display();
        display("Alice");
        display("Bob", 25);

        Console.ReadLine();
    }
}
