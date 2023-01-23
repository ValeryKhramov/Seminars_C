// **Задача 46:** Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

using static System.Console;
Clear();    
Write("Enter count rows, column and minimal value, maximal value in array by space: ");
int[] intParameters = Array.ConvertAll((ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries)), int.Parse);
int[,] elements = GetMatrix(intParameters[0], intParameters[1], intParameters[2], intParameters[3]);
PrintMatrix(elements);

int[,] GetMatrix(int rows, int columns, int minValue, int maxValue)
{
    int[,] resultMatrix = new int[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultMatrix[i,j] = rand.Next(minValue,maxValue);
        }
        
    }
    return resultMatrix;
}
void PrintMatrix(int[,] inMatrix)
{
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            Write($"{inMatrix[i,j],5 }");
        }
        WriteLine();
    }
}