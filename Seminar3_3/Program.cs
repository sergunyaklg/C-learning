Console.Clear();
System.Console.WriteLine();

System.Console.Write("Enter a number: ");
string writeN = Console.ReadLine();
int N = Convert.ToInt32(writeN);

int[] GetSqrtTable(int N)
{
    int[] sqrtTable = new int[N];

    for (int i = 0, number = 1; i < N; i++, number++)
    {
        sqrtTable[i] = number * number;
    }
    return sqrtTable;
}

void PrintTable (int[] Array)
{
    int number = 1;
    for (int i = 0; i < Array.Length; i++)
    {
        System.Console.Write($"{number} ^ 2 =");
        System.Console.WriteLine(Array[i]);
        number++;
    }
}

int[] SqrtTable = GetSqrtTable(N);
PrintTable(SqrtTable);
