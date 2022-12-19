using static System.Console;
Clear();

int number = new Random().Next(10, 100);
int a1 = number / 10;
int a2 = number % 10;
WriteLine(number);
WriteLine(a1 > a2? a1:a2);
WriteLine(number % 2 == 0? "Even" : "Odd"); //  Тернальный оператор.
// if (a1 > a2)
// {
//     WriteLine(a1);
// }
// else
// {
//     WriteLine(a2);
// }