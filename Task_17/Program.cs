using static System.Console;
Clear();

// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

// 4  -> 24
// 5  -> 120

Write("Input integer N: ");
if (!int.TryParse(ReadLine(), out int number))
{
    WriteLine("Error. Input number, not string.");
    return;
}

int res = Factorial(number);
WriteLine($"Factorial number is {res}");

int Factorial(int A)
{
    if(A <= 0) return 0;

    int result = 1;
    while(A > 0)
    {
        result *= A;
        A--;
    }
    return result;
}
