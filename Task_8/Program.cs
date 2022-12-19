using static System.Console;
Clear();

WriteLine("Введите любое число: ");
int number = int.Parse(ReadLine());

WriteLine(number % 7 == 0 && number % 23 == 0? "Да" : "Нет");

