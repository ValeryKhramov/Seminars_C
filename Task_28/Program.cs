// **Задача 42:** Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

using static System.Console;
Clear();

Write("Input integer number: ");
if(!int.TryParse(ReadLine(), out int number))
{
    WriteLine("Error. Inputed not integer number.");
    return;
}
WriteLine($"Your number in decimal system = {number}");
WriteLine($"Your number in binary system = {decInBin(number)}");
WriteLine($"We can translation decimal number in binary: Convert.ToString(number, 2).");
WriteLine($"Result - {Convert.ToString(number, 2)}");
string decInBin(int digit)
{
    string result = string.Empty;
    while(digit > 0)
    {
        result = digit % 2 + result;
        digit /= 2;
    }
    return result;
}