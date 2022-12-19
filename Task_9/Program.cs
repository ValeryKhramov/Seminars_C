using static System.Console;
Clear();

WriteLine("Введите первое число: ");
int number_1 = int.Parse(ReadLine());

WriteLine("Введите второе число: ");
int number_2 = int.Parse(ReadLine());
WriteLine(number_1 * number_1 == number_2 ? $"{number_2} является квадратом числа {number_1}" :
     number_2 * number_2 == number_1 ? $"{number_1} является квадратом числа {number_2}" :
     " Не одно число не является квадратом другого." );