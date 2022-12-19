using static System.Console;
Clear();

WriteLine("Введите первое число: ");
int number_1 = int.Parse(ReadLine());

WriteLine("Введите второе число: ");
int number_2 = int.Parse(ReadLine());
WriteLine(number_1 * number_1 == number_2 || number_2 * number_2 == number_1 ? "Одно число являеется квадратом другого" : "Не является квадратом" );