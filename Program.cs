namespace S02_tableaux_multidimensionnels;

class Program
{
    static void Main(string[] args)
    {
        int[,] uniformArray = new int[3, 3]
        {
            { 1, 2, 3 },
            { 2, 3, 4 },
            { 3, 4, 5 }
        };

        int[][] irregularArray = new int[3][];

        for (int i = 0; i < uniformArray.GetLength(0); i++)
        {
            int length = uniformArray.GetLength(1) - i;
            int[] row = new int[length];

            for (int j = 0; j < length; j++)
            {
                row[j] = uniformArray[i, j];
            }

            irregularArray[i] = row;
        }

        Console.WriteLine("Tableau uniforme :");
        PrintArray(uniformArray);

        Console.WriteLine("\nTableau irrégulier :");
        PrintArray(irregularArray);
    }

    static void PrintArray(int[,] array)
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    static void PrintArray(int[][] array)
    {
        int rows = array.Length;

        for (int i = 0; i < rows; i++)
        {
            int length = array[i].Length;

            for (int j = 0; j < length; j++)
            {
                Console.Write($"{array[i][j]} ");
            }
            Console.WriteLine();
        }
    }
}
