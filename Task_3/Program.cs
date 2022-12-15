using static System.Console;

WriteLine("Введите число: ");
int number = int.Parse(ReadLine());
int count = - number;

while (count != number + 1)
{
    WriteLine(count);
    count = count + 1;
}