// Сумма чисет от 1 до N, на которые N делится без остатка
using static System.Console;
Clear();

Write("Input integer N: ");
if (!int.TryParse(ReadLine(), out int number))
{
    WriteLine("Error. Input number, not string.");
    return;
}

int resultSum = SumDividers(number);
WriteLine($"Sum dividers number is {resultSum}");


int  SumDividers(int num)
{
    int result = 0;
    int count = 1;
    while (count <= num)
    {
        if ( num % count == 0)
        {
            result += count;
        }
        count++;
    }
    return result;
}

