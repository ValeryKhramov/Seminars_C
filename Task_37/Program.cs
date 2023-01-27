// Задайте двумерный массив. Напишите программу,
//  которая поменяет местами первую и последнюю строку массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 8 4 2 4
// 5 9 2 3
// 1 4 7 2

using static System.Console;
Clear();
Write("Enter count rows and columns by space: ");
int[] parameters = Array.ConvertAll((ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries)), int.Parse);

int[,] elements = CreateMatrix(rows: parameters[0], columns: parameters[1]);
PrintMatrix(elements);
TransverFirstRowToLast(elements);
WriteLine();
PrintMatrix(elements);






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

void TransverFirstRowToLast(int[,] inMatrix)
{
    int temp;
    for (int i = 0; i < inMatrix.GetLength(1); i++)
    {
        temp = inMatrix[0,i];
        inMatrix[0,i] = inMatrix[inMatrix.GetLength(0) - 1, i];
        inMatrix[inMatrix.GetLength(0) - 1, i] = temp;
    }
}