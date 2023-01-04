// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

void Main()
{
    Console.Write("Введите число m: ");
    int M = Int32.Parse(Console.ReadLine());
    Console.Write("Введите число n: ");
    int N = Int32.Parse(Console.ReadLine());
    int ackerman = Ackerman(M, N);
    Console.WriteLine($"Функция Аккермана: {ackerman}");
}
int Ackerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return Ackerman(m - 1, 1);
    }
    else
    {
        return Ackerman(m - 1, Ackerman(m, n - 1));
    }
}

Main();
