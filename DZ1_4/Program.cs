Console.WriteLine("Введите число: ");
int a = Int32.Parse(Console.ReadLine());

for (int i = 2; i <= a; i += 2)
{
    if (i != 2)
    {
        Console.Write(",");
    }
    Console.Write($"{i}");
}
