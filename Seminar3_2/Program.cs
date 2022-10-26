double distance (int[] dotsA, int[] dotsB)
{
    return Math.Sqrt(Math.Pow(dotsA[0] - dotsB[0], 2) + Math.Pow(dotsA[1] - dotsB[1], 2));
}

int[] dotsA = new int[2];
int[] dotsB = new int[2];

Console.WriteLine("Введите координаты точки A (x):");
dotsA[0] = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координаты точки A (y):");
dotsA[1] = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координаты точки B (x):");
dotsB[0] = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координаты точки B (y):");
dotsB[1] = int.Parse(Console.ReadLine()!);


Console.WriteLine("Расстояние между точками: " + distance(dotsA, dotsB));