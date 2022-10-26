// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Enter a number: ");
string writeN = Console.ReadLine();
int N = Convert.ToInt32(writeN);

int[] GetCoubTable(int N)
{
    int[] coubTable = new int[N];

    for (int i = 0, number = 1; i < N; i++, number++)
    {
        coubTable[i] = (int)Math.Pow(number, 3);
    }
    return coubTable;
}

void PrintTable (int[] Array)
{
    int number = 1;
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write($"{number} ^ 3 =");
        Console.WriteLine(Array[i]);
        number++;
    }
}

int[] CoubTable = GetCoubTable(N);
PrintTable(CoubTable);