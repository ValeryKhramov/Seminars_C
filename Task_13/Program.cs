using static System.Console;
Clear();

// ЗАвод
// смена 3 человека
// 2 ток младш разряда
// 1 старшего

// Младшие одинаковое количество деталей
// Старший в 2 раза больше чем оба вместе взятые

// В конце смены докладывает сколько вся смена сделала деталей

// на вход количество деталей
// на выход либо токарь ошибся либо сколько деталей каждый сделал



Write("input number of Details:");

if (!int.TryParse(ReadLine(), out int DetNum))
{
    WriteLine("Error. Input number, not string");
    return;
}

//x + x + 4x = 6x

if (DetNum % 6 !=0)
{
    WriteLine ("Turner made arifmetical mistake. ");
}    
else
{
    WriteLine("Chief tutner made {0} details", (DetNum / 6) * 4);
    WriteLine("Subordinate turners made {0} details each", DetNum / 6);
}