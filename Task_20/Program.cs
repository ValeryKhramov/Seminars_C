//Напишит программу, которая выводит массив из 8 чисел
//состощий из 0 и 1 в случайном порядке

using static System.Console;
Clear();

void OutputArray(int[] elements)
{
    for( int i = 0; i < elements.Length; i++)
    {
        Write($"{elements[i]} ");
    }
}
int[] FullArray(int num)
{
    int[] result = new int[num];
    for(int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(0,2);
    }
    return result;
}

 int[] arr = FullArray(num: 10);
OutputArray(arr);