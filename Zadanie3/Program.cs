// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

public class Program
{
    public static void Main(string[] args)
    {
        int rows = 8;
        int[,] myArray = CreateTwoDimArray (4, rows, 1, 10);
        Print(myArray);

        SumRows(myArray);
        
    }
   public static int[,] CreateTwoDimArray(int rows, int cols, int min, int max)
    {
        int[,] twoDimArray = new int [rows, cols];
        Random rand = new Random();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                twoDimArray[i,j] = rand.Next(min, max+1);
            }
        }
        return twoDimArray;
    }
    public static void Print(int[,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();    
        }
    }
   public static void SumRows(int[,] array)
    {
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    int minsum = int.MaxValue;
    int minRow = -1;

    for (int i = 0; i < rows; i++)
    {
        int rowSum = 0;
        for (int j = 0; j < cols; j++)
        {
            rowSum = rowSum + array[i, j];
        }
        if (rowSum < minsum)
        {
            minsum = rowSum;
            minRow = i+1;
        }
    }
    if (if (minRow != -1))
    {
        Console.WriteLine($"Минимальная сумма строки: {minsum}, номер строки: {minRow}");
    }
    }
}


