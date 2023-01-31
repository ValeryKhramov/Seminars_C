// **Задача 65:** Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 5, 6, 7, 8"
// Двумя способами с дополнительной проверкой в самой рекурсии.
using static System.Console;
Clear();

Write("Enter value from M to N by space: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

PrintNumber(int.Parse(parameters[0]), int.Parse(parameters[1]));
WriteLine();
string result = PrintNumber1(int.Parse(parameters[0]), int.Parse(parameters[1]));
WriteLine(result);

void PrintNumber(int one, int two)
{
    if(one > two)
    {
        int temp = one;
        one = two;
        two = temp;
    }
    if(two == one) Write($"{one}");
    else 
    {
        PrintNumber(one, two - 1);
        Write($", {two}");
    }
}

string PrintNumber1(int one, int two)
{
    if(one > two)
    {
        int temp = one;
        one = two;
        two = temp;
    }
    if(one == two) return one.ToString();
    else return $"{PrintNumber1(one,two - 1)}, {two}";
}