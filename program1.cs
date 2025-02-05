// Create a program to show the usage of parameterized constructor, parameterless constructor, default constructor
using System;

class Person
{
    public string Name;
    public int Age;

  
   
    public Person()
    {
        Name = "Unknown";
        Age = 0;
        Console.WriteLine("Parameterless Constructor Called");
    }

  
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
        Console.WriteLine("Parameterized Constructor Called");
    }

    public void Display()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

class Program
{
    static void Main()
    {
       
        Person person1 = new Person();
        person1.Display();

        r
        Person person2 = new Person("Alice", 25);
        person2.Display();

    
    }
}
