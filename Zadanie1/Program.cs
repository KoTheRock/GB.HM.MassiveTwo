//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

public static class Program
{
    public static void Main(string [] args)
    {   
        int rows = 5;
        int cols = 5;
        
        int[,] myArray = CreateTwoDimArray(rows, cols, 1, 10);
        Print(myArray);

        Console.WriteLine("Введите номер строки (от 1 до 5):");
        int rowToShow =int.Parse(Console.ReadLine())-1;

        Console.WriteLine("Введите номер столбца (от 1 до 5):");
        int colToShow = int.Parse(Console.ReadLine())-1;

        ShowNumberInPosition(myArray, rowToShow, colToShow);
    }
    public static int[,] CreateTwoDimArray(int rows, int cols, int min, int max)

        {
            int [,] twoDimArray = new int [rows, cols];
            Random rand = new();
            
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    twoDimArray[i,j]  = rand.Next(min, max+1);
                }
            }
            return twoDimArray;
        }

public static void ShowNumberInPosition(int[,] array, int row, int col)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);

    if (row >= rows || col >= cols || row < 0 || col < 0)
    {
        Console.WriteLine("Ошибка: указаны неверные координаты строки или столбца.");
        return;
    }

    int numberToShow = array[row, col];
    Console.WriteLine($"Число на позиции [{row}, {col}]: {numberToShow}");
}

    public static void Print(int[,] array)
    {
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
            Console.Write(array[i,j] + "\t");
            }
        Console.WriteLine();
        }
    }
}

