//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.


using static System.Console;
Clear();
Write("Input N: ");
if (!int.TryParse(ReadLine(), out int N))
{
    WriteLine("Error. Input number, not string.");
    return;
}
int count = 1;
while (count <= N)
{
    Write($"{Math.Pow(count, 2 )} ");
    count++;
}