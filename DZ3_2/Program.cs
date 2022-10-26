// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в N-мерном пространстве. 
// Сначала задается N с клавиатуры, потом задаются координаты точек.

Console.WriteLine("Введите размерность пространства N: ");
int N = int.Parse(Console.ReadLine()!);
int[] dotA = new int [N];
int[] dotB = new int [N];

for (int i = 0; i < N; i++)
{
    Console.WriteLine($"Введите {i}-ую координату точки A ():");
    dotA[i] = int.Parse(Console.ReadLine()!);
}

for (int i = 0; i < N; i++)
{
    Console.WriteLine($"Введите {i}-ую координату точки B ():");
    dotB[i] = int.Parse(Console.ReadLine()!);
}

void Distance(int[] dotA, int[] dotB)
{
    double SumOfSquares = 0;
    for (int i = 0; i < N; i++)
    {
        SumOfSquares += Math.Pow(dotA[i] - dotB[i], 2); 
    }

    double distance = Math.Sqrt(SumOfSquares);
    Console.WriteLine($"Расстояние между точками: {distance}");
}

Distance(dotA, dotB);


