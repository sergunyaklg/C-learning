// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.


Console.WriteLine("Введите число N: ");
int number = int.Parse(Console.ReadLine()!);

int FactorialDigit(int number)
{
    int count = 1;
    int result = 1;
    while (count <= number)
    {
        result = result * count;
        count++;
    }
    return result;
}

int result = FactorialDigit(number);

Console.WriteLine("Результат: " + result);
