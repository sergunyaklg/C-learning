//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Через строку решать нельзя.

int SecondDigit(int Number)
{
    int secondDigit = (Number / 10) % 10;
    return secondDigit;
}

Console.WriteLine("Введите трехзначное число: ");
int Number = Int32.Parse(Console.ReadLine());

int secondDigit = SecondDigit(Number);
Console.WriteLine("Вторая цифра: " + secondDigit);