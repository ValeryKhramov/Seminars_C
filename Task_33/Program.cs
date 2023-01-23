// **Задача 48:** Задайте двумерный массив размера m на n,
//  каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
//  Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5
using static System.Console;
Clear();
Write("Enter count rows and columns in array by space: ");
int[] intParameters = Array.ConvertAll((ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries)), int.Parse);
int[,] elements = GetMatrix(intParameters[0], intParameters[1]);
PrintMatrix(elements);

int[,] GetMatrix(int rows, int columns)
{
    int[,] resultMatrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultMatrix[i,j] = i + j;
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