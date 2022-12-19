using static System.Console;

WriteLine("Введите первое число: ");
int a = int.Parse(ReadLine()!);

WriteLine("Введите второе число: ");
int b = int.Parse(ReadLine());

if (a == b*b)
{
    WriteLine($" Число {a} - является квадратом числа {b}");
}
else
{
    WriteLine($" Число {a} - не является квадратом числа {b}");
}