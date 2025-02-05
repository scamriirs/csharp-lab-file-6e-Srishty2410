//   Write a program to show usage of this keyword

using System;

public class Person
{
    private string name;
    private int age;

    public Person(string name, int age)
    {
       
        this.name = name;
        this.age = age;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {this.name}, Age: {this.age}");
    }

    public bool IsSameAge(Person otherPerson)
    {
        return this.age == otherPerson.age;
    }

    public static void Main(string[] args)
    {
        Person person1 = new Person("John", 25);
        Person person2 = new Person("Alice", 25);
        
        person1.DisplayInfo();
        person2.DisplayInfo();

    }
}
