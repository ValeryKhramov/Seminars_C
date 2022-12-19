using static System.Console;
Clear();

WriteLine("Введите первое число: ");
int number_1 = int.Parse(ReadLine());

WriteLine("Введите второе число: ");
int number_2 = int.Parse(ReadLine());

WriteLine(number_1 % number_2 == 0? "Первое число кратное второму." : $"Остаток от деления равен = {number_1 % number_2}"); 