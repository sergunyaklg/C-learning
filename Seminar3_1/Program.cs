int GetQuarterNumber(int x, int y)
{
    Console.WriteLine("GetQuarterNumber: " + x + "," + y);

    if (x > 0 && y > 0)
        return 1;
    
    if (x < 0 && y > 0)
        return 2;

    if (x < 0 && y < 0)
        return 3;

    if (x > 0 && y < 0)
        return 4;

    return -1;
}

Console.WriteLine("Введите координаты точки, числа X и Y");
Console.WriteLine("Введите X:");

int x = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите Y:");

int y = int.Parse(Console.ReadLine()!);

int result = GetQuarterNumber(x, y);

if (result > 0)
{
    Console.WriteLine("Номер четверти, в которой лежит точка: " + result);
}
else
{
    Console.WriteLine("Неверные входные данные");
}