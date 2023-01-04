// Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void Main()
{
    Console.Write("Введите число M: ");
    int M = Int32.Parse(Console.ReadLine());
    Console.Write("Введите число N: ");
    int N = Int32.Parse(Console.ReadLine());
    int sum = SumNumbers(M, N);
    Console.WriteLine($"Cумма натуральных элементов {sum}");
}

int SumNumbers(int m, int n)
{
    if (m > n)
    {
        return 0;
    }
    return m + SumNumbers(m + 1, n);
}

Main();
