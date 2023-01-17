// Задача 35: Задайте n-мерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
using static System.Console;
Clear();

Write($"Input number which you want to find of the array: ");
if(!int.TryParse(ReadLine(), out int findNum))
{
    WriteLine("Error. Input integer number.");
    return;
}

int[] elements = getArray(123);
PrintArray(elements);
int resultCount = countDigInArray(elements, findNum);
WriteLine($"You number meeting {resultCount} once.");



int[] getArray(int lenght)
{
    int[] mainArray = new int[lenght];
    Random rnd = new Random();
    for(int i = 0; i < mainArray.Length; i++)
    {
        mainArray[i] = rnd.Next(100);
    }
    return mainArray;
}

void  PrintArray(int[] collection)
{
    Write($"[ ");
    for(int i = 0; i < collection.Length - 1; i++)
    {
        Write($"{collection[i]}, ");
    }
    WriteLine($"{collection[collection.Length - 1]} ]");
}

int countDigInArray(int[] arr, int dig)
{
    int count = 0;
    foreach(int n in arr)
    {
        if (n == dig) count+=1;
    }
    return count;
}