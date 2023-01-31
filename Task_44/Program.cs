// **Задача 69:** Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

using static System.Console;
Clear();
Write("Enter two number by space: ");
int[] number = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);
WriteLine(PrintDegree(number[0], number[1]));

int PrintDegree(int num, int degree)
{
    if(degree == 1) return num;
    else return PrintDegree(num, degree - 1) * num;
}