// Задача 31: Задайте массив из 12 элементов, 
// заполненный случайными числами из промежутка [-9, 9].
//  Найдите сумму отрицательных и положительных элементов массива.

//сделать метод кторый возdрщает int


using static System.Console;
Clear();

Write("Input size array, minimal value array and maximum value array: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int negativeNum = 0;
int positiveNum = 0;

int[] array = GetArray(int.Parse(parameters[0]), int.Parse(parameters[1]), int.Parse(parameters[2]));
PrintArray(array);
inArray(array);

void inArray(int[] elements)
{
    foreach(int num in array)
    {
        negativeNum += num < 0? num : 0;
        positiveNum += num > 0? num : 0;
    }
    WriteLine($"{negativeNum}    {positiveNum}");
}
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] elements = new int[size];
    Random rnd = new Random();
    for(int i = 0; i < size; i++)
    {
        elements[i] = rnd.Next(minValue, maxValue);
    }

    return elements;
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