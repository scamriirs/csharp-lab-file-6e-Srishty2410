//Write a program for indexer overloading

using System;

class SampleCollection
{
    private string[] data = new string[5];

    public string this[int index]
    {
        get { return data[index]; }  
        set { data[index] = value; } 
    }

    public string this[string key]
    {
        get
        {
            if (key == "First")
                return data[0];
            else if (key == "Second")
                return data[1];
            else if (key == "Third")
                return data[2];
            else
                return "Key not found";
        }
        set
        {
            if (key == "First")
                data[0] = value;
            else if (key == "Second")
                data[1] = value;
            else if (key == "Third")
                data[2] = value;
        }
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

        collection["First"] = "Updated First Item";

        Console.WriteLine("Item at index 0: " + collection[0]);

        Console.WriteLine("Item with key 'First': " + collection["First"]);
        Console.WriteLine("Item with key 'Second': " + collection["Second"]);
        Console.WriteLine("Item with key 'Third': " + collection["Third"]);
    }
}
