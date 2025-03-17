//Write a program to show indexer overloading

using System;

class Library
{
    private string[] books = new string[5];
    private int[] publicationYears = new int[5];

    public string this[int index]
    {
        get { return books[index]; }
        set { books[index] = value; }
    }

    public int this[string bookName]
    {
        get
        {
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i] == bookName)
                {
                    return publicationYears[i];
                }
            }
            return -1; 
        }
        set
        {
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i] == bookName)
                {
                    publicationYears[i] = value;
                    return;
                }
            }
        }
    }
}

class Program
{
    static void Main()
    {
        Library library = new Library();

        library[0] = "The Alchemist";
        library[1] = "1984";
        library[2] = "To Kill a Mockingbird";
        library[3] = "Pride and Prejudice";
        library[4] = "The Great Gatsby";

        library["The Alchemist"] = 1988;
        library["1984"] = 1949;
        library["To Kill a Mockingbird"] = 1960;
        library["Pride and Prejudice"] = 1813;
        library["The Great Gatsby"] = 1925;

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Book: {library[i]}, Published Year: {library[library[i]]}");
        }
    }
}
