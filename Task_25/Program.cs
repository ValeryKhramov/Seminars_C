// Задача 37: Найдите произведение пар чисел в одномерном массиве.
//  Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//  Результат запишите в новом массиве.

using static System.Console;
Clear();

Write("Input size a array: ");
if(!int.TryParse(ReadLine(), out int sizeArray))
{
    WriteLine("Error. Inputed not integer number.");
    return;
}

int[] collection = getArray(sizeArray);
PrintArray(collection);
collection = multiplication(collection);
PrintArray(collection);


int[] getArray(int size )
{
    int[] elements = new int[size];
    Random rnd = new Random();
    for(int i = 0; i < elements.Length; i++)
    {
        elements[i] = rnd.Next(1,10);
    }
    return elements;
}
void PrintArray(int[] arr)
{
    Write($"[ ");
    for(int i = 0; i < arr.Length - 1; i++ )
    {
        Write($"{arr[i]}, ");
    }
    WriteLine($"{arr[arr.Length - 1]} ]");
}
int[] multiplication(int[] array)
{   
    int longArray;
    if (array.Length % 2 == 0) longArray = array.Length / 2;
    else longArray = array.Length / 2 + 1;
    int[] resultArray = new int[longArray];
    for(int i = 0; i < longArray; i++)
    {
        resultArray[i] = array[i] * array[array.Length - i - 1 ];
    }
    return resultArray;
}