Console.WriteLine("Введите первое число: ");
int a = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int c = Int32.Parse(Console.ReadLine());

int maxnumber = a;

// Math.max(a,b)
if (b > a)
{
    maxnumber = b;
}

// Math.max(c, Math.max(a,b)) === Math.max(a,b,c)
if (c > a)
{
    maxnumber = c;
}

Console.WriteLine($"Максимальное число: {maxnumber}.");