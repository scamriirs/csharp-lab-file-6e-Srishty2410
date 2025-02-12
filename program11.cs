//Create a program to find the sum of 2D matrix

using System;

class Program
{
    static void Main(string[] args)
    {
        int rows = 3;
        int cols = 3;

        int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

        int sum = 0;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                sum += matrix[i, j];
            }
        }

        Console.WriteLine("The sum of all elements in the matrix is: " + sum);

        Console.ReadLine();
    }
}
