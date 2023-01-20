// Задача 40: Напишите программу,
// которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины
//Каждая сторона треугольника должна быть меньше, чнм сумма двух других сторон

using static System.Console;
Clear();

// WriteLine("Введите первую сторону треугольника: ");
// int firstSide = int.Parse(ReadLine()!);
// WriteLine("Введите вторую сторону треугольника: ");
// int secondSide = int.Parse(ReadLine()!);
// WriteLine("Введите третью сторону треугольника: ");
// int thirdSide = int.Parse(ReadLine()!);
Write("Enter the sides of the triangle separated by a space: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int firstSide = Convert.ToInt32(parameters[0]);
int secondSide = Convert.ToInt32(parameters[1]);
int thirdSide = Convert.ToInt32(parameters[2]);

WriteLine($"Can there be a triangle with sides:{firstSide} {secondSide} {thirdSide} - {InTriangle(firstSide, secondSide, thirdSide)}!");

bool InTriangle(int a, int b, int c)
{
    return (a + b > c && b + c > a && a + c > b);
}
