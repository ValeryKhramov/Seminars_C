// **Задача 49:** Задайте двумерный массив. Найдите элементы,
//  у которых оба индекса чётные, и замените эти элементы на их квадраты.

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4


using static System.Console;
Clear();
Write("Enter count rows and columns in array by space: ");
int[] intParameters = Array.ConvertAll((ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries)), int.Parse);

int[,] elements = GetMatrix(intParameters[0], intParameters[1]);
PrintMatrix(elements);
WriteLine();
int[,] newArray = GetNewMatrix(elements);
PrintMatrix(newArray);

int[,] GetMatrix(int rows, int columns)
{
    int[,] resultMatrix = new int[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultMatrix[i,j] = rand.Next(10);
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

int[,] GetNewMatrix (int[,] oldMatrix)
{
    int[,] resultMatrix = oldMatrix.Clone() as int[,];
    for (int i = 0; i < oldMatrix.GetLength(0); i++)
    {
        if (i % 2 == 0 && i != 0)
        {
            for (int j = 0; j < oldMatrix.GetLength(1); j++)
            {
                if(j % 2 == 0 && j != 0) resultMatrix[i,j] *= resultMatrix[i,j];
            }
        }
    }
    return resultMatrix;
}

