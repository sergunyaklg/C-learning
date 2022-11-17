// Задайте массив, заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreatArrayWithRandomNumbers(int numbers = 4, 
                                  int startInterval = 100, 
                                  int endInterval = 1000)
   {
        int[] result = new int[numbers];
        Random random = new();

        for (int i = 0; i < numbers; i++)
        {
            result[i] = random.Next(startInterval, endInterval);

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

int NumberOfEvenNumbers(int[] input)
{
    int result = 0;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] % 2 == 0)
        {
            result += 1;
        }
    }
    return result;
}

var array = CreatArrayWithRandomNumbers();
Print(array);
var evennumbers = NumberOfEvenNumbers(array);
Console.WriteLine($"Number of even numbers: {evennumbers}");