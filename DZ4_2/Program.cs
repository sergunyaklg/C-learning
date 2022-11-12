// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через строку решать нельзя.

void SumOfDigits(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number /= 10;
    }
    Console.WriteLine("Сумма цифр в числе: " + sum);
}

Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine()!);
SumOfDigits(number);