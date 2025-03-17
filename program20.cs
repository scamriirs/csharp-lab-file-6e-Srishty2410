//Write a program to show the concept of indexer

using System;

class Employee
{
    private string[] names = new string[5];

    public string this[int index]
    {
        get { return names[index]; }
        set { names[index] = value; }
    }
}

class Program
{
    static void Main()
    {
        Employee employees = new Employee();

        employees[0] = "John";
        employees[1] = "Jane";
        employees[2] = "Alice";
        employees[3] = "Bob";
        employees[4] = "Eve";

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Employee {i + 1}: {employees[i]}");
        }
    }
}
