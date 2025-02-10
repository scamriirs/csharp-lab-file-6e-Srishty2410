// Write a program to show the usage of this keyword

using System;

class Person
{
    private string name;

    public Person(string name)
    {
        this.name = name;
    }

    public void DisplayName()
    {
        Console.WriteLine("Name: " + this.name);
    }

    static void Main(string[] args)
    {
        Person person1 = new Person("Priya");

        person1.DisplayName();
    }
}
