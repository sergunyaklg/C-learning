// Задача 1
//  Написать программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины.

// Console.WriteLine("Введите число A:");
// int a = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите число B:");
// int b = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите число C:");
// int c = int.Parse(Console.ReadLine()!);

// bool Treugolnik (int a, int b, int c)
// {
//     bool check = false;
//     if (a + b > c && a + c > b && b + c > a) return true;
//     else return false;
// }

// Console.WriteLine(Treugolnik(a, b, c));

// Задача 2
// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

// string BinaryDivision(int n)
// {
//     if (n == 0) return "0";
//     if (n == 1) return "1";
//     int ostatok = n % 2;
//     int del = n / 2;
//     return BinaryDivision(del) + ostatok;
// }

// Console.WriteLine("Введите число для преобразования:");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine(BinaryDivision(n));

// Задача 3
// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

void Fibonacci(int n)
{
    if (n >= 1) Console.Write("0 ");
    if (n >= 2) Console.Write("1 ");
    int[] array = new int[n];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < n; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
        Console.Write(array[i] + " ");
    }
}

Console.WriteLine("Введите число N:");
int n = int.Parse(Console.ReadLine()!);
Fibonacci(n);
