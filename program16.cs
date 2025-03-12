//Write a program to implement the concept of properties

using System;

class Person
{
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();

        person.Name = "John Doe";
        Console.WriteLine("Name: " + person.Name); 
    }
}
