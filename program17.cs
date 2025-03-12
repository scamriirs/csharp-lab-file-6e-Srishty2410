//Write a program to show the concept of indexes

using System;

class SampleCollection
{
    private string[] data = new string[5];

    public string this[int index]
    {
        get { return data[index]; }  
        set { data[index] = value; } 
    }
}

class Program
{
    static void Main(string[] args)
    {
        SampleCollection collection = new SampleCollection();

        collection[0] = "First Item";
        collection[1] = "Second Item";
        collection[2] = "Third Item";
        Console.WriteLine("Item at index 0: " + collection[0]);
        Console.WriteLine("Item at index 1: " + collection[1]);
        Console.WriteLine("Item at index 2: " + collection[2]);
    }
}
