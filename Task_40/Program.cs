// Задача 59: Из двумерного массива целых чисел удалить строку и столбец, 
// на пересечении которых расположен наименьший элемент.

using static System.Console;
Clear();
Write("Enter count rows and columns by space: ");
int[] parameters = Array.ConvertAll((ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries)), int.Parse);

Write("Enter minimal and maximal value for matrix by space: ");
int[] rangeMatrix = Array.ConvertAll((ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries)), int.Parse);

int[,] elements = CreateMatrix(parameters[0], parameters[1], rangeMatrix[0], rangeMatrix[1]);
PrintMatrix(elements);
WriteLine();
int[] minNum = FindMinInMatrix(elements);
WriteLine($"{minNum[0]} {minNum[1]} {minNum[2]}");
int[,] collection = DeleteRowColumnMatrix(elements,minNum);
PrintMatrix(collection);




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

int[] FindMinInMatrix(int[,] inMatrix)
{
    int[] result = new int[3];
    result[0] = inMatrix[0,0];
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            if (inMatrix[i,j] < result[0])
            {
                result[0] = inMatrix[i,j];
                result[1] = i;
                result[2] = j;
            }
            
        }
    }

    return result;
}

int[,] DeleteRowColumnMatrix(int[,] inMatrix, int[] Min)
{
    int row = Min[1], column = Min[2];
    int[,] resultMatrix = new int[inMatrix.GetLength(0) - 1, inMatrix.GetLength(1) - 1];
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            if(i < row && j < column) resultMatrix[i,j] = inMatrix[i,j];
            if(i < row && j > column) resultMatrix[i,j-1] = inMatrix[i,j];
            if(i > row && j > column) resultMatrix[i-1,j-1] = inMatrix[i,j];
            if(i > row && j < column) resultMatrix[i-1,j] = inMatrix[i,j];
        }
    }
    return resultMatrix;
}