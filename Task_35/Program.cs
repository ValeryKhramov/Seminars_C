// **Задача 51:** Задайте двумерный массив. 
// Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
using static System.Console;
Clear();
Write("Enter count rows and columns in array by space: ");
int[] intParameters = Array.ConvertAll((ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries)), int.Parse);
int[,] elements = GetMatrix(intParameters[0], intParameters[1]);
PrintMatrix(elements);
WriteLine();
WriteLine($"{SumDiagonal(elements),3}");

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
            Write($"{inMatrix[i,j],3} ");
        }
        WriteLine();
    }
}
int SumDiagonal(int[,] inMatrix)
{
    int result = 0;
    for (int i = 0; i < (inMatrix.GetLength(0) < inMatrix.GetLength(1)? inMatrix.GetLength(0):inMatrix.GetLength(1)); i++)
    {
        result += inMatrix[i,i];
    }
    return result; 
}
