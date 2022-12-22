//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.


using static System.Console;
Clear();
WriteLine("Input coordinates first point: ");
if (!int.TryParse(ReadLine(), out int x1))
{
    WriteLine("Error. Input number, not string.");
    return;
}
if (!int.TryParse(ReadLine(), out int y1))
{
    WriteLine("Error. Input number, not string.");
    return;
}
WriteLine("Input coordinates second point: ");
if (!int.TryParse(ReadLine(), out int x2))
{
    WriteLine("Error. Input number, not string.");
    return;
}
if (!int.TryParse(ReadLine(), out int y2))
{
    WriteLine("Error. Input number, not string.");
    return;
}

WriteLine("Distance between two point is {0:f2}",Math.Sqrt(Math.Pow((x1 - x2),2) + Math.Pow((y1 - y2),2)));
