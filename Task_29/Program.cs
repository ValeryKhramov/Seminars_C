// 6 знаков билетик: сумма первых трех равна сумме трех последних
// На входе 6 чисел, на выходе проверка счастливый или нет
using static System.Console;
Clear();

Write("Enter your ticket number: ");
if(!int.TryParse(ReadLine(), out int numTicket))
{
    WriteLine("Erorr. Enter not integer number.");
    return;
}

WriteLine($"Is your ticket a lucky one - {happyTicket(numTicket)}!");

bool happyTicket (int number)
{
    int sumFirst = 0, sumSecond = 0;
    while(number > 0)
    {
        if (number > 999)
        {
            sumSecond += number % 10;
            number /= 10;
        }
        else
        {
            sumFirst += number % 10;
            number /= 10;
        }

        
    }
    if (sumFirst == sumSecond) return true;
    else return false;

}