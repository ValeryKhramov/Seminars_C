// **Задача 67:** Напишите программу, которая будет 
// принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

using static System.Console;
Clear();

Write("Enter number: ");
string number = ReadLine()!;
WriteLine(PrintSum(int.Parse(number)));

int PrintSum(int num)
{
    if(num == 0) return num;
    else return PrintSum(num/10) + num%10;
}