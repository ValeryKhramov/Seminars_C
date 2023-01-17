// Задача 32: Напишите программу замена элементов массива:
// положительные элементы замените на соответствующие отрицательные, и наоборот.



using static System.Console;
Clear();

Write("Input size array: ");
if(!int.TryParse(ReadLine(), out int sizeArray))
{
    WriteLine("Error. Input integer nimber.");
    return;
}
int minValue = -10;
int maxValue = 10;

int[] resultArray = GetArray(sizeArray);
PrintArray(resultArray);
reverseArray(resultArray);
PrintArray(resultArray);






int[] GetArray(int size)
{
    int[] elements = new int[size];
    Random rnd = new Random();
    for(int i = 0; i < elements.Length; i++)
    {
        elements[i] = rnd.Next(minValue, maxValue);
    }
    return elements;
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
int[] reverseArray(int[] arr)
{
    for(int i = 0; i < arr.Length;i++)
    {
        arr[i] *= -1;
    }
    return arr;
}