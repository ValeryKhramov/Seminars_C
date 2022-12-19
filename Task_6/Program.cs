using static System.Console;
Clear();

int number = new Random().Next(100, 1000);
int a1 = number / 100;
int a3 = number % 10;
WriteLine(number);
WriteLine($"{a1}{a3}");


