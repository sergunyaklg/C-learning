// Напишите программу, которая задаёт массив из 8 целых чисел с клавиатуры и далее выводит массив на экран в одну строку.

void CreatArrayWithNumbers (int numbers = 8)
{
    int[] input = new int[numbers];
    for (int i = 0; i < numbers; i++)
    {
        Console.WriteLine("Введите число:");
        input[i] = int.Parse(Console.ReadLine()!);
    }
    Print(input);
}

void Print(int[] input)
{
    for (int i = 0; i < input.Length; i++)
    {
        if (i == input.Length - 1)
        {
            Console.Write(input[i]);
        }
        else
        {
            Console.Write(input[i] + ", ");
        }
    }
    Console.WriteLine();
}

Console.WriteLine("Введите 8 чисел:");
CreatArrayWithNumbers();
