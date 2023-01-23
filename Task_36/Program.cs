// Какого цвета клетка шахматной доски, если начинается с черной?

using static System.Console;
Clear();
Write($"Enter coordinates chess board:");
string parameters = ReadLine()!;
int firstCoordinates = parameters[0];
int secondCoordinates = parameters[1];

WriteLine($"{firstCoordinates}, {secondCoordinates}");
if ((firstCoordinates + secondCoordinates) % 2 == 0) WriteLine("Black");
else WriteLine("White");

