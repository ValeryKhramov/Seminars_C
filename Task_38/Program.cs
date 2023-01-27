// **Задача 55:** Задайте двумерный массив. Напишите программу, 
// которая заменяет строки на столбцы. В случае, если это невозможно,
//  программа должна вывести сообщение для пользователя.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// В итоге получается вот такой массив:
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

using static System.Console;
Clear();
Write("Enter count rows and columns by space: ");
int[] parameters = Array.ConvertAll((ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries)), int.Parse);

int[,] elements = CreateMatrix(rows: parameters[0], columns: parameters[1]);
PrintMatrix(elements);
WriteLine();
int[,] collection = ReverseMatrix(elements);
PrintMatrix(collection);






int[,] CreateMatrix(int rows, int columns)
{
    int[,] resultMatrix = new int[rows,columns];
    Random rnd = new Random();
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            resultMatrix[i,j] = rnd.Next(10);
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
            Write($"{inMatrix[i,j], 3}");
        }
        WriteLine();
    }
}

int[,] ReverseMatrix(int[,] inMatrix)
{
    if (inMatrix.GetLength(0) != inMatrix.GetLength(1)) 
    {
        WriteLine($"The dimension of the matrix has been changed to [{inMatrix.GetLength(1)},{inMatrix.GetLength(0)}]");
    }

    int[,] resultMatrix = new int[inMatrix.GetLength(1), inMatrix.GetLength(0)];
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            resultMatrix[j, i] = inMatrix[i,j];
        }
    }
    return resultMatrix;
}