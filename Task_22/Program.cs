// **Задача 33:** Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

// 4; массив [6, 7, 19, 345, 3] -> нет

// 3; массив [6, 7, 19, 345, 3] -> да
using static System.Console;
Clear();

Write($"Input size your array: ");
if(!int.TryParse(ReadLine(), out int sizeArray))
{
    WriteLine("Error. Input integer number.");
    return;
}

Write($"Input number which you want to find of the array: ");
if(!int.TryParse(ReadLine(), out int findNum))
{
    WriteLine("Error. Input integer number.");
    return;
}
int[] arr = getArray(sizeArray);
PrintArray(arr);
WriteLine($"The finding number is {findNum}");
WriteLine("-----");
WriteLine(findingNumber(findNum));



bool findingNumber(int number)
{
    bool flag = false;
    foreach(int dig in arr)
    {
        if(number == dig) return flag = true;           
    }
    return flag;
}

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

void PrintArray(int[] collection)
{
    Write($"[ ");
    for(int i = 0; i < collection.Length - 1; i++)
    {
        Write($"{collection[i]}, ");
    }
    WriteLine($"{collection[collection.Length - 1]} ]");
}