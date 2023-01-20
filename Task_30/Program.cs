// **Задача 44:** Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
//Ряд Фибначи - сумма двух предыдущих чисел равна следующему числу!

using static System.Console;
Clear();

Write("Enter the number of Fibonacci elements: ");
if(!int.TryParse(ReadLine(), out int N))
{
    WriteLine("Error. Enter integer number.");
    return;
}

// Первый способ - через массив.
if (N == 0)
{
    WriteLine("Error. You entered zero elements.");
    return;
} 
else if (N == 1)
{
    WriteLine(0);
     return;
}
else
{
    
    int[] FibonacciArray = fillFibonacci(N);
    PrintArray(FibonacciArray);
}
    


int[] fillFibonacci(int number)
{
    int[] resultArray = new int[number];
    resultArray[0] = 0;
    resultArray[1] = 1;
    for(int i = 2; i < resultArray.Length; i++)
    {
        resultArray[i] = resultArray[i - 1] + resultArray[i - 2];
    }
    return resultArray;
}

void PrintArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Write($"{arr[i]} ");
    }
}

//Второй способ через переменные?


void fibonacci(int number)
{
    
    for(int i = 0; i < number; i++)
    {
        
    }

}