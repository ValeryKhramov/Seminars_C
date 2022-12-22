using static System.Console;
Clear();

Write("Введите значение x: ");
if (!int.TryParse(ReadLine(), out int x))
{
    WriteLine("Error.Input number, not string.");
    return;
}

Write("Введите значение y: ");
if (!int.TryParse(ReadLine(), out int y))
{
    WriteLine("Error.Input number, not string.");
    return;
}

if (x > 0)
{
    if (y > 0)
    {
        WriteLine("First quarter");
    }
    else
    {
        WriteLine("Forth quater");
    }
}
if (x < 0)
{
    if (y > 0)
    {
        WriteLine("Second quarter");
    }
    else
    {
        WriteLine("Third quater");
    }
}
