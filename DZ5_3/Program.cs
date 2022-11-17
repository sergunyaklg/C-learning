// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] CreatArrayWithRandomNumbers(int numbers = 4)
   {
        double[] result = new double[numbers];
        Random random = new();
        for (int i = 0; i < numbers; i++)
        {
            result[i] = random.NextDouble();

        }
        return result;
   }

void Print(double[] input)
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

double DifferenceBetweenMaxAndMin(double[] input)
{
    double result = 0;
    double max = input[0];
    double min = input[0];
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] > max)
        {
            max = input[i];
        }
        if (input[i] < min)
        {
            min = input[i];
        }
    }
    result = max - min;
    return result;
}

var array = CreatArrayWithRandomNumbers();
Print(array);
var difference = DifferenceBetweenMaxAndMin(array);
Console.WriteLine($"Difference between max and min: {difference}");
