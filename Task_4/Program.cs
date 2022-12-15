using static System.Console;

WriteLine("Введите трехзначное число: ");
int number = int.Parse(ReadLine());

if (number <= 999 && number >= 100)
{
   WriteLine($"Последняя цифра вашего числа = {number % 10}");
}
else
{
    WriteLine("Вы ввели не трехзначное число.");
}
