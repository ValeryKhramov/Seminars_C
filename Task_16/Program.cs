using static System.Console;
Clear();

// Write("Input integer number: ");
// int number = int.Parse(ReadLine());
// int sum = GetSum(number);
// WriteLine($"Sum number 1..A = {sum}");

// int GetSum(int A)
// {
//     int result = 0;
//     while(A > 0)
//     {
//          result += A;
//          A--;
//     }

//     return result;
// }

//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
Write("Input integer number: ");
if (!int.TryParse(ReadLine(), out int number))
{
    WriteLine("Error. Input number, not string.");
    return;
}

int count = NumCount(number);
WriteLine($"Count numbers is {count}");

int NumCount(int num)
{
    int result = 0;
    while(num > 0)
    {
        result++;
        num = num / 10;
    }

    return result;
}