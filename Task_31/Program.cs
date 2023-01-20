// Задача 45: Напишите программу, 
// которая будет создавать копию заданного массива с помощью поэлементного копирования.

using static System.Console;
Clear();

Write("Enter number is size your array: ");
if(!int.TryParse(ReadLine(), out int number))
{
    WriteLine("Error. Enter integer number.");
    return;
}
int[] elements = FillArray(number);
PrintArray(elements);
int[] collection = CopyArray(elements);
PrintArray(collection);

int[] FillArray(int size)
{
    int[] resultArray = new int[size];
    for(int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = new Random().Next(1,10);
    }
    return resultArray;
}

void PrintArray(int[] array)
{
    Write($"[ ");
    for(int i = 0; i < array.Length - 1; i++)
    {
        Write($"{array[i]}, ");
    }
    WriteLine($"{array[array.Length - 1]} ]");
}

int[] CopyArray(int[] arr)
{
    int[] resArr = new int[arr.Length];
    for(int i = 0; i < resArr.Length; i++)
    {
        resArr[i] = arr[i];
    }
    return resArr;
}