//  Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

public class Program
{
    public static void Main(string[] args)
    {
        int[,] myArray = CreateTwoDimArray(5, 5, 1, 10);
        Print(myArray);

        SwapRows(myArray, 0, 4);

        Console.WriteLine("Массив после обмена строк:");
        Print(myArray);
    }
        public static int[,] CreateTwoDimArray(int rows,int cols, int min, int max)
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
    public static void SwapRows(int[,]array, int row1, int row2)
    {

        int cols = array.GetLength(1);
        int temp;

        if(row1 >=0 && row1 < array.GetLength(0) && row2 >=0 && row2 < array.GetLength(0))
        {
            for (int j = 0; j < cols; j++)
            {
                temp = array[row1, j];
                array[row1,j] = array[row2,j];
                array[row2, j] = temp;
            }
            Console.WriteLine($"Строки {row1} и {row2} были поменяны местами.");
        }
        else
        {
            Console.WriteLine("Ошибка: Некорректные номера строк для обмена.");
        }
    }

  public static void Print(int[,]array)
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
}