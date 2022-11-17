// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] CreatArrayWithRandomNumbers(int numbers = 4)
   {
        int[] result = new int[numbers];
        Random random = new();

        for (int i = 0; i < numbers; i++)
        {
            result[i] = random.Next(-100, 100);
        }
        return result;
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

int SumOfOddPositions(int[] input)
{
    int result = 0;
    for (int i = 1; i < input.Length; i++)
    {
        if (i % 2 != 0)
        {
            result += input[i];
        }
    }
    return result;
}

var array = CreatArrayWithRandomNumbers();
Print(array);
var sum = SumOfOddPositions(array);
Console.WriteLine($"Sum of odd position: {sum}");