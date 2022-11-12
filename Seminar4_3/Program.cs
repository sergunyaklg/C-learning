// Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А.

int GetSumFrom1ToN(int n)
{
    int result = 0;
    int count = 0;
    while (count < n)
    {
        count++;
        result += count;
    }
    return result;
}

Console.WriteLine("Прошграмма расчёт суммы чисел от 1 до N");
Console.WriteLine("Введите число N:");
int number = int.Parse(Console.ReadLine()!);

int result = GetSumFrom1ToN(number);

Console.WriteLine("Результат:" + result);