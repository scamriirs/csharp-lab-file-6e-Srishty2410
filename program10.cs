//Create a program to add the elements of two 2D matrix

using System;

class Program
{
    static void Main(string[] args)
    {
        int rows = 2;
        int cols = 3;

        int[,] array1 = { { 1, 2, 3 }, { 4, 5, 6 } };
        int[,] array2 = { { 7, 8, 9 }, { 10, 11, 12 } };

        int[,] resultArray = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                resultArray[i, j] = array1[i, j] + array2[i, j];
            }
        }

        Console.WriteLine("The resulting array is:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(resultArray[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}
