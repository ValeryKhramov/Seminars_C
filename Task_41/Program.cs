// **Задача 63:** Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"
//1) Собираем строку.
//2) Сразу выводим

using static System.Console;
Clear();
WriteLine(GetNum(10));
GetNum1(10);

string GetNum(int num)
{
    if(num == 1) return num.ToString();
    else return $"{GetNum(num - 1)}, {num}";
}

void GetNum1(int num)
{
    if(num == 1) Write(num);
    else
    {
        GetNum1(num - 1);
        Write($", {num}");
    }
}