// **Задача 57:** Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

using static System.Console;
Clear();
Write("Enter count rows and columns by space: ");
int[] parameters = Array.ConvertAll((ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries)), int.Parse);

Write("Enter minamal and maximal value of the matrix by space: ");
int[] rangeMarix = Array.ConvertAll((ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries)), int.Parse);

int[,] elements = CreateMatrix(rows: parameters[0], columns: parameters[1], minValue: rangeMarix[0], maxValue: rangeMarix[1]);
PrintMatrix(elements);
WriteLine();
FindCountNumberInMatrix(elements, rangeMarix[0], rangeMarix[1]);






int[,] CreateMatrix(int rows, int columns, int minValue, int maxValue)
{
    int[,] resultMatrix = new int[rows,columns];
    Random rnd = new Random();
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            resultMatrix[i,j] = rnd.Next(minValue, maxValue);
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

void FindCountNumberInMatrix(int[,] inMatrix, int minValue, int maxValue)
{
    int count = 0;
    for (int k = minValue; k <= maxValue; k++)
    {
        for (int i = 0; i < inMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < inMatrix.GetLength(1); j++)
            {
                if (inMatrix[i,j] == k) count++;
            }
        }
        if (count != 0) WriteLine($"Value '{k}' meeted {count} ones.");
        count = 0;
    }
}